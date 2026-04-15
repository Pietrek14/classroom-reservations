using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.RoomPresenter;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.View.RoomView
{
    public interface ISingleRoomView
    {
        public event EventHandler LoadDepartmentList;
        public event EventHandler<Guid> SelectDepartment;
        public event EventHandler<RoomData> AddRoom;
        public event EventHandler<RoomData> EditRoom;
        public event EventHandler DeleteRoom;

        public void UpdateDepartmentList(List<ListItem> items);
        public void UpdateDepartmentAddress(String address);
        public void LoadRoomForEdition(RoomData room);
        public void CloseView();
        public void DisplayError(string message);
    }
}
