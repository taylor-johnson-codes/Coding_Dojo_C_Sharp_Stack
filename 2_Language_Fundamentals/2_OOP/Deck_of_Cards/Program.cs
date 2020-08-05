namespace Deck_of_Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player me = new Player("Taylor");
            Deck newDeck = new Deck();

            me.Draw(newDeck);
            me.Draw(newDeck);
            me.Draw(newDeck);
            me.Draw(newDeck);
            me.Draw(newDeck);

            me.Discard(1);

            me.Draw(newDeck);

            newDeck.Shuffle();

            newDeck.Reset();
        }
    }
}
