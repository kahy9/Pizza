namespace Pizza
{
    class Shape : IHasPrice
    {
        private Shape(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public decimal Price { get; }
        public string Description { get; }

        public static Shape Hexagon = new Shape("Hexagon shape", 30);
        public static Shape Circle = new Shape("Circle - 30cm", 60);
        public static readonly Shape[] AllShape = new[] { Circle, Hexagon };
    }
}
