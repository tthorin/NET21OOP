namespace Movie_API_JSON
{
    using Newtonsoft.Json;
    using System;

    static class Program
    {
        static void Main(string[] args)
        {
            string title = "spider";
            var url = $"http://www.omdbapi.com/?apikey={Settings.Key}&s={title}";
            var result = SearchMovie(url);
            Console.WriteLine(result.totalResults + " movies found.");
            foreach (var movie in result.Search)
            {
                Console.WriteLine("  " + movie.Title.PadRight(40) +  movie.Year);
            }
            Console.WriteLine(result.Response);
        }
        


    }
}
