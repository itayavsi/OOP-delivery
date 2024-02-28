using System;
namespace OOP_sim_2
{
    public class Parcel
    {
        public Product Product { get; private set; }
        public double VolumeInSgt { get; private set; }
        public Client Client { get; private set; }
        public Address DeliverAddress { get; private set; }
        public Address ClientAddress { get; private set; }
        public double TotalPrice { get; private set; }
        private double BoxSize;
        private int BoxZone;
        static int TotalParcels = 0;
        private int UniqID;
        

        #region C'tor
        public Parcel(Product product, Double volumeInSgt, Client client, Address deliverAdress, Address clientAdress)
        {
            Product = product;
            VolumeInSgt = volumeInSgt;
            Client = client;
            DeliverAddress = deliverAdress;
            ClientAddress = clientAdress;
            TotalPrice = GetPrice();
            BoxSize = ChooseBox();
            BoxZone = ChooseZone();
            TotalPrice++;
            UniqID = UniqID.GetHashCode();
            UpdateMemberPrice();
        }
        #endregion

        #region level-3/5

        private double ChooseBox()
        {
            if (VolumeInSgt < 25)
                return 25;
            if (VolumeInSgt < 50)
                return 50;
            if (VolumeInSgt > 100)
                return 100;
            else
                return VolumeInSgt;
            
        }
        public int ChooseZone()
        {
            return (int)char.GetNumericValue(Client.Address.Country.ToString()[0]);
        }
        private double GetPrice()
        {
            double price = 0;
            if (BoxSize == 25)
                price = Product.ProductPrice + 2.5;      
            if (BoxSize == 50)
                price = Product.ProductPrice + 5;
            if (BoxSize == 100)
                price = Product.ProductPrice + 10;
            else
                price = Product.ProductPrice + 5;
            double discountPrice = price;
            if (Client is Member)
            {
                discountPrice *= ((Member)this.Client).GetDiscount();
                return price - discountPrice;
            }
            if (Client is VIPMember)
            {
                discountPrice *= ((VIPMember)this.Client).GetDiscount();
                return price - discountPrice;
            }
            return price;
            
        }

        #endregion
        #region level -5
        private void UpdateMemberPrice()
        {
            if (Client is Member)
                ((Member)this.Client).TotalMoneyPaid += TotalPrice;

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
            return $"Product Name:{Product.ProductName}, Deliver Adress:{DeliverAddress}, Client Adrees{ClientAddress},Total Price:{TotalPrice}";
        }
        #endregion
    }
}

