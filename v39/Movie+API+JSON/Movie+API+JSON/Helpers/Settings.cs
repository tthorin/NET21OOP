namespace Movie_API_JSON.Helpers
{
    using System.IO;
    using System;
    public static class Settings
    {
        public static string Key { get; set; } = LoadKey();
        
        private static string LoadKey()
        {
            var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file = Path.Combine(path, @"\APIKeys\omdb.txt");
            string key = File.ReadAllText(file);
            return key;
        }

    }
}
