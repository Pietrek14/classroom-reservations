using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.EmployeePresenter;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.View.EmployeeView
{
    public interface ISingleEmployeeView
    {
        public event EventHandler<EmployeeData> AddEmployee;
        public event EventHandler<EmployeeData> EditEmployee;
        public event EventHandler DeleteEmployee;

        public void LoadEmployeeForEdition(EmployeeData employee);
        public void CloseView();
        public void DisplayError(string message);
    }
}
