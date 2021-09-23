namespace AnimalFarm
{
    using System;
    using System.Collections.Generic;

    partial class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new()
            {
                new Hyena() { Name = "Hihihi" },
                new Dog() { Name = "Vovve" },
                new Cat() { Name = "Misse" },
                new Cat() { Name = "Mjau" },
                new Horse() { Name = "Brunte" },
                new Hippogriff() { Name = "Vindfåle" }
            };

            foreach (var animal in animals)
            {
                if (animal is Cat)
                    Console.WriteLine(animal.Name);
            }
        }
    }
}
