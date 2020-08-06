using System;
using System.Collections.Generic;

namespace Deck_of_Cards
{
    public class Deck
    {
        public List<Card> Cards = new List<Card>();  // a list of Card objects

        public Deck()
        {
            // a list of 52 unique cards as its "Cards" property

            string[] cardStringVal = {"Ace","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};

            string[] cardSuit = {"Club","Spades","Hearts","Diamonds"};

            int[] cardVal = {1,2,3,4,5,6,7,8,9,10,11,12,13};

            for(int i = 0 ; i < cardStringVal.Length; i++)
            {
                for(int j = 0; j < cardSuit.Length; j++)
                {
                    Cards.Add(new Card(cardStringVal[i], cardSuit[j], cardVal[i]));
                }
            }
        }

        public Card Deal()
        {
            // Give the Deck a deal method that selects the "top-most" card, removes it from the list of cards, and returns the Card
            Card card = Cards[Cards.Count-1];
            Cards.Remove(Cards[Cards.Count-1]);
            return card;

            // need to add if Deck > 0, else Deck is empty
        }

        public void Reset()
        {
            // Give the Deck a reset method that resets the cards property to contain the original 52 cards
            Cards = new Deck().Cards;
        }

        public void Shuffle()
        {
            // Give the Deck a shuffle method that randomly reorders the deck's cards

            Random random = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int randomIndex = random.Next(0, Cards.Count);
                Card temp = Cards[i];
                Cards[i] = Cards[randomIndex];
                Cards[randomIndex] = temp;

                /* ALTERNATE:
                Card currentCard = Card[i];
                Card randomCard = Cards[randomIndex];
                Cards[i] = randomCard;
                Cards[randomIndex] = currentcard;
                */

                /* ALTERNATE:
                public void Shuffle<Temp>(List<Temp> cards) 
                {
                    private Random rng = new Random();
                    int n = cards.Count;
                    while (n > 1) {
                        n--;
                        int k = rng.Next(n + 1);
                        Temp card = cards[k];
                        cards[k] = cards[n];
                        cards[n] = card;
                    }
                }
                */
            }
        }
    }
}