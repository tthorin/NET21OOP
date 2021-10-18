namespace SmallestNumberFirst
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            SmallestNumberFirst(1, 9999999);
            
        }
        static public void SmallestNumberFirst(int a, int b) // SWAP :)
        {
            if (a < b)
            {
                int temp = a; 
                a =  b;
                b = temp;
            }

            Console.WriteLine($"{a} är större än {b}");

        }
    }
}
