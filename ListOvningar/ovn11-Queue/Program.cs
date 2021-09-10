namespace ovn11_Queue
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            Queue<string> schedule = new();

            schedule.Enqueue("Borsta tänderna.");
            schedule.Enqueue("Duscha.");
            schedule.Enqueue("Torka av sig.");
            schedule.Enqueue("Torka av golvet.");
            schedule.Enqueue("Klä på sig.");
            schedule.Enqueue("Gå till skolan.");
            schedule.Enqueue("Plugga massor.");

            while (schedule.Count>0)
            {
                Console.WriteLine(schedule.Dequeue());
            }
        }
    }
}
