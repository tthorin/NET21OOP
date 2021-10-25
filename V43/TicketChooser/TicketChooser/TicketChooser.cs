namespace TicketChooser
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Enums;

    public class TicketChooser
    {
        public double[] DayPrices { get; private set; } = new double[] { 34, 68, 102 };
        public double[] MonthPrices { get; private set; } = new double[] { 795, 1195, 1825 };
        public double[] TrimesterPrices { get; private set; } = new double[] { 2145, 3225, 4930 };
        public double[] YearPrices { get; private set; } = new double[] { 7950, 11950, 18250 };

        public List<Tickets> Västtrafik(int zones = 1, int tripsPlanned = 1)
        {   
            var roundTrip = 2;
            float trips = tripsPlanned * roundTrip;
            List<Tickets> tickets = new();

            if (zones > 3) zones = 3;
            else if (zones < 1) zones = 1;

            while (trips > 0)
            {
                var sumDay = trips * DayPrices[zones-1];
                var sumMonth = MonthPrices[zones-1] * Math.Ceiling(trips  / 60);
                var sumTriMonth = TrimesterPrices[zones - 1] * Math.Ceiling(trips / 360);
                var sumYear = YearPrices[zones - 1] * Math.Ceiling(trips / 365 * 2);

                double[] sorted = new double[] { sumDay, sumMonth, sumTriMonth, sumYear };
                Array.Sort(sorted);

                if (sorted[0] == sumDay)
                {
                    tickets.Add(Tickets.Enkelbiljett);
                    tickets.Add(Tickets.Enkelbiljett);
                    trips -= roundTrip;
                }
                else if (sorted[0] == sumMonth)
                {
                    tickets.Add(Tickets.TrettiDagars);
                    trips -= 30 * roundTrip;
                }
                else if (sorted[0] == sumTriMonth)
                {
                    tickets.Add(Tickets.NittiDagars);
                    trips -= 90 * roundTrip;
                }
                else
                {
                    tickets.Add(Tickets.Årsbiljett);
                    trips -= 365 * roundTrip;
                }
            }
            return tickets;
        }
    }
}
