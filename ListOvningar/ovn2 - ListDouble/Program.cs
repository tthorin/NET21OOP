namespace ListOvningar
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            List<double> triangleSides = new();
            double number = 0;

            Console.WriteLine("Ange längden på sida 1: ");
            string input = Console.ReadLine();
            double.TryParse(input, out number);
            triangleSides.Add(number);

            Console.WriteLine("Ange längden på sida 2: ");
            input = Console.ReadLine();
            double.TryParse(input, out number);
            triangleSides.Add(number);

            Console.WriteLine("Ange längden på sida 3: ");
            input = Console.ReadLine();
            double.TryParse(input, out number);
            triangleSides.Add(number);

            triangleSides.Sort();

            double circumference = 0;
            foreach (double side in triangleSides)
            {   
                circumference += side;
            }
            double area = (triangleSides[0] * triangleSides[1]) / 2;
            Console.WriteLine($"Omkretsen är {circumference} och arean är {area}");
            
        }
    }
}
