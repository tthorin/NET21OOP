using System;

namespace NET21_inlämning1
{
    class Program
    {
        //=============Start Main====================
        static void Main()
        {
            int bet = 0;
            int minBet = 50;
            int luckyNumber = 0;
            int[] diceResult = new int[3];
            Random dice = new Random();
            int startPix = 500;
            int currentPix = startPix;
            bool keepPlaying = true;
            string input = "";
            int diceToRoll = 3;
            int sameNumber = 0;

            Console.Clear();
            Console.WriteLine("Hej och välkommen till Fortuna-spelet,");
            Console.WriteLine("");
            Console.WriteLine("Det går till så att du väljer ditt lyckotal och en summa att satsa,");
            Console.WriteLine("efter det så rullar vi tre tärningar och beroende på hur många av dom");
            Console.WriteLine("som blev samma (om någon) så vinner du enligt följande:");
            Console.WriteLine("");
            Console.WriteLine("En tärning samma som ditt tal: dubbla insatsen.");
            Console.WriteLine("Två tärningar samma som ditt tal: tre gånger insatsen.");
            Console.WriteLine("Tre tärningar samma som ditt tal: .oO !!JACKPOT!! Oo. FYRA gånger insatsen!");
            Console.WriteLine("(Minsta insats är 50 pix)\n");

            while (keepPlaying)
            {
                sameNumber = 0;
                do
                {
                    Console.Write("Hur mycket vill du satsa? ");
                    input = Console.ReadLine();
                    bet = InputToInt(input);
                    if (bet < minBet)
                    {
                        Console.WriteLine("Minsta insatsen är 50 pix, var god försök igen.");
                    }
                    else if (bet > currentPix)
                    {
                        Console.WriteLine($"Du kan inte satsa fler pix än du har. Ditt nuvarande pix-saldo är {currentPix}.");
                        Console.WriteLine("Var god försök igen.");
                    }

                } while (bet > currentPix || bet < minBet);

                do
                {
                    Console.Write("Vilket är ditt lyckotal? ");
                    input = Console.ReadLine();
                    luckyNumber = InputToInt(input);
                    if (luckyNumber > 6)
                    {
                        Console.WriteLine("Ditt tal behöver vara mellan 1 och 6, försök igen.");
                    }
                } while (luckyNumber < 0 || luckyNumber > 6);

                for (int i = 0; i < diceToRoll; i++)
                {
                    diceResult[i] = dice.Next(1, 7);
                    Console.WriteLine(diceResult[i]);
                    if (diceResult[i] == luckyNumber)
                    {
                        sameNumber++;
                    }
                }

                Console.WriteLine(sameNumber); //TODO rensa

                if (sameNumber > 0)
                {
                    if (sameNumber == 3) currentPix += bet * 4;
                    else if (sameNumber == 2) currentPix += bet * 3;
                    else currentPix += bet * 2;
                }
                else
                {
                    currentPix -= bet;
                }

                Console.WriteLine(currentPix); //TODO rensa


                if (currentPix < minBet)
                {
                    Console.WriteLine("Tyvärr, du har för lite pix på ditt saldo för minsta insatsen, bättre lycka nästa gång.");
                    Console.WriteLine("Hej då och på återseende!");
                    keepPlaying = false;
                }
                else
                {
                    Console.Write("Spela igen ([J]/n)? ");
                    input = Console.ReadLine().ToLower();
                    if (input == "n" || input == "nej")
                    {
                        Console.WriteLine("Hoppas du har haft det kul! :)");
                        Console.WriteLine("Hej då och på återseende!");
                        keepPlaying = false;
                    }
                }
            }
        }
        //============End of Main======================

        //==================Start int InputToInt(string) method==============
        //simple method to parse a string to make sure we can convert it
        //to int
        static int InputToInt(string input)
        {
            bool converted = false;
            int intValue = 0;
            //loop til we have valid conversion
            while (!converted)
            {
                converted = int.TryParse(input, out intValue);

                //we only want a positive value
                if (converted && intValue < 1)
                {
                    converted = false;
                    Console.Write("Vänligen ange ett tal över 0: ");
                    input = Console.ReadLine();
                }
                //if we couldnt convert, ask for a new value
                else if (!converted)
                {
                    Console.Write("Vänligen använd bara siffror och ange ett positivt tal: ");
                    input = Console.ReadLine();
                }
            }
            //return the converted value
            return intValue;
        }
        //==================end int InputToInt(string) method==============

        //==================Start void PrintDice(int[]) method==============
        static void PrintDice(int[] diceResult)
        {
            int numberOfDice = 3;
            int dieHeight = 5;
            int dieWidth = 5;
            Console.WriteLine("");
            int startRow = Console.CursorTop;
            int startColumn = Console.CursorLeft;
            for (int i = 0; i < numberOfDice; i++)
            {
                for (int j = 0; j < dieHeight; j++)
                {

                }

            }
        }
        //==================end void PrintDice(int[]) method==============
    }
}
