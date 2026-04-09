using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms.Addresses
{
    internal class Address
    {
        public string City { get; set; }
        public PostalCode PostalCode { get; set; }
        public string Street { get; set; }
        public string BuildingNumber { get; set; }

        public Address(string city, PostalCode postalCode, string street, string buildingNumber)
        {
            this.City = city;
            this.PostalCode = postalCode;
            this.Street = street;
            this.BuildingNumber = buildingNumber;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}, ul. {2} {3}", this.PostalCode.ToString(), this.City, this.Street, this.BuildingNumber);
        }
    }
}
