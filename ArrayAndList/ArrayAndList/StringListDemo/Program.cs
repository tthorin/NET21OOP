using System;
using System.Collections;

namespace StringListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arr = new ArrayList();
            arr.Add(5);
            arr.Add("Hello World");
            arr.Add(3.1415);

            foreach (object data in arr)
            {
                Console.Write(data.GetType()+": ");
                if (data is int) Console.WriteLine("Nummer: " + ((int)data + 4));
                else if (data is string) Console.WriteLine("Text: " + data.ToString());
                else if (data is double) Console.WriteLine("Double: " + (double)data);
                else Console.WriteLine(data);
            }
        }
    }
}
