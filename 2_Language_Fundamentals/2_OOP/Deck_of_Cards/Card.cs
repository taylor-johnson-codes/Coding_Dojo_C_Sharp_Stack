namespace Deck_of_Cards
{
    public class Card
    {
        public string StringVal {get;set;}  // will hold the value of the card ex. (Ace, 2, 3, 4, 5, 6, 7, 8, 9, 10, Jack, Queen, King)
        public string Suit {get;set;}  // will hold the suit of the card (Clubs, Spades, Hearts, Diamonds)
        public int Val {get;set;}  // will hold the numerical value of the card 1-13 as integers

        public Card(string stringVal, string suit, int val)
        {
            StringVal = stringVal;
            Suit = suit;
            Val = val;
        }
    }
}