namespace Pizza
{
    class Base : Components
    {
        public Base(string description, decimal price) : base(description, price)
        {

        }

        public static Base Crust = new Base("Crust", 50);
        public static Base Flat = new Base("Flat", 60);

    }
}
