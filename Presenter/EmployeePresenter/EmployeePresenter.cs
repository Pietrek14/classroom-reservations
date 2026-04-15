using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.View.EmployeeView;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.EmployeePresenter
{
    internal class EmployeePresenter
    {
        private IObjectList<Employee> employeeList;
        private Guid? employeeId;
        private ISingleEmployeeView view;

        public EmployeePresenter(IObjectList<Employee> employeeList, Guid? employeeId, ISingleEmployeeView view) {
            this.employeeList = employeeList;
            this.employeeId = employeeId;
            this.view = view;

            if (employeeId != null)
            {
                var employee = this.employeeList.Get(employeeId.Value);

                this.view.LoadEmployeeForEdition(new EmployeeData(employee));
            }

            this.view.AddEmployee += (object? sender, EmployeeData employeeData) => addEmployee(employeeData);
            this.view.EditEmployee += (object? sender, EmployeeData employeeData) => editEmployee(employeeData);
            this.view.DeleteEmployee += (object? sender, EventArgs e) => deleteEmployee();
        }

        private void addEmployee(EmployeeData employeeData)
        {
            var validator = new EmployeeDataValidator();
            try
            {
                var employee = validator.GetEmployee(employeeData);
                this.employeeList.Add(employee);
                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }

        private void editEmployee(EmployeeData employeeData)
        {
            if (this.employeeId == null)
            {
                throw new InvalidOperationException("Cannot edit employee when emplouyee ID is null.");
            }

            var validator = new EmployeeDataValidator();
            try
            {
                var employee = validator.GetEmployeeWithId(this.employeeId.Value, employeeData);
                this.employeeList.Update(employee);
                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }

        private void deleteEmployee()
        {
            if (this.employeeId == null)
            {
                throw new InvalidOperationException("Cannot delete employee when emplouyee ID is null.");
            }

            this.employeeList.Remove(this.employeeId.Value);
            this.employeeId = null;
            this.view.CloseView();
        }
    }
}
