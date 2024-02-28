using System;
namespace OOP_sim_2
{
    public class VIPMember : Client
    {
        public const int CostPerMonth = 200;
        public const double Discount = 10;
        public VIPMember(string firstName, string lastName, int iD, Address adress) : base(firstName, lastName, iD, adress) { }
        public double GetDiscount()
        {
            return Discount;
        }
    }
}

