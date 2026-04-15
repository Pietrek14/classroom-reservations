using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Rooms;
using dpiotrowski_lab2.Model.Rooms.Departments;
using dpiotrowski_lab2.View.RoomView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace dpiotrowski_lab2.Presenter.RoomPresenter
{
    internal class RoomPresenter
    {
        private IObjectList<Room> roomList;
        private Guid? roomId;
        private IObjectList<Department> departmentList;
        private ISingleRoomView view;

        public RoomPresenter(IObjectList<Room> roomList, Guid? roomId, IObjectList<Department> departmentList, ISingleRoomView view)
        {
            this.roomList = roomList;
            this.roomId = roomId;
            this.departmentList = departmentList;
            this.view = view;

            if (roomId != null)
            {
                Room room = roomList.Get(roomId.Value);

                this.view.LoadRoomForEdition(new RoomData(room));
            }

            this.view.LoadDepartmentList += (object? sender, EventArgs e) => updateDepartmentList(null, null);
            this.view.SelectDepartment += (object? sender, Guid departmentId) => setSelectedDepartment(departmentId);
            this.view.AddRoom += (object? sender, RoomData roomData) => addRoom(roomData);
            this.view.EditRoom += (object? sender, RoomData roomData) => editRoom(roomData);
            this.view.DeleteRoom += (object? sender, EventArgs e) => deleteRoom();

            this.departmentList.ElementAdded += updateDepartmentList;
            this.departmentList.ElementUpdated += updateDepartmentList;
            this.departmentList.ElementRemoved += updateDepartmentList;

            this.updateDepartmentList(null, null);
        }

        private void updateDepartmentList(object? sender, Department? _)
        {
            var departmentListItems = this.departmentList.Elements.Select(department => new ListItem(department.Name, department.Id)).ToList();
            this.view.UpdateDepartmentList(departmentListItems);
        }

        private void setSelectedDepartment(Guid departmentId)
        {
            var department = this.departmentList.Elements.FirstOrDefault(department => department.Id == departmentId);
            if (department == null)
            {
                throw new ArgumentException($"Department with id {departmentId} does not exist.");
            }

            this.view.UpdateDepartmentAddress(department.Address.ToString());
        }

        private void addRoom(RoomData roomData)
        {
            var department = this.departmentList.Get(roomData.DepartmentId);
            var validator = new RoomDataValidator();
            try
            {
                var room = validator.GetRoom(roomData, department);
                this.roomList.Add(room);
                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }

        private void editRoom(RoomData roomData)
        {
            if (this.roomId == null)
            {
                throw new InvalidOperationException("Cannot edit room when room id is null");
            }

            var department = this.departmentList.Get(roomData.DepartmentId);
            var validator = new RoomDataValidator();
            try
            {
                var room = validator.GetRoomWithId(this.roomId.Value, roomData, department);
                this.roomList.Update(room);
                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }

        private void deleteRoom()
        {
            if (this.roomId == null)
            {
                throw new InvalidOperationException("Cannot delete room when room id is null");
            }

            try
            {
                this.roomList.Remove(this.roomId.Value);
                this.roomId = null;
                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }
    }
}
