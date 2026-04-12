using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Presenter
{
    public class ListItem
    {
        public String Display { get; set; }
        public Guid Value { get; }

        public ListItem(String Display, Guid Value)
        {
            this.Display = Display;
            this.Value = Value;
        }

        public ListItem(IGuided item)
        {
            this.Display = item.ToString() ?? throw new ArgumentException("A list item must be ToString-able!");
            this.Value = item.Id;
        }

        public override string ToString()
        {
            return this.Display;
        }
    }
}
