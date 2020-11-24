namespace Pizza
{
    class Components : IHasPrice
    {

        public Components(string description, decimal price)
        {
            Description = description;
            Price = price;
        }


        public decimal Price { get; }
        public string Description { get; }
    }
}
