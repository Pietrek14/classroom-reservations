using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Model.Reservations;
using dpiotrowski_lab2.Model.Rooms;
using dpiotrowski_lab2.Model.Rooms.Departments;
using dpiotrowski_lab2.View.Main;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.Presenter.RoomList
{
    internal class ReservationListPresenter
    {
        private IObjectList<Reservation> reservationList;
        private IObjectList<Room> roomList;
        private IObjectList<Department> departmentList;
        private IReservationListView view;

        private Guid? selectedDepartmentId;
        private DateOnly? selectedDate;

        public ReservationListPresenter(
            IObjectList<Reservation> reservationList,
            IObjectList<Room> roomList,
            IObjectList<Department> departmentList,
            IReservationListView view)
        {
            this.reservationList = reservationList;
            this.roomList = roomList;
            this.departmentList = departmentList;
            this.view = view;

            this.reservationList.ElementAdded += (object? sender, Reservation reservation) => UpdateReservationList();
            this.reservationList.ElementUpdated += (object? sender, Reservation reservation) => UpdateReservationList();
            this.reservationList.ElementRemoved += (object? sender, Reservation reservation) => UpdateReservationList();

            this.roomList.ElementAdded += (object? sender, Room room) => UpdateReservationList();
            this.roomList.ElementUpdated += (object? sender, Room room) => UpdateReservationList();
            this.roomList.ElementRemoved += (object? sender, Room room) => UpdateReservationList();

            // Although the department list should not change, it's better to
            // handle these events in case of future changes
            this.departmentList.ElementAdded += UpdateDepartmentList;
            this.departmentList.ElementUpdated += UpdateDepartmentList;
            this.departmentList.ElementRemoved += UpdateDepartmentList;

            this.view.LoadDepartmentList += (object? sender, EventArgs e) => UpdateDepartmentList(sender, null);
            this.view.SelectDepartment += (object? sender, Guid departmentId) => SetSelectedDepartment(departmentId);
            this.view.SelectDate += (object? sender, DateOnly date) => SetSelectedDate(date);
        }

        private void SetSelectedDepartment(Guid departmentId)
        {
            this.selectedDepartmentId = departmentId;

            UpdateReservationList();
        }

        private void SetSelectedDate(DateOnly date)
        {
            this.selectedDate = date;

            UpdateReservationList();
        }

        private void UpdateReservationList()
        {
            if(this.selectedDate == null || this.selectedDepartmentId == null)
            {
                return;
            }

            var reservations = this.reservationList.Elements.Where(reservation =>
                reservation.Room.Department.Id == this.selectedDepartmentId &&
                reservation.Date == this.selectedDate).ToList();

            var reservationListItemsByRoom = reservations
                .GroupBy(reservation => reservation.Room)
                .ToDictionary(
                    group => new ListItem(group.Key.Number.ToString(), group.Key.Id),
                    group => group.ToList().OrderBy(reservation => reservation.From).Select(
                            reservation => new ListItem(
                                $"{reservation.Reservee} ({reservation.From}-{reservation.To})", reservation.Id)
                        ).ToList());

            this.view.UpdateReservationList(reservationListItemsByRoom);
        }

        private void UpdateDepartmentList(object? sender, Department? _)
        {
            var departmentListItems = this.departmentList.Elements.Select(department => new ListItem(department.Name, department.Id)).ToList();
            this.view.UpdateDepartmentList(departmentListItems);
        }
    }
}
