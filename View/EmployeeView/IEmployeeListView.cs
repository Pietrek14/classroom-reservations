using dpiotrowski_lab2.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.View.EmployeeView
{
    internal interface IEmployeeListView
    {
        public event EventHandler LoadEmployeeList;
        public event EventHandler<Guid> SelectEmployeeToEdit;
        public event EventHandler AddEmployee;

        public void UpdateEmployeeList(List<ListItem> items);
        public ISingleEmployeeView OpenSingleEmployeeView();
    }
}
