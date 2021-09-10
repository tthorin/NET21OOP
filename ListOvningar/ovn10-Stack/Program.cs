namespace ovn10_Stack
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Stack<int> stack = new();

            for (int i = 1; i < 21; i++)
            {
                stack.Push(i);
            }
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());
        }
    }
}
