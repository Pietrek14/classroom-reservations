using dpiotrowski_lab2.Model.Rooms.Addresses;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms
{
    internal class Department
    {
        public String Name { get; set; }
        public Address Address { get; set; }

        public Department(String name, Address address)
        {
            this.Name = name;
            this.Address = address;
        }
    }
}