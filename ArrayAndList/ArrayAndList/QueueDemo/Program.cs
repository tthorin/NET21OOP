using System;
using System.Collections.Generic;

namespace QueueDemo
{
    class Program
    {
        static void Main()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("Skicka mail");
            q.Enqueue("Printa ut resultat");

            Console.WriteLine("Count : "+q.Count);
            Console.WriteLine("Peek: "+ q.Peek());
            Console.WriteLine("Dequeue: " +q.Dequeue());
            Console.WriteLine("Peek: " + q.Peek());
            Console.WriteLine("Dequeue: " + q.Dequeue());
        }
    }
}
