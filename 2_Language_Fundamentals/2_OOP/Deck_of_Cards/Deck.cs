using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        public List<object> cards;  // a list of Card objects

        public Deck()
        {
            // a list of 52 unique cards as its "cards" property
        }

        public object Deal()
        {
            object top_card = ;
            // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card
            return top_card;
        }

        public void Reset()
        {
            // Give the Deck a reset method that resets the cards property to contain the original 52 cards
        }

        public void Shuffle()
        {
            // Give the Deck a shuffle method that randomly reorders the deck's cards
        }
    }
}