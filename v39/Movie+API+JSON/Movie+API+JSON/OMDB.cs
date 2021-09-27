namespace Movie_API_JSON
{
    using Newtonsoft.Json;
    using System;
    using System.IO;

    public static class OMDB
    {
        public static Movie GetMovie(string url, string id)
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
        public static Movie GetMovieByTitle(string title, string year = "", bool longPlot = false)
        {
            var url = $"http://www.omdbapi.com/?apikey={Settings.Key}&t={title}&y={year}";
            if (longPlot) url += "&plot=long";
            return GetMovie(url, title + year + longPlot);
        }
        public static Movie GetMovieByIMDB(string imdb, string year = "", bool longPlot = false)
        {
            var url = $"http://www.omdbapi.com/?apikey={Settings.Key}&i={imdb}";
            if (longPlot) url += "&plot=long";
            return GetMovie(url, imdb+year+longPlot);
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
                Console.WriteLine($"{movie.Title,40}{movie.Year}");
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
