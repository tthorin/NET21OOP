using System.IO;

namespace EM
{
    partial class Program
    {
        public abstract class FileStuff
        {
            public string ReadFile(string filename)
            {
                return File.ReadAllText(filename);
            }
            public void SaveFile(string filename,string text)
            {
                File.WriteAllText(filename, text);
            }
            public abstract bool DoesFileExist(string filename);
        }
        public class FileStuffX : FileStuff
        {
            public override bool DoesFileExist(string filename)
            {
                return File.Exists(filename);
            }
        }
    }
}
