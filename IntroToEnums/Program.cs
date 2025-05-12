namespace IntroToEnums
{
    internal class Program
    {
        enum CardValue
        {
            Two = 2,
            Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack, Queen, King, Ace
        }

        enum Suit
        {
            Heart, Diamond, Spade, Club
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            for (int i = 1; i < 7; i++)
            {
                CardValue cardValue = (CardValue)rnd.Next(2, 15);
                Suit suit = (Suit)rnd.Next(4);

                Console.WriteLine(cardValue + " of " + suit);
            }
        }
    }
}
