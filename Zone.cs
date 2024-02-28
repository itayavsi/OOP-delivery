using System;
using System.Linq;

namespace OOP_sim_2
{
	public class Zone
	{
		public int Boxzone;
		public Parcel[] ParcelsInZone;

        public Zone(Country country)
        {
            Boxzone = (int)char.GetNumericValue(country.ToString()[0]);
            ParcelsInZone = new Parcel[1000];
            
        }
        public void AddParcel(Parcel parcel)
        {
            int i = 0;
            if (ParcelsInZone.Length == 1000)
            {
                Console.WriteLine("Zone is full");
            }
            else
            {
                while (ParcelsInZone[i] != null)
                    i++;
                ParcelsInZone[i] = parcel;

            }
        }

    }
}

