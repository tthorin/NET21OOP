namespace Cars
{
    using System;

    class JohnnyCab:Tesla
    {
        public double SpeakingRobotVersion { get; set; } = 1;
        public string DummyBody { get; set; } = "Johnny";
        public bool CanSelfExplode { get; set; } = true;
        public void SelfExplode()
        {
            if (CanSelfExplode) Console.WriteLine("BOOM!");
            else Console.WriteLine("Cabs can't just go around and self explode...... right?");
        }
    }
}
