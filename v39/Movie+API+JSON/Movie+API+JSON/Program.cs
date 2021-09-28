namespace Movie_API_JSON
{
    using System;
    static class Program
    {
        static void Main(string[] args)
        {
            var searchResult = OMDB.Search("heist");
            OMDB.PrintMovies(searchResult);
            Console.ReadKey(true);
            var resultMovie = OMDB.GetMovieByTitle("true romance");
            OMDB.PrintMovie(resultMovie);
            Console.WriteLine(searchResult.Search[0].imdbID);
            Console.WriteLine(resultMovie.Plot);
            Console.WriteLine(resultMovie.Poster);
        }
    }
}
