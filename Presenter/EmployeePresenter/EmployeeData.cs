using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.EmployeePresenter
{
    public class EmployeeData
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TitlePrefix { get; set; }
        public string TitleSuffix { get; set; }

        public EmployeeData(Employee employee)
        {
            this.FirstName = employee.FirstName;
            this.LastName = employee.LastName;
            this.TitlePrefix = employee.Title.Prefix;
            this.TitleSuffix = employee.Title.Suffix;
        }

        public EmployeeData(string firstName, string lastName, string titlePrefix, string titleSuffix)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.TitlePrefix = titlePrefix;
            this.TitleSuffix = titleSuffix;
        }
    }
}
