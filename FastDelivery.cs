using System;
namespace OOP_sim_2
{
	public class FastDelivery : Delivery
	{
        public FastDelivery(Parcel parcel) : base(parcel)
        {
        }

        public override int EstimatedArrivalTime()
        {
            return 1;
        }

        public override double GetPrice()
        {
            return Parcel.TotalPrice / 10;
        }
    }
}

