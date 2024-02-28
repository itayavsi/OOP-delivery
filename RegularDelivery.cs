using System;
namespace OOP_sim_2
{
    public class RegularDelivery : Delivery
    {
        public const int DeliveryFromChinaPrice = 2;
        public const int DeliveryNotFromChinaPrice = 5;
        public const int DeliveryFromChinaTime = 5;
        public const int DeliveryNotFromChinaTime = 10;
        public RegularDelivery(Parcel parcel) : base(parcel)
        {
        }

        public override int EstimatedArrivalTime()
        {
            if (Parcel.DeliverAddress.Country == Country.China)
            {
                return DeliveryFromChinaTime;
            }
            return DeliveryNotFromChinaTime; 
        }

        public override double GetPrice()
        {
            if (Parcel.DeliverAddress.Country == Country.China)
            {
                return DeliveryFromChinaPrice;
            }
            return DeliveryNotFromChinaPrice;
        }
    }
}

