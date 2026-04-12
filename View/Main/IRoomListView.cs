using dpiotrowski_lab2.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.View.Main
{
    internal interface IRoomListView
    {
        public event EventHandler LoadDepartmentList;
        public event EventHandler<Guid> SelectDepartment;

        public void UpdateDepartmentList(List<ListItem> items);
        public void UpdateDepartmentAddress(String address);
        public void UpdateRoomList(List<ListItem> items);
    }
}
