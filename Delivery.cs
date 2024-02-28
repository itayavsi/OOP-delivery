using System;
namespace OOP_sim_2
{
	public abstract class Delivery
	{
		public Parcel Parcel;
		public string ReleaseDate = "";
		public int Mode = 1;

        protected Delivery(Parcel parcel)
        {
            Parcel = parcel;
        }

        public int StatusMode()
		{
			return Mode;
		}
		public void Send()
		{

			ReleaseDate = DateTime.Now.ToString();
			Mode++;
		}
		public abstract double GetPrice();
		public abstract int EstimatedArrivalTime();
    }
}

