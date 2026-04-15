using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Rooms;
using dpiotrowski_lab2.Model.Rooms.Departments;
using dpiotrowski_lab2.View.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace dpiotrowski_lab2.Presenter.RoomPresenter
{
    internal class RoomListPresenter
    {
        private IObjectList<Room> roomList;
        private IObjectList<Department> departmentList;
        private IRoomListView view;
        private RoomPresenter? roomPresenter = null;

        private Guid selectedDepartmentId;

        public RoomListPresenter(IObjectList<Room> roomList, IObjectList<Department> departmentList, IRoomListView view)
        {
            this.roomList = roomList;
            this.departmentList = departmentList;
            this.view = view;

            this.roomList.ElementAdded += UpdateRoomList;
            this.roomList.ElementUpdated += UpdateRoomList;
            this.roomList.ElementRemoved += UpdateRoomList;

            // Although the department list should not change, it's better to
            // handle these events in case of future changes
            this.departmentList.ElementAdded += UpdateDepartmentList;
            this.departmentList.ElementUpdated += UpdateDepartmentList;
            this.departmentList.ElementRemoved += UpdateDepartmentList;

            this.view.LoadDepartmentList += (object? sender, EventArgs e) => UpdateDepartmentList(sender, null);
            this.view.SelectDepartment += (object? sender, Guid departmentId) => SetSelectedDepartment(departmentId);
            this.view.SelectRoomToEdit += (object? sender, Guid roomId) => OpenRoomEdit(roomId);
            this.view.AddRoom += (object? sender, EventArgs e) => OpenRoomEdit(null);
        }

        private void SetSelectedDepartment(Guid departmentId)
        {
            this.selectedDepartmentId = departmentId;

            var department = this.departmentList.Elements.FirstOrDefault(department => department.Id == departmentId);
            if (department == null)
            {
                throw new ArgumentException($"Department with id {departmentId} does not exist.");
            }
            
            this.UpdateRoomList(null, null);
            this.view.UpdateDepartmentAddress(department.Address.ToString());
        }

        private void UpdateRoomList(object? sender, Room? _)
        {
            var roomsInDepartment = this.roomList.Elements
                .Where(room => room.Department.Id == this.selectedDepartmentId)
                .OrderBy(room => room.Number)
                .ToList();

            var roomListItems = roomsInDepartment.Select(room => new ListItem(room)).ToList();
            this.view.UpdateRoomList(roomListItems);
        }

        private void UpdateDepartmentList(object? sender, Department? _)
        {
            var departmentListItems = this.departmentList.Elements.Select(department => new ListItem(department.Name, department.Id)).ToList();
            this.view.UpdateDepartmentList(departmentListItems);
        }

        private void OpenRoomEdit(Guid? roomId)
        {
            var roomEditView = this.view.OpenRoomEditView();
            this.roomPresenter = new RoomPresenter(this.roomList, roomId, this.departmentList, roomEditView);
        }
    }
}
