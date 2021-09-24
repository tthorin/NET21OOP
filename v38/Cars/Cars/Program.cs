namespace Cars
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            SecretServiceCar ssc = new SecretServiceCar();
            ssc.PlaySpotify();
            ssc.IsBulletProof = false;
            ssc.SelfCheck();
            Car tesla = new Tesla();
            ((Tesla)tesla).SelfTest();
            ((Tesla)tesla).UpdateFirmware();
            ((Tesla)tesla).SelfTest();
            List<Car> cars = new();
            cars.Add(ssc);
            cars.Add(tesla);
            cars.Add(new JohnnyCab());
            foreach (var car in cars)
            {
                car.Start();
                Console.WriteLine(car.Manufacturer);
                if (car is JohnnyCab)
                {
                    ((JohnnyCab)car).ActivateAI();
                    ((JohnnyCab)car).SelfExplode();
                }
            }
        }
    }
}
