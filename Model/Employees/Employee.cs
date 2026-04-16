using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Text.Json.Serialization;

namespace dpiotrowski_lab2.Model.Employees
{
 
    public class Employee : IGuided
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

        [JsonConstructor]
        public Employee(Guid id, String firstName, String lastName, Title title)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Title = title;
        }

        public override string ToString()
        {
            return (this.Title.Prefix.Length > 0 ? $"{this.Title.Prefix} " : "")
                + $"{this.FirstName} {this.LastName}"
                + (this.Title.Suffix.Length > 0 ? $", {this.Title.Suffix}" : "");
        }
    }
}
