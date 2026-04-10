using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms.Addresses
{
    public class PostalCode
    {
        public uint First { get; set; }
        public uint Second { get; set; }

        public PostalCode(uint first, uint second)
        {
            this.First = first;
            this.Second = second;
        }

        public override string ToString()
        {
            return this.First.ToString() + " - " + this.Second.ToString();
        }
    }
}
