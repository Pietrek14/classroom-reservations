using dpiotrowski_lab2.Presenter.EmployeeList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.View.Main
{
    internal interface IEmployeeListView
    {
        public void UpdateEmployeeList(List<EmployeeListItem> items);
    }
}
