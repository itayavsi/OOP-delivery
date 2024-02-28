using System;
namespace OOP_sim_2
{
    public class Member : Client
    {
        public double TotalMoneyPaid { get; set; }

        #region C'tor
        public Member(string firstName, string lastName, int iD, Address address) : base(firstName, lastName, iD, address)
        {
            TotalMoneyPaid = 0;
        }
        public Member(Client client) : base(client.FirstName, client.LastName, client.ID, client.Address)
        {
            this.TotalMoneyPaid = 0;
        }
        #endregion

        public double GetDiscount()
        {
            if (TotalMoneyPaid > 1000 && TotalMoneyPaid < 5000)
                return 0.025;
            if (TotalMoneyPaid > 5000 && TotalMoneyPaid < 20000)
                return 0.05;
            if (TotalMoneyPaid > 20000)
                return 0.08;
            else return 1;
        }

        #region Overrides method
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

