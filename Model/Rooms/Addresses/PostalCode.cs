using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Rooms.Addresses
{
    public class PostalCode
    {
        public string First { get; set; }
        public string Second { get; set; }

        public PostalCode(string first, string second)
        {
            this.First = first;
            this.Second = second;
        }

        public override string ToString()
        {
            return this.First + "-" + this.Second;
        }
    }
}
