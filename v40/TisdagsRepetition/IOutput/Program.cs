namespace IOutput
{
    using System;

    class Program
    {
        static void Main()
        {
            Test test = new Test(new DebugOutput());
            test.Log();

            Inside inne = new();
            inne.siffra = 15;
            int siffra = 5;
            Inside annan = new();
            annan = inne;

            Outside ute = new Outside(siffra, annan);

            Console.WriteLine(ute.inne.siffra + " " + ute.intVar);

            inne.siffra = 37;
            siffra = 12;

            Console.WriteLine(ute.inne.siffra + " " + ute.intVar);
            
            ute.inne.siffra = 42;
            ute.intVar = 30;

            Console.WriteLine(inne.siffra + " "+ siffra);
            Console.ReadLine();
        }
    }
    public class Inside
    {
        public int siffra = 10;
    }
    public class Outside
    {
        public Inside inne;
        public int intVar;
        public Outside(int number, Inside inne)
        {
            this.inne = inne;
            intVar = number;
        }
    }
}
