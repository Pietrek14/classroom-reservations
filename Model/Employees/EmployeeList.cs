using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Model.Employees
{
    internal class EmployeeList
    {
        private Dictionary<Guid, Employee> employees;
        public List<Employee> Employees { get => employees.Values.ToList(); }
        public event EventHandler<Employee>? EmployeeAdded;
        public event EventHandler<Employee>? EmployeeRemoved;
        public event EventHandler<Employee>? EmployeeUpdated;

        public EmployeeList()
        {
            this.employees = new Dictionary<Guid, Employee>();
        }

        public void Add(Employee employee)
        {
            this.employees.Add(employee.Id, employee);

            this.EmployeeAdded?.Invoke(this, employee);
        }

        public void Remove(Employee employee)
        {
            this.employees.Remove(employee.Id);

            this.EmployeeRemoved?.Invoke(this, employee);
        }

        public void Update(Employee employee)
        {
            if (!employees.ContainsKey(employee.Id))
            {
                throw new ArgumentException($"Employee with id {employee.Id} does not exist.");
            }

            this.employees[employee.Id] = employee;

            this.EmployeeUpdated?.Invoke(this, employee);
        }
    }
}
