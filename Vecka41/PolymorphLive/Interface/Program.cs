namespace Interface
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            List<IHello> helloList = new();
            helloList.Add(new Spanish());
            helloList.Add(new English());

            foreach (var hello in helloList)
            {
                hello.SayHello();
                hello.SayGoodBye();
            }
            List<IInsulter> insultList = new();
            insultList.Add(new Spanish());
            insultList.Add(new English());

            foreach (var insult in insultList)
            {
                insult.Insult();
                insult.SayCat();
            }

        }
        public interface IGame
        {
            bool IsPlaying { get; set; }
            void StartGame();
            void GetHighScore();
        }
        public interface IHello
        {
            void SayHello();
            void SayGoodBye();
        }
        public interface IInsulter
        {
            void Insult();
            void SayCat() => Console.WriteLine("Cat");
        }
        public class Spanish : IHello,IInsulter
        {
            public void SayHello() => Console.WriteLine("Hola");

            public void SayGoodBye() => Console.WriteLine("Choa");
            public void Insult() => Console.WriteLine("Idiota");
            
        }
        public class English : IHello,IInsulter
        {
            public void SayHello() => Console.WriteLine("Hello");

            public void SayGoodBye() => Console.WriteLine("Goodbye");
            public void Insult() => Console.WriteLine("twit");
        }
    }
}
