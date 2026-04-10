using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Presenter.EmployeeList
{
    public class EmployeeListItem
    {
        public String Display { get; set; }
        public Guid Value { get; }

        public EmployeeListItem(String Display, Guid Value)
        {
            this.Display = Display;
            this.Value = Value;
        }

        public EmployeeListItem(Employee employee)
        {
            this.Display = employee.ToString();
            this.Value = employee.Id;
        }

        public override string ToString()
        {
            return this.Display;
        }
    }
}
