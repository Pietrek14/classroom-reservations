using dpiotrowski_lab2.Model.Employees;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.EmployeePresenter
{
    internal class EmployeeDataValidator
    {
        public Employee GetEmployee(EmployeeData employeeData)
        {
            return this.GetEmployeeWithId(Guid.NewGuid(), employeeData);
        }

        public Employee GetEmployeeWithId(Guid id, EmployeeData employeeData)
        {
            if (employeeData.FirstName.Length == 0)
            {
                throw new ArgumentException("Imię nie może być puste.");
            }
            if (employeeData.LastName.Length == 0)
            {
                throw new ArgumentException("Nazwisko nie może być puste.");
            }
            var title = new Title(employeeData.TitlePrefix, employeeData.TitleSuffix);
            return new Employee(id, employeeData.FirstName, employeeData.LastName, title);
        }
    }
}
