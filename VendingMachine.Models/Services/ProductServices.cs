namespace VendingMachine.Models
{
    public static class ProductServices
    {
        //public static List<Product> GetAllProducts()
        //{
        //    List<Product> products = new List<Product>();
        //    foreach(var kvp in ProductDetails.products)
        //    {
        //        Product product = new Product();
        //        product.Name = kvp.Key; product.Price = kvp.Value;
        //        products.Add(product);
        //    }
        //    return products;
        //}
        public static bool ProductPrice(string selectedName, out double price)
        {
            bool isProduct = ValidateProduct(selectedName);
            price = 0.00;
            if (isProduct)
            {
                price = ProductDetails.products.Where(x=>x.Key==selectedName.ToLower()).FirstOrDefault().Value;
            }
            return isProduct;
        }

        private static bool ValidateProduct(string selectedProduct)
        {
            if (string.IsNullOrEmpty(selectedProduct))
                return false;
            return ProductDetails.products.ContainsKey(selectedProduct.ToLower());
        }
    }
}
