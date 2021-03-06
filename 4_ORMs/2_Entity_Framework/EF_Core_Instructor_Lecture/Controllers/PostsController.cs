// This could all be in the HomeController if you want.

// Name it plural like the name of the DB table.

using System;
using System.Collections.Generic;
using System.Linq;
using EF_Core_Instructor_Lecture.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_Instructor_Lecture.Controllers
{
    public class PostsController : Controller
    {
        // for less code in all the methods:
        // gets user_id
        private int? user_id { get {return HttpContext.Session.GetInt32("UserId");} }

        // gets boolean if user is logged in or not
        private bool isLoggedIn { get {return user_id != null;} }

        private MyContext db;
        public PostsController(MyContext context)
        {
            db = context;
        }

        [HttpGet("/posts")]
        public IActionResult All()
        {
            // if user not logged in, returns user to login/reg page:
            if(!isLoggedIn)  // LONGHAND, w/o code above db code: if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            List<Post> allPosts = db.Posts
                .Include(post => post.Author)
                .Include(post => post.Votes)  // would need to use .ThenInclude() if I wanted to get something else from the Author
                // .ThenInclude(vote => vote.Voter)  // if I wanted to know who made the vote
                .OrderByDescending(p => p.CreatedAt)
                .ToList();
                // does a SQL join:
                // SELECT * FROM posts 
                // JOIN users ON users.UserId = posts.UserId  (one-to-many)
                // JOIN votes ON posts.UserId = Votes.PostId (many-to-many)

            return View("All", allPosts);  
            // sending over allPosts as a model instead of thru ViewBag
        }

        [HttpGet("/posts/new")]
        public IActionResult New()
        {
            // if user not logged in, returns user to login/reg page:
            if(!isLoggedIn)  // LONGHAND, w/o code above db code: if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index", "Home");
            }
            return View("New");
        }

        [HttpPost("/posts/create")]
        public IActionResult Create(Post newPost)
        {
            // validations check:
            if (ModelState.IsValid == false)
            {
                return View("New");
            }

            // Assign Author 
            newPost.UserId = (int)user_id;

            db.Posts.Add(newPost);
            db.SaveChanges();

            return RedirectToAction("All");
        }

        [HttpGet("/posts/{post_id}")]  // post_id is string in URL
        public IActionResult Details(int post_id)  // now it's an int
        {
            // if user not logged in, returns user to login/reg page:
            if(!isLoggedIn)  // LONGHAND, w/o code above db code: if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Post selectedPost = db.Posts
            .Include(post => post.Author)  // does a SQL join; SELECT * FROM users JOIN posts ON users.UserId = posts.UserI
            .FirstOrDefault(p => p.PostId == post_id);

            if (selectedPost == null)
            {
                return RedirectToAction("All");
            }
            return View("Details", selectedPost);
            // sending over selectedPost as a model instead of thru ViewBag
        }

        [HttpPost("/posts/{post_id}/delete")]
        // "post_id" coming from "asp-route-post_id" in HTML
        // if using a-tag instead of form & button in HTML, this will need to be HttpGet
        public IActionResult Delete(int post_id)
        {
            Post selectedPost = db.Posts.FirstOrDefault(p => p.PostId == post_id);

            if (selectedPost != null || selectedPost.UserId != user_id)
            {
                db.Posts.Remove(selectedPost);
                db.SaveChanges();
            }
            return RedirectToAction("All");
        }

        [HttpGet("/posts/{post_id}/edit")]
        public IActionResult Edit(int post_id)
        {
            Post selectedPost = db.Posts.FirstOrDefault(p => p.PostId == post_id);

            if (selectedPost == null || selectedPost.UserId != user_id)
            {
                return RedirectToAction("All");
            }
            return View("Edit", selectedPost);
            // sending over selectedPost as a model instead of thru ViewBag
        }

        [HttpPost("/posts/{post_id}/update")]
        public IActionResult Update(Post editedPost, int post_id)
        {

            // validations check:
            if (ModelState.IsValid == false)
            {
                return View("Edit", editedPost);
            }

            Post selectedPost = db.Posts.FirstOrDefault(p => p.PostId == post_id);

            if (selectedPost == null)
            {
                return RedirectToAction("All");
            }

            // Existing DB info is prefilled, so if the user doesn't edit a section, the DB will save the exisitng info
            selectedPost.Topic = editedPost.Topic;
            selectedPost.Body = editedPost.Body;
            selectedPost.ImgURL = editedPost.ImgURL;
            selectedPost.UpdatedAt = DateTime.Now;

            db.Posts.Update(selectedPost);
            db.SaveChanges();

            // "Details" needs a parameter so we have to pass it a dict
            return RedirectToAction("Details", new { post_id = post_id });
        }

        // more Vote functionality than simple Vote below
        // has this voter already voted
        [HttpPost("posts/{postid}/{isUpVote}")]
        public IActionResult Vote(Vote newVote)
        {
            newVote.UserId = (int)user_id;

            Vote existingVote = db.Votes.FirstOrDefault(vote => vote.PostId == newVote.PostId && vote.UserId == newVote.UserId);
            
            if(existingVote == null)  // if no existing vote, add it to the DB
            {
                db.Votes.Add(newVote);
            }
            else  // if they've already voted, are they changing their vote?
            {
                // voting the same way means they are trying to remove their vote
                if(existingVote.IsUpVote == newVote.IsUpVote)
                {
                    db.Votes.Remove(existingVote);
                }
                // changing their vote
                else
                {
                    existingVote.IsUpVote = newVote.IsUpVote;
                    existingVote.UpdatedAt = DateTime.Now;
                    db.Votes.Update(existingVote);
                }
            }
            db.SaveChanges();

            return RedirectToAction("All");

            // "Details" needs a parameter so we have to pass it a dict
            // return View("Details", new { post_id = newVote.PostId });
        }


        /*
        // Simple many-to-many Vote:
        [HttpPost("posts/{postid}/{isUpVote}")]
        // for (Vote newVote) to work, lettering of post_id needs to match DB so postid works because letters match PostId, and post_id wouldn't work
        public IActionResult Vote(Vote newVote)
        {
            newVote.UserId = (int)user_id;
            db.Votes.Add(newVote);
            db.SaveChanges();

            // "Details" needs a parameter so we have to pass it a dict
            return View("Details", new { post_id = newVote.PostId });
        }

        // alternate of the above:

        [HttpPost("posts/{post_id}/{isUpVote}")]
        public IActionResult Vote(int post_id, bool isUpVote)
        {
            Vote newVote = new Vote()
            {
                PostId = post_id,
                IsUpVote = isUpVote
            };

            newVote.UserId = (int)user_id;
            db.Votes.Add(newVote);
            db.SaveChanges();

            // "Details" needs a parameter so we have to pass it a dict
            return View("Details", post_id);
            // return View("Details", new { post_id = newVote.PostId });
        }
        */
    }
}