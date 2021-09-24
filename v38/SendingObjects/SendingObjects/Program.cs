namespace SendingObjects
{
    using System;
    using static Helpers.PersonHelper;

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person { Name = "            jaCkie", LastName = "      CHaN          " };
            CleanUp(person);
            PrintPerson(person);
        }
    }
}
