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
                .Include(post => post.Author)  // does a SQL join; SELECT * FROM users JOIN posts ON users.UserId = posts.UserId
                .OrderByDescending(p => p.CreatedAt)
                .ToList();

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

        [HttpGet("/posts/{postId}")]  // postId is string in URL
        public IActionResult Details(int postId)  // now it's an int
        {
            // if user not logged in, returns user to login/reg page:
            if(!isLoggedIn)  // LONGHAND, w/o code above db code: if(HttpContext.Session.GetInt32("UserId") == null)
            {
                return RedirectToAction("Index", "Home");
            }

            Post selectedPost = db.Posts
            .Include(post => post.Author)  // does a SQL join; SELECT * FROM users JOIN posts ON users.UserId = posts.UserI
            .FirstOrDefault(p => p.PostId == postId);

            if (selectedPost == null)
            {
                return RedirectToAction("All");
            }
            return View("Details", selectedPost);
            // sending over selectedPost as a model instead of thru ViewBag
        }

        [HttpPost("/posts/{postId}/delete")]
        // "postId" coming from "asp-route-postId" in HTML
        // if using a-tag instead of form & button in HTML, this will need to be HttpGet
        public IActionResult Delete(int postId)
        {
            Post selectedPost = db.Posts.FirstOrDefault(p => p.PostId == postId);

            if (selectedPost != null || selectedPost.UserId != user_id)
            {
                db.Posts.Remove(selectedPost);
                db.SaveChanges();
            }
            return RedirectToAction("All");
        }

        [HttpGet("/posts/{postId}/edit")]
        public IActionResult Edit(int postId)
        {
            Post selectedPost = db.Posts.FirstOrDefault(p => p.PostId == postId);

            if (selectedPost == null || selectedPost.UserId != user_id)
            {
                return RedirectToAction("All");
            }
            return View("Edit", selectedPost);
            // sending over selectedPost as a model instead of thru ViewBag
        }

        [HttpPost("/posts/{postId}/update")]
        public IActionResult Update(Post editedPost, int postId)
        {

            // validations check:
            if (ModelState.IsValid == false)
            {
                return View("Edit", editedPost);
            }

            Post selectedPost = db.Posts.FirstOrDefault(p => p.PostId == postId);

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

            return RedirectToAction("Details", new {postId = postId});
        }
    }
}