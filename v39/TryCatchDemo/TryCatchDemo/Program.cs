namespace TryCatchDemo
{
    using System;
    using System.Diagnostics;
    using System.Collections.Generic;
    

    class Program
    {
        static void Main(string[] args)
        {
            int div1 = 0;
            int div2 = 0;
            List<string> data = null;

            try
            {
                data.Add("test");
                int silly = div1 / div2;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Kan inte dela med noll");
                ex.LogThis();
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Objektet är null");
                ex.LogThis();
            }
            
        }
    }
}
