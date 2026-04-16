using dpiotrowski_lab2.Model.Rooms;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace dpiotrowski_lab2.Model.Employees
{
    public class EmployeeList : IObjectList<Employee>
    {
        private Dictionary<Guid, Employee> employees;
        public List<Employee> Elements { get => employees.Values.ToList(); }
        public event EventHandler<Employee>? ElementAdded;
        public event EventHandler<Employee>? ElementRemoved;
        public event EventHandler<Employee>? ElementUpdated;

        public EmployeeList()
        {
            this.employees = new Dictionary<Guid, Employee>();
        }

        public Employee Get(Guid elementId)
        {
            return this.employees[elementId];
        }

        public void Add(Employee employee)
        {
            this.employees.Add(employee.Id, employee);

            this.ElementAdded?.Invoke(this, employee);
        }

        public void Remove(Guid employeeId)
        {
            var removed = this.employees[employeeId];

            this.employees.Remove(employeeId);

            this.ElementRemoved?.Invoke(this, removed);
        }

        public void Update(Employee employee)
        {
            if (!employees.ContainsKey(employee.Id))
            {
                throw new ArgumentException($"Employee with id {employee.Id} does not exist.");
            }

            this.employees[employee.Id] = employee;

            this.ElementUpdated?.Invoke(this, employee);
        }
    }
}
