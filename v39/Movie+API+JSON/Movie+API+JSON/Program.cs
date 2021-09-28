namespace Movie_API_JSON
{   
    static class Program
    {
        static void Main(string[] args)
        {
            var searchResult = OMDB.Search("heist");
            OMDB.PrintMovies(searchResult);
            var resultMovie = OMDB.GetMovieByTitle("true romance");
            OMDB.PrintMovie(resultMovie);
        }
    }
}
