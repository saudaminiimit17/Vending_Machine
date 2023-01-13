namespace VendingMachine.Models
{
    //public class Product
    //{
    //    public string Name { get; set; }
    //    public double Price { get; set; }
    //}
    public static class ProductDetails
    {
        public static readonly Dictionary<string, double> products = new Dictionary<string, double>()
        {
            { "cola", 1.00 },
            { "chips", 0.50 },
            { "candy", 0.65 }
        };
    }
}
