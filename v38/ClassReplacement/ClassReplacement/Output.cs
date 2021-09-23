namespace ClassReplacement
{
    using System;
    using System.IO;
    internal class Output
    {
        public virtual void Print(string text)
        {
            Console.WriteLine(text);
        }
        public void Box(string text)
        {
            string top = "+" + new string('-', text.Length) + "+\r\n";
            string middle = "|" + text + "|\r\n";

            Print(top);
            Print(middle);
            Print(top);
        }
        
    }
    internal class FileOutPut : Output
    {
        public override void Print(string text)
        {
            string fileName = "MyText.txt";
            bool firstWrite = true;
            if (firstWrite)
            {
                File.WriteAllText(fileName, "");
                firstWrite = false;
            }
            
            File.AppendAllText(fileName, text);
        }
    }
}