namespace SendingObjects.Helpers
{
    using System;

    static class PersonHelper
    {
        /// <summary>
        /// Prints persons first and last name to console
        /// </summary>
        /// <param name="person"></param>
        public static void PrintPerson(Person person)
        {
            Console.WriteLine(person.Name + " " + person.LastName);
        }

        /// <summary>
        /// Trims and cleans up name formatting
        /// </summary>
        /// <param name="person"></param>
        static public void CleanUp(Person person)
        {
            person.Name = CleanUp(person.Name);
            person.LastName = CleanUp(person.LastName);
        }

        private static string CleanUp(string name)
        {
            name = name.Trim();
            name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
            return name;
        }
    }
}
