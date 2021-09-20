namespace OOPDemo3
{
    using System;
    //POCO = Plain Old C Object
    //       Plain Old Class Object
    //POJO = Plain Old Java Object
    
    internal class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }
        public Cat(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }
    }
}