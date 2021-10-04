namespace Seasons // in the sun :)
{
    using System;

    enum Months
    {
        Januari = 1,
        Februari,
        Mars,
        April,
        Maj,
        Juni,
        Juli,
        Augusti,
        September,
        Oktober,
        November,
        December
    }

    class Program
    {

        static void Main(string[] args)
        {
            for (int i = 1; i <= 12; i++)
            {
                //Enum.TryParse(typeof(Months), i, out (object)string month); // :-O 

                var month = (Months)i;

                // alternativt (Months)i; funkar också bra ;)

                var season = "";
                season = month switch
                {
                    Months.Januari => "Vinter",
                    Months.Februari => "mer vinter",
                    Months.Mars => "Tar vintern aldrig slut :-O",
                    Months.April => "aaagghh ännu mer vinter...",
                    Months.Maj => "Hmm fortfarande Vinter",
                    Months.Juni => "Istid kanske?",
                    Months.Juli => "Mysko väder",
                    Months.Augusti => "Snart är det vinter igen",
                    Months.September => "agghh mer vinter",
                    Months.Oktober => "Väldigt mycket vinter iår",
                    Months.November => "Nu är det officiellt vinter igen... nästan",
                    Months.December => "Nu så... äntligen vinter",
                    _ => "Vinter just in case",
                };
                Console.WriteLine(month + ", " + season);
            }
            Console.ReadLine();
        }
    }
}
