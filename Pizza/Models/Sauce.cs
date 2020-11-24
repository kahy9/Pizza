namespace Pizza
{
    class Sauce : Components
    {
        public Sauce(string description, decimal price) : base(description, price)
        {
        }

        public static Sauce Tomato = new Sauce("Tomato", 50);
        public static Sauce Cream = new Sauce("Cream", 60);
    }
}
