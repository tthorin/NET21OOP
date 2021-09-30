namespace Movie_API_JSON
{
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using Helpers;

    public static class OMDB
    {
        private static Movie GetMovie(string url, string id)
        {
            string json = ReadCache(id);
            if (json == "")
            {
                using (var wc = new System.Net.WebClient())
                {
                    json = wc.DownloadString(url);
                    WriteCache(id, json);
                }
            }
            return JsonConvert.DeserializeObject<Movie>(json);
        }
        public static Movie GetMovieByTitle(string title, string year = "", bool fullPlot = false)
        {
            var url = $"http://www.omdbapi.com/?apikey={Settings.Key}&t={title}&y={year}";
            if (fullPlot) url += "&plot=full";
            return GetMovie(url, title + year + fullPlot);
        }
        public static Movie GetMovieByIMDB(string imdb, string year = "", bool fullPlot = false)
        {
            var url = $"http://www.omdbapi.com/?apikey={Settings.Key}&i={imdb}";
            if (fullPlot) url += "&plot=full";
            return GetMovie(url, imdb + year + fullPlot);
        }

        private static SearchResult SearchMovie(string url, string id)
        {
            string json = ReadCache(id);
            if (json == "")
            {
                using (var wc = new System.Net.WebClient())
                {
                    json = wc.DownloadString(url);
                    WriteCache(id, json);
                }
            }
            var obj = JsonConvert.DeserializeObject<SearchResult>(json);
            return obj;
        }
        public static SearchResult Search(string title, string year = "", string type = "", string page = "1")
        {
            var url = $"http://omdbapi.com/?apikey={Settings.Key}&s={title}&y={year}&type={type}&page={page}";
            return SearchMovie(url, title + year + type + page);
        }

        public static void PrintMovies(SearchResult result)
        {
            Console.WriteLine($"{result.totalResults} movies found.");
            foreach (var movie in result.Search)
            {
                Console.WriteLine($"{movie.Title,-40} {movie.Year}");
            }
        }
        public static void PrintMovie(Movie movie)
        {
            Console.WriteLine($"{movie.Title}, {movie.Year}");
            Console.WriteLine(movie.Actors);
        }
        private static string ReadCache(string file)
        {
            var filename = $"{file}.cache.json";
            string cache = "";
            if (File.Exists(filename))
            {
                cache = File.ReadAllText(filename);
            }
            return cache;
        }
        private static void WriteCache(string file, string json)
        {
            var filename = $"{file}.cache.json";
            File.WriteAllText(filename, json);
        }
    }
}
