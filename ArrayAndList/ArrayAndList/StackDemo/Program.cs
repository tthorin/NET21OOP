using System;
using System.Collections.Generic;


namespace StackDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new();
            
            stack.Push("Kolla mailen");
            stack.Push("Svara på mail");
            stack.Push("Lyssna på musik");
            

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Vad ligger överst? (Peek): " + stack.Peek());
            Console.WriteLine("Ta bort den översta (Pop): " +  stack.Pop());
            Console.WriteLine("Vad ligger överst? (Peek): " + stack.Peek());
            Console.WriteLine("Ta bort den översta (Pop): " + stack.Pop());
        }


    }
}
