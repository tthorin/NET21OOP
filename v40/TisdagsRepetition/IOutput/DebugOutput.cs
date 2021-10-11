namespace IOutput
{
    using System.Diagnostics;

    public class DebugOutput : IOutput
    {
        public void Write(string text)
        {
            Debug.Write(text);
        }

        public void WriteLine(string text)
        {
            Debug.WriteLine(text);
        }
    }
}
