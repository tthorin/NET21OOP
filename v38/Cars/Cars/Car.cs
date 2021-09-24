namespace Cars
{
    using System;

    class Car
    {
        public int Wheels { get; set; } = 4;
        public int SteeringWheel { get; set; } = 1;
        public int Doors { get; set; } = 4;
        public int Gears { get; set; } = 6;
        public string Model { get; set; } = "Standard";
        public string Manufacturer { get; set; } = "CarCorp";
        public int Year { get; set; } = 2021;

        public void Start()
        {
            Console.WriteLine("You start the car.");
        }
        public void Stop()
        {
            Console.WriteLine("You stop the car.");
        }
        public void GearUp()
        {
            Console.WriteLine("You change to a higher gear.");
        }
        public void GearDown()
        {
            Console.WriteLine("You change to a lower gear.");
        }
        public void GoFaster()
        {
            Console.WriteLine("You speed up.");
        }
        public void GoSlower()
        {
            Console.WriteLine("You slow down.");
        }
    }
}
