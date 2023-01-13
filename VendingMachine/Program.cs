using VendingMachine.Models;
public class Program
{
    public static void Main()
    {
        bool shouldContinue = false;
        do
        {
            Console.Clear();
            string selection = DisplayAllProducts();
            if (ProductServices.ProductPrice(selection, out double price)) //if valid product
            {
                double total = 0.00f; double returnAmt = 0.00f;
                string coinInput = InsertCoin();
                shouldContinue = false;
                bool isDispensed = false;
                while (!isDispensed)
                {
                    if (CoinServices.AddCoin(coinInput, ref total, ref returnAmt))
                    {
                        Console.WriteLine("PRICE: $" + price + " ,COIN INSERTED: $" + total);
                        
                        if (price > total)
                        {
                            coinInput = InsertCoin();
                            isDispensed = false;
                        }
                        else
                        {
                            Console.WriteLine("THANK YOU");
                            isDispensed = true;

                        }
                    }
                    else
                    {
                        if (returnAmt > 0)
                        {
                            Console.WriteLine("COIN RETURNED: $" + returnAmt);
                            returnAmt = 0.00f;
                        }
                        coinInput = InsertCoin();
                        isDispensed = false;
                    }
                    if (isDispensed)
                    {
                        Console.WriteLine("INSERT COIN");
                        total = 0.00f;
                    }
                        
                }
            }  
            else
               shouldContinue = true;
        }
        while (shouldContinue);
    }
    private static string DisplayAllProducts()
    {
        foreach(var p in ProductDetails.products)
        {
            Console.WriteLine(p.Key +" : $"+p.Value);
        }
        Console.WriteLine("Select a product..");
        return Console.ReadLine();
    }
    private static string InsertCoin()
    {
        Console.WriteLine("INSERT COIN");
        return Console.ReadLine();
    }
}