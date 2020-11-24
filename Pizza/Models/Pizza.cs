using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Pizza.Models;

namespace Pizza
{
    class Pizza : IHasPrice, IEnumerable<Components>
    {
        private Pizza(string name, Shape shape, Base @base, Sauce sauce, params Topping[] toppings)
        {
            Name = name;
            Shape = shape;
            Base = @base;
            Sauce = sauce;
            Toppings = toppings;
        }

        public string Name { get; }
        public Shape Shape { get; }
        public Base Base { get; }
        public Sauce Sauce{ get; }
        public Topping[] Toppings{ get; }

        public decimal Price
        {
            get
            {
                return Shape.Price + this.Select(x => x.Price).Sum();
            }
        }

        public IEnumerator<Components> GetEnumerator()
        {
            var sequence = (new Components[] { Base, Sauce }).Concat(Toppings);
            //IEnumerable<Components> sequence = Base.ConcatOne<Components>(Sauce).Concat(Toppings);
            return sequence.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public static IEnumerable<Pizza> AllPizzas(Shape shape)
        {
            return new[] { Hawaii(shape), Ham(shape) };
        }

        public static Pizza Hawaii(Shape shape)
        {
            return new Pizza("Pizza Hawaii", shape, Base.Crust, Sauce.Tomato, Topping.Ham);
        }
        public static Pizza Ham(Shape shape)
        {
            return new Pizza("Ham Pizza", shape, Base.Crust, Sauce.Cream, Topping.Ham);
        }
    }
}
