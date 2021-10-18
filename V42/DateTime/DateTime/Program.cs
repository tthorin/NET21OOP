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
            TodayInfo();
        }

        private static void ConcepcionDay(DateTime birthDay)
        {
            int month = birthDay.Month - 9 > 0 ? birthDay.Month - 9 : birthDay.Month + 12 - 9;
            int year = birthDay.Month - 9 > 0 ? birthDay.Year : birthDay.Year - 1;
            var cDay = new DateTime(year, month, birthDay.Day);
            Console.WriteLine("Birthday: "+birthDay.ToString("D"));
            Console.WriteLine("Conception day is: " + cDay.ToString("D")+"\n");
        }

        static void DateInOneWeek()
        {
            var inOnwWeek = DateTime.Now.AddDays(7);
            Console.WriteLine("Om en vecka är det: " + inOnwWeek.ToLongDateString()+"\n");
        }
        static void HalloweenWeekDay()
        {
            var halloween = new DateTime(2021, 10, 31);
            Console.WriteLine("Halloween 2021 är på en: " + halloween.DayOfWeek+"\n");
        }
        static void TodayInfo()
        {
            var today = DateTime.Now;
            Console.WriteLine("Today is: "+today.ToString("D"));
            Console.WriteLine("Number: "+today.DayOfYear);
            Console.WriteLine("Day of week: "+ today.DayOfWeek);
            Console.WriteLine("Daylight savingstime: "+today.IsDaylightSavingTime()+"\n");
        }
    }
}
