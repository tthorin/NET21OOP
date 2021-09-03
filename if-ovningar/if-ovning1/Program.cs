using System;

namespace if_ovning1
{
    class Program
    {
        
        static void Main()
        {
            int a = 0;
            int b = 0;
            int c = 0;

            while (true)
            {
                Console.Write("Ange sida A: ");
                string sidaA = Console.ReadLine();
                Console.Write("Ange sida B: ");
                string sidaB = Console.ReadLine();
                Console.Write("Ange sida C: ");
                string sidaC = Console.ReadLine();

                bool funkarA = int.TryParse(sidaA, out a);
                bool funkarB = int.TryParse(sidaB, out b);
                bool funkarC = int.TryParse(sidaC, out c);

                bool posA = a > 0;
                bool posB = b > 0;
                bool posC = c > 0;

                if (funkarA && funkarB && funkarC)
                {
                    if (posA && posB && posC)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Alla värden måste vara positiva.");
                    }
                }
                else
                {
                    Console.WriteLine("Vänligen använd bara siffror.");
                }
            }
            var omkrets = a + b + c;
            Console.WriteLine("Omkretsen är " + omkrets);
        }
    }
}
