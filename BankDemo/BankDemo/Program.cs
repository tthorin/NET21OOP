namespace BankDemo
{
    using System;
    class Program
    {
        static void Main()
        {
            string userName = "";
            string account = "";
            double cash = 0;
            Title("Snedbank");

            //fråga om PIN-koden
            do
            {
                string pinCode = AskQuestion("Ange din pinkod: ");
                if (pinCode == "1337")
                {
                    userName = "Mr. Leet";
                    account = "2672347-324";
                    cash = 50000.32d;
                }
                else
                {
                    Console.WriteLine("Fel PIN-kod!");
                }
            } while (account == "");

            int menuChoice = 0;
            while (menuChoice != 3)
            {
                Status(userName, account, cash);
                menuChoice = 0;


                while (menuChoice < 1 || menuChoice > 4)
                {
                    menuChoice = MainMenu();
                }

                //Insättning
                if (menuChoice == 1)
                {

                    Title("Insättning:");
                    double deposit = AskForCash("Hur mycket vill du sätta in? ", 10000);
                    cash = ModiyfyAccount(cash, deposit);
                }

                //Uttag
                else if (menuChoice == 2)
                {

                    Title("Uttag:");
                    double withdraw = AskForCash("Hur mycket vill du ta ut? ", cash);
                    cash = ModiyfyAccount(cash, -withdraw);
                }
            }
        }

        private static void Status(string userName, string account, double cash)
        {
            //presentera information
            Console.Clear();
            Title("Konto");
            Console.WriteLine("Namn : " + userName);
            Console.WriteLine("Konto: " + account);
            Console.WriteLine("Saldo: " + cash);
        }

        private static int MainMenu()
        {
            int menuChoice;
            Title("Meny");
            Console.WriteLine("1) Insättning.");
            Console.WriteLine("2) Uttag.");
            Console.WriteLine("3) Logga ut.");
            string input = AskQuestion("Välj: ");
            _ = int.TryParse(input, out menuChoice);
            return menuChoice;
        }

        private static double ModiyfyAccount(double cash, double deposit)
        {
            cash += deposit;
            Console.WriteLine("Saldo: " + cash);
            return cash;
        }


        //========================================================
        static string AskQuestion(string question)
        {
            Console.Write(question);
            return Console.ReadLine();
        }
        //========================================================


        //========================================================
        static void Title(string title)
        {
            Console.WriteLine("+---------------------------------+");
            Console.WriteLine($"|{title.ToUpper(),-33}|");
            Console.WriteLine("+---------------------------------+");
        }
        //========================================================
        //========================================================
        static double AskForCash(string question, double maxValue)
        {
            string input = AskQuestion(question);
            double value = CheckConversion(input);

            if (value < 0)
            {
                Console.WriteLine("Du angav ett negativt värde.");
                value = 0;
            }
            else if (value > maxValue)
            {
                Console.WriteLine("Du angav ett för stort värde.");
                value = 0;
            }

            return value;
        }
        //========================================================
        //========================================================
        static double CheckConversion(string stringToConvert)
        {
            bool converted = false;
            double number = 0;
            do
            {
                converted = double.TryParse(stringToConvert, out number);

                if (!converted)
                {
                    Console.WriteLine("Vänligen använd endast siffror: ");
                    stringToConvert = Console.ReadLine();
                }

            } while (!converted);
            return number;
        }
        //========================================================

    }
}

