using System;

namespace DiceGameWithClasses
{
    internal class DiceGame
    {
        public DiceGame(int v)
        {
            V = v;
        }

        public DiceGame(int v, int v1) : this(v)
        {
            V1 = v1;
        }

        internal void Run()
        {
            throw new NotImplementedException();
        }

        public int V { get; }
        public int V1 { get; }
    }
}