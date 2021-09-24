using System;
using System.Collections.Generic;

namespace ClassObjects
{
    class Program
    {
        static void Main(string[] args)
        {   
            List<MovieInformation> movieList = new List<MovieInformation>()
            {
                    new MovieInformation()
                    {
                        Name = "Elf",
                        Actors = "Will Ferrel",
                        StarRating = 1
                    },
                    new MovieInformation()
                    {
                        Name = "Death Wish",
                        Actors = "Bruce Willis",
                        StarRating = 4
                    },
                    new MovieInformation()
                    {
                        Name = "Malignant",
                        Actors = "Annabelle Wallis, Maddie Hasson",
                        StarRating = 10
                    },
                    new MovieInformation()
                    {
                        Name = "Death Note",
                        Actors = "Nat Wolff, LaKeith Stanfield, Margaret Qualley",
                        StarRating = 3
                    }
            };
            foreach (var movie in movieList)
            {
                movie.PrintMovie();
            }


        }
    }
}