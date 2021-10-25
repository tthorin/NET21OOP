namespace TicketChooser
{
    using System;

    class Program
    {
        static void Main()
        {
            var planner = new TicketChooser();
            var trips = 8;
            var zones = 2;
            var sum = 0d;

            foreach (var ticket in planner.Västtrafik(zones,trips))
            {
                var price = 0d;
                var idx = zones - 1;
                switch (ticket)
                {
                    case Enums.Tickets.Enkelbiljett:
                        price = planner.DayPrices[idx];
                        break;
                    case Enums.Tickets.TrettiDagars:
                        price = planner.MonthPrices[idx];
                        break;
                    case Enums.Tickets.NittiDagars:
                        price = planner.TrimesterPrices[idx];
                        break;
                    case Enums.Tickets.Årsbiljett:
                        price = planner.YearPrices[idx];
                        break;
                    case Enums.Tickets.Error:
                        price = planner.DayPrices[idx];
                        break;
                    default:
                        break;
                }
                Console.WriteLine(ticket+":\t"+price+" kr.");
                sum += price;
            }
            Console.WriteLine("\nSumma:\t\t"+sum+" kr.");

          
        }
    }
    
}
