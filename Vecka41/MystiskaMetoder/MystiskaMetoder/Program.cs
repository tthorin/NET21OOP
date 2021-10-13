namespace MystiskaMetoder
{
    using System;

    class Program
    {
        static void Main()
        {
            DaysTillXmas(DateTime.Now);
        }
        static public void DaysTillXmas(DateTime today)
        {
            DateTime xMas = new DateTime(2021, 12, 24);
            TimeSpan daysTilXmas = xMas - today;
            Console.WriteLine("Dagar till jul: "+ daysTilXmas.Days);
        }
    }
}
