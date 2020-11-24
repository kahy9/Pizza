namespace Pizza
{
    class Topping : Components
    {
        public Topping(string description, decimal price) : base(description, price)
        {

        }

        public static Topping Pineapple = new Topping("Pizza with Pineapple <3", 10);
        public static Topping Ham = new Topping("Pizza with Ham", 20);
        public static Topping Cheese = new Topping("Pizza with cheese", 10);
    }
}
