namespace CryptoTest
{
    using System;
    using System.IO;
    using System.Security.Cryptography;

    internal class LoginHandler
    {
        public string SaveDir { get; set; } = "Save";
        public string UsersFile { get; set; } = "users.txt";
        public string UserPath { get => Path.Combine(SaveDir, UsersFile); }
        private int SaltLenght = 18;
        private int passLenght = 36;
        private int passIterations = 2000;

        public LoginHandler()
        {
            if (!Directory.Exists(SaveDir)) Directory.CreateDirectory(SaveDir);
            if (!File.Exists(UserPath)) File.Create(UserPath);
        }
        internal void Add(User newUser)
        {
            string[] file = File.ReadAllLines(UserPath);
            bool userExists = false;
            foreach (var line in file)
            {
                if (line.StartsWith(newUser.Name)) userExists = true;
            }
            if (!userExists) File.AppendAllText(UserPath, newUser.ToString() + "\n");
        }
        public void Login()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            string password = GetPassword();
            ValidateLogin(username, password);
        }

        private static string GetPassword()
        {
            Console.Write("Password: ");
            ConsoleKeyInfo cki = new();
            string password = "";
            while (true)
            {
                Console.CursorVisible = false;
                cki = Console.ReadKey(true);
                if (cki.Key == ConsoleKey.Enter) break;

                password += (cki.Modifiers & ConsoleModifiers.Shift) != 0 ? cki.Key.ToString() : cki.Key.ToString().ToLower();
                Console.Write("*");
            }
            Console.CursorVisible = true;
            return password;
        }

        public void NewUser()
        {
            User newUser = new();
            Console.Write("Username: ");
            string username = Console.ReadLine();
            string password = GetPassword();
            
            newUser.Name = username;
            newUser.Salt = GenerateSalt(SaltLenght);
            newUser.Password = GenerateHash(password, newUser.Salt);
            Add(newUser);
        }

        private void ValidateLogin(string username, string password)
        {
            string[] file = File.ReadAllLines(UserPath);
            string userSalt = "";
            string userHash = "";
            var userFound = false;

            for (int i = 0; i < file.Length; i++)
            {
                if (file[i].StartsWith(username, StringComparison.InvariantCulture) && file[i].IndexOf(' ') == username.Length)
                {
                    userFound = true;
                    int spaceAt = file[i].IndexOf(' ');
                    int nextSpace = file[i].IndexOf(' ', spaceAt + 1);
                    userSalt = file[i].Substring(spaceAt + 1, (nextSpace - spaceAt) - 1);
                    userHash = file[i].Substring(nextSpace + 1, (file[i].Length - nextSpace) - 1);
                }
            }
            if (userFound)
            {
                if (userHash == Convert.ToBase64String(GenerateHash(password, Convert.FromBase64String(userSalt))))
                    Console.WriteLine("\nPassword correct");
                else
                    Console.WriteLine("\nWrong password");
            }
            else Console.WriteLine("\nUsername not found");
        }

        private byte[] GenerateSalt(int saltLenght)
        {
            var salt = new byte[saltLenght];
            using (var random = new RNGCryptoServiceProvider())
            {
                random.GetBytes(salt);
            }
            return salt;
        }
        private byte[] GenerateHash(string password, byte[] salt)
        {

            using (var deriveBytes = new Rfc2898DeriveBytes(password, salt, passIterations))
            {
                return deriveBytes.GetBytes(passLenght);
            }

        }
        public void Run()
        {
            while (true)
            {
                Console.WriteLine("New user, Login or Exit?");
                string answer = Console.ReadLine();
                switch (answer)
                {

                    case "new user" or "new" or "n": NewUser(); break;
                    case "login" or "l": Login(); break;
                    case "exit" or "e": break;
                    default: break;
                }
                if (answer == "exit" || answer == "e") break;
            }
        }
    }
}