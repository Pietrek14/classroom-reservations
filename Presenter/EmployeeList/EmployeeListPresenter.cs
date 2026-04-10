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
    internal class EmployeeListPresenter : IEmployeeListPresenter
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
            this.view = view;

            this.UpdateEmployeeList(null, null);
        }

        private void UpdateEmployeeList(object? sender, Employee? _)
        {
            employeeList.Elements.Select(employee => new EmployeeListItem(employee)).ToList();
        }
    }
}
