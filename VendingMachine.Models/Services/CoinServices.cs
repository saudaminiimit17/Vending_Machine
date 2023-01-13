namespace VendingMachine.Models
{
    public static class CoinServices
    {
        private static bool ValidCoin(string insertedCoin)
        {
            return CoinDetails.validCoins.ContainsValue(insertedCoin); 
        }
        private static bool InvalidCoin(string insertedCoin)
        {
            return CoinDetails.invalidCoins.ContainsValue(insertedCoin);
        }
        public static bool AddCoin(string insertedCoin, ref double total,ref double returnAmt)
        {
            bool isCoin = false;
            if (double.TryParse(insertedCoin, out double coin))
            {
                if (ValidCoin(insertedCoin))
                {
                    total = total + coin;
                    isCoin = true;
                }
                if (InvalidCoin(insertedCoin))
                    returnAmt = returnAmt + coin;
                
            }
            return isCoin;
        }
    }
}
