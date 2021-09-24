namespace ClassObjects
{
    using System;
    using System.Collections.Generic;
    internal class MovieInformation
    {
        public string Name { get; set; } = "";
        public string Actors { get; set; } = "";
        public int StarRating { get; set; } = 0;
        
        public void PrintMovie()
        {
            Console.WriteLine(Name + " - " + Actors);
            Console.WriteLine("Stars: " + new string('*', StarRating) + "\n");
        }
    }
}