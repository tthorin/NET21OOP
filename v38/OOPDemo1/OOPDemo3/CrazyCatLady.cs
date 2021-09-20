namespace OOPDemo3
{
    using System;
    using System.Collections.Generic;
    internal class CrazyCatLady
    {
        List<Cat> Cats = new List<Cat>();
        internal void Start()
        {
            Cat newCat = new Cat
            {
                Name = "Misse",
                Age = 5,
                Color = "orange"
            };
            Cats.Add(newCat);
            Cat anotherCat = new Cat
            {
                Name = "Bombalurina",
                Age = 10,
                Color = "svart"
            };
            Cats.Add(anotherCat);

            Cat myCat = new Cat
            {
                Name = "Katt",
                Age = 8,
                Color = "vit"
            };
            Cats.Add(myCat);
            PrintCats();
        }

        private void PrintCats()
        {
            foreach (var cat in Cats)
            {
                Console.WriteLine($"Katten {cat.Name} är {cat.Age} år gammal och har färgen {cat.Color}.");
            }
        }
    }
}