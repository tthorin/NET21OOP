

namespace SwitchOvnSvar
{
    using System;
    using SwitchOvnSvar.Enums;
    class Program
    {
        static void Main(string[] args)
        {
            string monthInput = "";
            do
            {
                Console.Write("Skriv in en månad: ");
                string input = Console.ReadLine().Trim();

                monthInput = input.Substring(0, 1).ToUpper();
                monthInput += input.Substring(1).ToLower();
            } while (!Enum.IsDefined(typeof(Months), monthInput));

            Months month = (Months)Enum.Parse(typeof(Months),monthInput);

            switch (month)
            {
                case Months.Januari:
                    Console.WriteLine("1 - Nyår!");
                    break;
                case Months.Februari:
                    Console.WriteLine("Andra måndagen i februari: Clean Out Your Computer Day!");
                    break;
                case Months.Mars:
                    Console.WriteLine("14 - Pi dagen! 3.14");
                    break;
                case Months.April:
                    Console.WriteLine("12 - Lakritsdagen!");
                    break;
                case Months.Maj:
                    Console.WriteLine("Sista söndagen: Mors Dag!");
                    break;
                case Months.Juni:
                    Console.WriteLine("30 - Pilsnerkorvens dag!");
                    break;
                case Months.Juli:
                    Console.WriteLine("1 - Nu är det juli igen!");
                    Console.WriteLine("20 - Marcus blir ännu äldre!");
                    break;
                case Months.Augusti:
                    Console.WriteLine("9 - Mumindagen!");
                    break;
                case Months.September:
                    Console.WriteLine("21 - Thomas ett år äldre.");
                    break;
                case Months.Oktober:
                    Console.WriteLine("22 - INTERNATIONELLA CAPS LOCK-DAGEN");
                    Console.WriteLine("30 - Jul oktalt (oct 30 = 24 dec)");
                    break;
                case Months.November:
                    Console.WriteLine("Andra söndagen: Fars dag.");
                    break;
                case Months.December:
                    Console.WriteLine("23 - Handla-julklappar-i-sista-minuten-dagen");
                    Console.WriteLine("24 - Julafton");
                    break;
                default:
                    break;
            }



        }

    }
}
