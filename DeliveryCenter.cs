using System;
using System.Diagnostics.Metrics;

namespace OOP_sim_2
{
	public class DeliveryCenter
	{
		public Zone[] AllZones;

        public DeliveryCenter(Zone[] allZones)
        {
            AllZones = new Zone[26];
        }
        public void AddParcel(Parcel parcel)
        {
            int RightZone = (int)char.GetNumericValue(parcel.DeliverAddress.Country.ToString()[0]);
            AllZones[RightZone].AddParcel(parcel);
        }

        public override string ToString()
        {
            string ParcelsInZone = "";
                for (int i = 0; i < AllZones.Length; i++)
                {
                    ParcelsInZone += $"Parcels amount in Zone{AllZones[i]} Is:{AllZones[i].ParcelsInZone.Length} And the total price is:{GetParcelsInZonePrice(i)}";
                }
            return ParcelsInZone;

        }
        public double GetParcelsInZonePrice(int x)
        {
            double sum = 0;
            for (int i = 0; i < AllZones[x].ParcelsInZone.Length; i++)
            {
                sum += AllZones[x].ParcelsInZone[i].TotalPrice;
            }
            return sum;
        }

    }
}

