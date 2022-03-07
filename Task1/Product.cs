namespace Task1
{
    public class Product
    {
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public double Price { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Product)
            {
                var convertedIncomeParam = obj as Product;
                return convertedIncomeParam.Name == Name && convertedIncomeParam.Price == Price;
            }

            return base.Equals(obj);
        }
    }
}
