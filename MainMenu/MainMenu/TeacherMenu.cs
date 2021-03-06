namespace MainMenu
{
    using System;
    using System.Collections.Generic;

    public class TeacherMenu : Menu
    {
        // Visar menyn
        public override void PrintMenu()
        {
            Cursor = "Choose: ";
            Console.Clear();

            // Hitta hur brett menyn är allt som allt
            int maxWidth = Title.Length;
            foreach (var row in MenuOptions)
            {
                if (row.Length > maxWidth) maxWidth = row.Length;
            }
            maxWidth += 10; // to be able to handle numbers too

            string top = "╔" + new string('═', maxWidth) + "╗";
            string middle = "╠" + new string('═', maxWidth) + "╣";
            string bottom = "╚" + new string('═', maxWidth) + "╝";

            Console.WriteLine(top);
            Console.WriteLine(Center(Title, maxWidth));
            Console.WriteLine(middle);
            Console.WriteLine(Pretty("", maxWidth));
            for (int i = 0; i < MenuOptions.Count; i++)
            {
                // Lägger till 1 i menyvalen för att användaren inte ska behöva tänka på att
                // börja från 0
                Console.WriteLine(Pretty("[" + (i + 1) + "] " + MenuOptions[i], maxWidth));
            }
            Console.WriteLine(Pretty("", maxWidth));
            Console.WriteLine(bottom);
        }

        private static string Pretty(string text, int maxWidth)
        {
            return "║ " + text.PadRight(maxWidth - 2) + " ║";
        }
        private static string Center(string text, int maxWidth)
        {
            var spaces = maxWidth - 2 - (text.Length / 2);
            return Pretty(text.PadLeft(spaces), maxWidth);
        }
    }
}