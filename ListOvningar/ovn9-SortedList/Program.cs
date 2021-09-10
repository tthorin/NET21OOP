namespace ovn9_SortedList
{
    using System;
    using System.Collections.Generic;
    class Program
    {
        static void Main()
        {
            //hade varit lättare att göra en SortedList<char,string>
            //men det är gjort enl. övningen som angav string,string
            SortedList<string, string> numberList = new();
            numberList.Add("4", "Fyra");
            numberList.Add("3", "Tre");
            numberList.Add("0", "Noll");
            numberList.Add("2", "Två");
            numberList.Add("1", "Ett");
            numberList.Add("9", "Nio");
            numberList.Add("7", "Sju");
            numberList.Add("5", "Fem");
            numberList.Add("8", "Åtta");
            numberList.Add("6", "Sex");

            foreach (KeyValuePair<string,string> kvp in numberList)
            {
                Console.WriteLine(kvp.Key + " : " +kvp.Value);
            }
            Console.Write("Ange ett tal: ");
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                if (numberList.ContainsKey(input[i].ToString()))
                    Console.Write(numberList[input[i].ToString()]);
            }
        }
    }
}
