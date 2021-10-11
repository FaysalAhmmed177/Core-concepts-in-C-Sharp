using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            address.RoadNo = "102";
            address.HouseNo = "H-101";
            address.PostCode = "105";

            Person person1 = new Person();
            person1.PresentAddress = address;

            Address myAddress = person1.PresentAddress;
            string houseNo = myAddress.HouseNo;
        }
    }
}
