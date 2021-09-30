namespace TryCatchOvn
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> badList = null;
            int[] intArr = new int[3];

            //int tooMuch = 1000000000000000000000000000000000000000000000000000000000000000000000000000000000000;
            try
            {   
                badList.Add("text");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("index är utanför gränsen.");
                Console.WriteLine(ex.Message);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Objekter är null!");
                Console.WriteLine(ex.Message);
            }
            catch (Exception)
            {
                Console.WriteLine("nåt annat gick fel");
            }
            finally
            {
                badList = null;
            }
        }
    }
    
}
