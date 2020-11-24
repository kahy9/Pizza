using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Pizza
    {
        public Pizza(string name, Base @base, Sauce sauce, params Topping[] toppings)
        {
            Name = name;
            Base = @base;
            Sauce = sauce;
            Toppings = toppings;
        }

        public string Name { get; }
        public Base Base { get; }
        public Sauce Sauce{ get; }
        public Topping[] Toppings{ get; }

    }

    class Components
    {

        public Components(string description, decimal price)
        {
            Description = description;
            Price = price;
        }


        public decimal Price { get; }
        public string Description { get; }
    }

    class Sauce : Components
    {
        public Sauce(string description, decimal price) : base(description, price)
        {
        }
    }

    class Shape
    {
        public Shape(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public decimal Price { get; }
        public string Description { get; }

        public static Shape Hexagon = new Shape("Hexagon shape", 30);
        public static Shape Circle = new Shape("Circle - 30cm", 60);
    }

    class Base : Components
    {
        public Base(string description, decimal price) : base(description, price)
        {

        }

        public static Base Crust = new Base("Crust", 50);
        public static Base Flat = new Base("Flat", 60);

    }

    class Topping : Components
    {
        public Topping(string description, decimal price) : base(description, price)
        {

        }

        public static Topping Hawaii = new Topping("Pizza with Pineapple <3", 120);
        public static Topping Ham = new Topping("Pizza with Ham", 110);

    }
}
