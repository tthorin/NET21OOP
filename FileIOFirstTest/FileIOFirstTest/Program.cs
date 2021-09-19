namespace FileIOFirstTest
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            string line = "";
            try
            {
                string pathAndFile = @"d:\arger\ko.txt";
                StreamReader sr = new StreamReader(pathAndFile);
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption: " + e.Message);
            }
            finally
            {
                Console.WriteLine("finally block");
            }
            Console.Write("Skriv någonting: ");
            string input = Console.ReadLine();

            try
            {
                StreamWriter sw = new StreamWriter("d:\\arger\\ko.txt", true);
                sw.WriteLine(input);
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exeption: " + e.Message);
            }
            finally
            {
                Console.WriteLine("write finally");
            }

        }
    }
}
