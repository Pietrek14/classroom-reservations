using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Employees;
using dpiotrowski_lab2.Model.Reservations;
using dpiotrowski_lab2.Model.Rooms;
using dpiotrowski_lab2.Model.Rooms.Departments;
using dpiotrowski_lab2.View.ReservationView;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace dpiotrowski_lab2.Presenter.ReservationPresenter
{
    internal class ReservationPresenter
    {
        private IObjectList<Department> departmentList;
        private IObjectList<Room> roomList;
        private IObjectList<Employee> employeeList;
        private IObjectList<Reservation> reservationList;
        private ISingleReservationView view;

        private Guid? reservationId;
        private Guid? selectedDepartmentId;

        public ReservationPresenter(
            IObjectList<Reservation> reservationList,
            Guid? reservationId,
            IObjectList<Department> departmentList,
            IObjectList<Room> roomList,
            IObjectList<Employee> employeeList,
            ISingleReservationView view)
        {
            this.departmentList = departmentList;
            this.roomList = roomList;
            this.employeeList = employeeList;
            this.reservationList = reservationList;
            this.view = view;
            this.reservationId = reservationId;

            this.view.SelectDepartment += (object? sender, Guid departmentId) => {
                this.selectedDepartmentId = departmentId;

                loadRoomList();
                updateDepartmentAddress();
            };
            this.view.SelectRoom += (object? sender, Guid roomId) => updateRoomDetails(roomId);

            loadDepartmentList();
            loadEmployeeList();

            if (reservationId != null)
            {
                Reservation reservation = reservationList.Get(reservationId.Value);

                this.view.LoadReservationForEdition(this.getReservationData(reservation));
            }

            this.departmentList.ElementAdded += (object? sender, Department _) => loadDepartmentList();
            this.departmentList.ElementUpdated += (object? sender, Department _) => loadDepartmentList();
            this.departmentList.ElementRemoved += (object? sender, Department _) => loadDepartmentList();

            this.roomList.ElementAdded += (object? sender, Room _) => loadRoomList();
            this.roomList.ElementUpdated += (object? sender, Room _) => loadRoomList();
            this.roomList.ElementRemoved += (object? sender, Room _) => loadRoomList();

            this.employeeList.ElementAdded += (object? sender, Employee _) => loadEmployeeList();
            this.employeeList.ElementUpdated += (object? sender, Employee _) => loadEmployeeList();
            this.employeeList.ElementRemoved += (object? sender, Employee _) => loadEmployeeList();

            this.view.AddReservation += (object? sender, ReservationData reservationData) => addReservation(reservationData);
            this.view.EditReservation += (object? sender, ReservationData reservationData) => editReservation(reservationData);
            this.view.DeleteReservation += (object? sender, EventArgs e) => deleteReservation();
        }

        private ReservationData getReservationData(Reservation reservation)
        {
            var department = departmentList.Get(reservation.Room.Department.Id);
            var room = roomList.Get(reservation.Room.Id);
            var reservee = employeeList.Get(reservation.Reservee.Id);

            return new ReservationData(
                new ListItem(department),
                new ListItem(room),
                new ListItem(reservee),
                reservation.From,
                reservation.To,
                reservation.Date);
        }

        private void loadDepartmentList()
        {
            var departmentListItems = this.departmentList.Elements
                .Select(department => new ListItem(department))
                .ToList();
            this.view.UpdateDepartmentList(departmentListItems);
        }

        private void loadRoomList()
        {
            if (this.selectedDepartmentId == null)
            {
                this.view.UpdateRoomList(new List<ListItem>());
                return;
            }

            var roomListItems = this.roomList.Elements
                .Where(room => room.Department.Id == this.selectedDepartmentId)
                .OrderBy(room => room.Number)
                .Select(room => new ListItem(room))
                .ToList();
            this.view.UpdateRoomList(roomListItems);
        }

        private void loadEmployeeList()
        {
            var employeeListItems = this.employeeList.Elements
                .Select(employee => new ListItem(employee))
                .ToList();
            this.view.UpdateEmployeeList(employeeListItems);
        }

        private void updateDepartmentAddress()
        {
            if(this.selectedDepartmentId == null)
            {
                this.view.UpdateDepartmentAddress(string.Empty);
                return;
            }

            var department = this.departmentList.Get(this.selectedDepartmentId.Value);

            if (department == null)
            {
                throw new ArgumentException($"Department with id {this.selectedDepartmentId} not found.");
            }

            this.view.UpdateDepartmentAddress(department.Address.ToString());
        }

        private void updateRoomDetails(Guid roomId)
        {
            var room = this.roomList.Get(roomId);

            if (room == null)
            {
                throw new ArgumentException($"Room with id {roomId} not found.");
            }

            string roomType;

            switch(room.RoomType)
            {
                case RoomType.Lecture:
                    roomType = "wykładowa";
                    break;
                case RoomType.Computer:
                    roomType = "komputerowa";
                    break;
                case RoomType.Seminar:
                    roomType = "ćwiczeniowa";
                    break;
                default:
                    throw new ArgumentException($"Unknown room type {room.RoomType}.");
            }

            this.view.UpdateRoomDetails(roomType, room.Capacity);
        }

        private void addReservation(ReservationData reservationData)
        {
            var validator = new ReservationDataValidator();

            try
            {

                var reservation = validator.GetReservation(
                    reservationData,
                    this.reservationList,
                    this.roomList,
                    this.employeeList);

                this.reservationList.Add(reservation);

                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }

        private void editReservation(ReservationData reservationData)
        {
            if(this.reservationId == null)
            {
                throw new ArgumentException($"Can't edit a reservation when reservation id is null.");
            }

            var validator = new ReservationDataValidator();

            try
            {
                var reservation = validator.GetReservationWithId(
                    this.reservationId.Value,
                    reservationData,
                    this.reservationList,
                    this.roomList,
                    this.employeeList
                );

                this.reservationList.Update(reservation);

                this.view.CloseView();
            }
            catch (ArgumentException ex)
            {
                this.view.DisplayError(ex.Message);
            }
        }

        private void deleteReservation()
        {
            if (this.reservationId == null)
            {
                throw new ArgumentException($"Can't delete a reservation when reservation id is null.");
            }

            this.reservationList.Remove(this.reservationId.Value);

            this.view.CloseView();
        }
    }
}
