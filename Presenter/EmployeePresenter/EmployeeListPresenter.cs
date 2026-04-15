using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.View.EmployeeView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.Presenter.EmployeePresenter
{
    internal class EmployeeListPresenter
    {
        private IObjectList<Employee> employeeList;
        private IEmployeeListView view;
        private EmployeePresenter? employeePresenter;

        public EmployeeListPresenter(IObjectList<Employee> employeeList, IEmployeeListView view)
        {
            this.employeeList = employeeList;
            this.view = view;

            this.employeeList.ElementAdded += UpdateEmployeeList;
            this.employeeList.ElementUpdated += UpdateEmployeeList;
            this.employeeList.ElementRemoved += UpdateEmployeeList;

            this.view.LoadEmployeeList += (object? sender, EventArgs e) => UpdateEmployeeList(sender, null);
            this.view.AddEmployee += (object? sender, EventArgs e) => OpenSingleEmployeePresenter(null);
            this.view.SelectEmployeeToEdit += (object? sender, Guid employeeId) => OpenSingleEmployeePresenter(employeeId);
        }

        private void UpdateEmployeeList(object? sender, Employee? _)
        {
            var employeeListItems = this.employeeList.Elements.Select(employee => new ListItem(employee)).ToList();
            this.view.UpdateEmployeeList(employeeListItems);
        }

        private void OpenSingleEmployeePresenter(Guid? employeeId)
        {
            var employeeEditView = this.view.OpenSingleEmployeeView();
            this.employeePresenter = new EmployeePresenter(this.employeeList, employeeId, employeeEditView);
        }
    }
}
