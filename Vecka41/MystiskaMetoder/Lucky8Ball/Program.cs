namespace Lucky8Ball
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Lucky8Ball();
        }

        static public void Lucky8Ball()
        {
            List<string> answers = new List<string>
            {
                "It is certain.",
                "It is decidedly so.",
                "Without a doubt.",
                "Yes definitely.",
                "You may rely on it.",
                "As I see it, yes.",
                "Most likely.",
                "Outlook good.",
                "Yes.",
                "Signs point to yes.",
                "Reply hazy, try again.",
                "Ask again later.",
                "Better not tell you now.",
                "Cannot predict now.",
                "Concentrate and ask again.",
                "Don't count on it.",
                "My reply is no.",
                "My sources say no.",
                "Outlook not so good.",
                "Very doubtful."
             };

            Random rng = new();
            Console.WriteLine(answers[rng.Next(answers.Count + 1)]);

            //--------------------------
            (string Name, int age) person = ("pelle", 32);
            Console.WriteLine(person.Name);//------------

            (string, int) person2 = ("nisse", 25);
            Console.WriteLine(person2.Item1);//---------
        }

        //    MinFunktion((x) =>
        //    {
        //        Console.Write(x);
        //        return "hej";
        //    });

        //}

        //static public (string, int, Func<int, string>) MinFunktion(Func<int, Func<int, Func<int,Func<int<string>> func)
        //{
        //    string str  =  "";
        //    int a  =  3;

        //    func(3);

        //    return (str, a, func)
        //}
    }
}
