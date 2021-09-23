namespace POCOandDTOdemo
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new();
            person.Name = "Bruce";
            person.LastName = "Willis";
            person.BirthDate = DateTime.Parse("1955, march 19");
            Console.WriteLine(person.Age);
            person.Adress.City = "New York";
            person.Adress.Street = "Bleecker Street";
            Console.WriteLine(person.ToString()); ;
        }
    }

    internal class Person
    {
        /// <summary>
        /// First name of the person
        /// </summary>
        public string Name { get; set; } = "";
        /// <summary>
        /// Last name of the person
        /// </summary>
        public string LastName { get; set; } = "";
        /// <summary>
        /// Birthdate of the person
        /// </summary>
        public DateTime BirthDate { get; set; } = DateTime.Now;
        /// <summary>
        /// Age of the person based on birthdate and today
        /// </summary>
        public int Age { get => (int)((DateTime.Now - BirthDate).Days / 365.25); }
        public Adress Adress { get; set; } = new();

        public override string ToString()
        {
            return $"{Name} {LastName}, born on {BirthDate.ToString("dd MMMM, yyyy")} and is {Age} years old.\nLives on {Adress.Street} in {Adress.City}.";
        }
    }

    public class Adress
    {
        public string City { get; set; } = "";
        public string Street { get; set; } = "";
    }
}
