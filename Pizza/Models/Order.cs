using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizza.Models
{
    class Order
    {
        public Order()
        {
            Console.WriteLine("Welcome, to our console Pizza");
            //todo:

            Console.WriteLine("We have these Pizzas");
            var allPizzas = Pizza.AllPizzas(Shape.Circle).ToArray();
            allPizzas.ForEach((x, index) => Console.WriteLine($"[{index + 1}] - {x.Name}"));

            var key = Console.ReadKey().KeyChar;
            var choice = ((byte)key) - 48 - 1;
            var pizza = allPizzas[choice];
            Console.Clear();
            Console.WriteLine($"SHOPPING CART: [{choice + 1}] - {pizza.Name}");


            Console.WriteLine("Which shape?");
            var allShape = Shape.AllShape;
            allShape.ForEach((x, index) => Console.WriteLine($"[{index + 1}] - {x.Description} = {x.Price},- Kč"));

            key = Console.ReadKey().KeyChar;
            choice = ((byte)key) - 48 - 1;
            pizza = allPizzas[choice];

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("------------------------------");
            Console.WriteLine($"ORDER: {pizza.Name} = {pizza.Price},- Kč");
            Console.WriteLine("------------------------------");
        }
    }
}
