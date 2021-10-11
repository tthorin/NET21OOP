namespace IOutput
{
    using System;
    class Test
    {   
        IOutput output;

        public Test(IOutput output)
        {
            this.output = output;
        }

        public void Log()
        {   
            output.WriteLine("----------------------");
            output.WriteLine("- Min coola logg -");
            output.WriteLine("----------------------");
            output.WriteLine(DateTime.Now.ToString("d MMMM yyyy"));
        }
    }
}
