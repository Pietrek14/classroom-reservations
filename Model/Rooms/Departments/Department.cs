using dpiotrowski_lab2.Model.Rooms.Addresses;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms.Departments
{
    public class Department : IGuided
    {
        public Guid Id { get; }
        public String Name { get; }
        public Address Address { get; }

        public Department(String name, Address address)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Address = address;
        }
    }
}