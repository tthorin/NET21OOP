namespace IOutput
{
    using System.IO;
    public class FileOutput:IOutput
    {
        public void Write(string text)
        {
            File.AppendAllText("text.txt", text);
        }
        public void WriteLine(string text)
        {
            File.AppendAllText("text.txt", text + "\r\n");
            

        }
        
    }
}
