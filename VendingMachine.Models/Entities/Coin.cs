namespace VendingMachine.Models
{
    //public class Coin
    //{
    //    public string Name { get; set; }
    //    public double Value { get; set; }
    //}
    public static class CoinDetails
    {
        public static readonly Dictionary<string,string> validCoins = new Dictionary<string,string>()
        {
            { "nickels", "0.05" },
            { "dimes", "0.10" },
            { "quarters", "0.25" }
        };
    
        public static readonly Dictionary<string, string> invalidCoins = new Dictionary<string, string>()
        {
            { "pennies", "0.01" }
        };
    }
}
