using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.ReservationPresenter;
using System;
using System.Collections.Generic;
using System.Text;

namespace dpiotrowski_lab2.View.ReservationView
{
    public interface ISingleReservationView
    {
        public event EventHandler LoadDepartmentList;
        public event EventHandler LoadEmployeeList;
        public event EventHandler<Guid> SelectDepartment;
        public event EventHandler<Guid> SelectRoom;

        public event EventHandler<ReservationData> AddReservation;
        public event EventHandler<ReservationData> EditReservation;
        public event EventHandler DeleteReservation;

        public void UpdateDepartmentList(List<ListItem> departments);
        public void UpdateDepartmentAddress(String address);
        public void UpdateEmployeeList(List<ListItem> employees);
        public void UpdateRoomList(List<ListItem> room);
        public void UpdateRoomDetails(String type, uint capacity);
        public void LoadReservationForEdition(ReservationData reservation);
        public void CloseView();
        public void DisplayError(String message);
    }
}
