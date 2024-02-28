using System;
namespace OOP_sim_2
{
	public class Product
	{
		public string ProductName { get; private set; }
		public int ProductPrice { get; private set; }

        #region C'tor
        public Product(string productName, int productPrice)
        {
            ProductName = productName;
            ProductPrice = productPrice;
        }
        #endregion
        #region Overrides Method
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}

