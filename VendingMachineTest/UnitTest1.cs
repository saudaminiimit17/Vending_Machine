using Xunit;
using VendingMachine.Models;

namespace VendingMachineTest
{
    public class UnitTest1
    {
        #region Coin
        [Fact]
        public void CoinValidity()
        {
            double t = 0;double r = 0;
            bool result = CoinServices.AddCoin("0.05", ref t, ref r);
            Assert.True(result && t>0 && r == 0);
        }
        [Fact]
        public void CoinInvalid()
        {
            double t = 0; double r = 0;
            bool result = CoinServices.AddCoin("Coin", ref t, ref r);
            Assert.False(result || t > 0 || r > 0);
        }
        [Fact]
        public void CoinNoInput()
        {
            double t = 0; double r = 0;
            bool result = CoinServices.AddCoin(null, ref t, ref r);
            Assert.False(result || t > 0 || r > 0);
        }
        [Fact]
        public void CoinIsValid()
        {
            double t = 0; double r = 0;
            bool result = CoinServices.AddCoin("0.05", ref t, ref r);
            Assert.True(result && t == 0.05 && r == 0);
        }
        [Fact]
        public void CoinIsInValid()
        {
            double t = 0; double r = 0;
            bool result = CoinServices.AddCoin("0.01", ref t, ref r);
            Assert.True(!result && t == 0.00 && r == 0.01);
        }
        [Fact]
        public void CoinIsInMinus()
        {
            double t = 0; double r = 0;
            bool result = CoinServices.AddCoin("-0.05", ref t, ref r);
            Assert.False(result || t < 0 || r < 0);
        }
        #endregion

        #region Product
        [Fact]
        public void ProductValidity()
        {
            bool result = ProductServices.ProductPrice("cola", out double t);
            Assert.True(result && t > 0);
        }
        [Fact]
        public void ProductVALIDITY()
        {
            bool result = ProductServices.ProductPrice("COLA", out double t);
            Assert.True(result && t > 0);
        }
        [Fact]
        public void ProductInvalid()
        {
            bool result = ProductServices.ProductPrice("Col", out double t);
            Assert.False(result || t > 0);
        }
        [Fact]
        public void ProductWithNull()
        {
            bool result = ProductServices.ProductPrice(null, out double t);
            Assert.False(result || t > 0);
        }
        [Fact]
        public void ProductPrice()
        {
            bool result = ProductServices.ProductPrice("C", out double t);
            Assert.False(result || t > 0);
        }
        #endregion
    }
}