using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.View.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Presenter.EmployeeList
{
    internal class EmployeeListPresenter
    {
        private IObjectList<Employee> employeeList;
        private IEmployeeListView view;

        public EmployeeListPresenter(IObjectList<Employee> employeeList, IEmployeeListView view)
        {
            this.employeeList = employeeList;
            this.view = view;

            this.employeeList.ElementAdded += UpdateEmployeeList;
            this.employeeList.ElementUpdated += UpdateEmployeeList;
            this.employeeList.ElementRemoved += UpdateEmployeeList;

            this.view.LoadEmployeeList += (object? sender, EventArgs e) => UpdateEmployeeList(sender, null);
        }

        private void UpdateEmployeeList(object? sender, Employee? _)
        {
            var employeeListItems = this.employeeList.Elements.Select(employee => new ListItem(employee)).ToList();
            this.view.UpdateEmployeeList(employeeListItems);
        }
    }
}
