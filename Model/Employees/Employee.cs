using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Employees
{
 
    internal class Employee
    {
        public Guid Id { get; }
        public String FirstName { get; }
        public String LastName { get; }
        public Title Title { get; }

        public Employee(String firstName, String lastName, Title title)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
        }
    }
}
