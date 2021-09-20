namespace OOPDemo2
{
    using System;
    internal class ClassLifeTime
    {
        private int value;
        
        public int Value
        {
            get { return Value; }

            set
            {
                if (value > 50) this.Value = 50;
                else if (value < 0) this.Value = 0;
            }
        }


        public ClassLifeTime()
        {
            Console.WriteLine("klassen föds");
        }
        ~ClassLifeTime()
        {
            Console.WriteLine("klassen dör");
        }
    }
}