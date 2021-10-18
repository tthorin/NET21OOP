namespace DateTime
{
    using System;

    class Program
    {
        static void Main()
        {
            DateInOneWeek();
            HalloweenWeekDay();
            var maggio = new DateTime(1981, 3, 15);
            ConcepcionDay(maggio);
        }

        private static void ConcepcionDay(DateTime birthDay)
        {
            int month = birthDay.Month - 9 > 0 ? birthDay.Month - 9 : birthDay.Month + 12 - 9;
            int year = birthDay.Month - 9 > 0 ? birthDay.Year : birthDay.Year - 1;
            var cDay = new DateTime(year, month, birthDay.Day);
            Console.WriteLine("Birthday: "+birthDay.ToString("D"));
            Console.WriteLine("Conception day is: " + cDay.ToString("D"));
        }

        static void DateInOneWeek()
        {
            var inOnwWeek = DateTime.Now.AddDays(7);
            Console.WriteLine("Om en vecka är det: " + inOnwWeek.ToLongDateString());
        }
        static void HalloweenWeekDay()
        {
            var halloween = new DateTime(2021, 10, 31);
            Console.WriteLine("Halloween 2021 är på en: " + halloween.DayOfWeek);
        }
    }
}
