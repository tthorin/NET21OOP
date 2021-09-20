namespace DiceGameWithClasses
{
    using System;

    class Program
    {
        static void Main()
        {
            DiceGame dg = new DiceGame(3,6);
            dg.Run();
        }
    }
}
