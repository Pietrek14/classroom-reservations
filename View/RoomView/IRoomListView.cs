using dpiotrowski_lab2.Presenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dpiotrowski_lab2.View.RoomView
{
    internal interface IRoomListView
    {
        public event EventHandler LoadDepartmentList;
        public event EventHandler<Guid> SelectDepartment;
        public event EventHandler<Guid> SelectRoomToEdit;
        public event EventHandler AddRoom;

        public void UpdateDepartmentList(List<ListItem> items);
        public void UpdateDepartmentAddress(String address);
        public void UpdateRoomList(List<ListItem> items);
        public ISingleRoomView OpenSingleRoomView();
    }
}
