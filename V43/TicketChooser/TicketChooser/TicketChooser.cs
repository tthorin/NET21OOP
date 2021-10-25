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

        public Tickets[] Västtrafik(int zones = 1,int tripsPlanned=1)
        {
            var roundTrip = 2;
            var trips = tripsPlanned * roundTrip;
            List<Tickets> tickets = new();

            if (zones > 3) zones = 3;
            else if (zones < 1) zones = 1;

            while (trips > 0)
            {
                var sumDay = trips * DayPrices[zones];
                
                double[] sorted = 
        }
    }
}
