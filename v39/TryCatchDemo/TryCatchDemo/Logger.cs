namespace TryCatchDemo
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Diagnostics;

    static class Logger
    {
        public static void LogThis(this Exception ex)
        {   
            Debug.WriteLine(ex.Message); //funkar bara i debug läge, inte release
            System.IO.File.AppendAllText("log.txt", DateTime.Now.ToString() + " " + ex.Message + "\r\n");
            System.IO.File.AppendAllText("log.txt", $"{DateTime.Now.ToString()} {ex.Source} {ex.StackTrace}");
        }
    }
}
