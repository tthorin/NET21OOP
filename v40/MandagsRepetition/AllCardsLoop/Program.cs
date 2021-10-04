namespace AllCardsLoop
{
    using System;

    class Program
    {
        static void Main()
        {
            string[] cards = new string[52];
            int counter = 0;


            for (int suit = 1; suit <= 4; suit++)
            {
                var suite = "";
                if (suit == 1) suite = "Hjärter";
                else if (suit == 2) suite = "Spader";
                else if (suit == 3) suite = "Ruter";
                else suite = "Klöver";
                
                for (int card = 1; card <= 13; card++)
                {
                    string cardName = "";
                    if (card == 1) cardName = "Äss";
                    else if (card < 11) cardName = card.ToString();
                    else if (card == 11) cardName = "Knekt";
                    else if (card == 12) cardName = "Dam";
                    else cardName = "Kung";

                    cards[counter] = suite + " " + cardName;

                    //Console.WriteLine(cards[counter]);

                    counter++;
                }
            }
            Console.Write("Ange en siffra mellan 1 och 52: ");
            int.TryParse(Console.ReadLine(), out int cardChoice);
            Console.WriteLine($"Du valde: {cards[cardChoice]}");
            Console.ReadLine();
        }

    }
}
