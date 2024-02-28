using System;
namespace OOP_sim_2
{
	public class Client
	{

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int ID { get; private set; }
        public Address Address { get; private set; }

        #region C'tor
        public Client(string firstName, string lastName, int iD, Address adress)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = iD;
            Address = adress;
        }
        #endregion

        #region Override Method
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

