using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Player
    {
        public string Name;
        public List<Card> Hand;
    
        public Player(string name)
            {
                Name = name;
                Hand = new List<Card>();
            }
    
        public Card Draw(Deck deck)
        {
            // draws a card from a deck, adds it to the player's hand and returns the Card; 
            //    Note this method will require reference to a deck object

            Card card = deck.Deal();
            Hand.Add(card);
            return card;
        }

        public object Discard()
        {
            // Give the Player a discard method which discards the Card at the specified index from 
            // the player's hand and returns this Card or null if the index does not exist.
            
            // create 
            // return 
        }
    }


}