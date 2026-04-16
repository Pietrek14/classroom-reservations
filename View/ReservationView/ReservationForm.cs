using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.ReservationPresenter;
using dpiotrowski_lab2.Service;
using dpiotrowski_lab2.View.ReservationView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dpiotrowski_lab2
{
    public partial class ReservationForm : Form, ISingleReservationView
    {
        public event EventHandler? LoadDepartmentList;
        public event EventHandler? LoadEmployeeList;
        public event EventHandler<Guid>? SelectDepartment;
        public event EventHandler<Guid>? SelectRoom;
        public event EventHandler<ReservationData>? AddReservation;
        public event EventHandler<ReservationData>? EditReservation;
        public event EventHandler? DeleteReservation;

        public ReservationForm()
        {
            InitializeComponent();
        }

        public void UpdateDepartmentList(List<ListItem> departments)
        {
            this.cmbDepartment.Items.Clear();
            foreach (ListItem item in departments)
            {
                this.cmbDepartment.Items.Add(item);
            }
            this.cmbDepartment.SelectedIndex = 0;
            this.SelectDepartment?.Invoke(this, departments[0].Value);
        }

        public void UpdateDepartmentAddress(String address)
        {
            this.lblDepartmentAddress.Text = address;
        }

        public void UpdateEmployeeList(List<ListItem> employees)
        {
            this.cmbEmployee.Items.Clear();
            foreach (ListItem item in employees)
            {
                this.cmbEmployee.Items.Add(item);
            }
            this.cmbEmployee.SelectedIndex = 0;
        }

        public void UpdateRoomList(List<ListItem> rooms)
        {
            this.cmbRoom.Items.Clear();
            foreach (ListItem item in rooms)
            {
                this.cmbRoom.Items.Add(item);
            }
            if(rooms.Count > 0)
            {
                this.cmbRoom.SelectedIndex = 0;
            }
        }

        public void UpdateRoomDetails(String roomType, uint capacity)
        {
            this.lblRoomType.Text = $"Sala {roomType}";

            var pluralizerService = new PolishPluralizerService("miejsce", "miejsca", "miejsc");

            this.lblRoomCapacity.Text = $"Pojemność: {capacity} {pluralizerService.Pluralize((int)capacity)}";
        }

        public void LoadReservationForEdition(ReservationData reservation)
        {
            this.cmbDepartment.SelectedItem = this.cmbDepartment.Items
                .Cast<ListItem>()
                .FirstOrDefault(item => item.Value == reservation.Department.Value);
            this.cmbRoom.SelectedItem = this.cmbRoom.Items
                .Cast<ListItem>()
                .FirstOrDefault(item => item.Value == reservation.Room.Value);
            this.cmbEmployee.SelectedItem = this.cmbEmployee.Items
                .Cast<ListItem>()
                .FirstOrDefault(item => item.Value == reservation.Reservee.Value);
            this.dtpFrom.Value = DateTime.Today.Add(reservation.From.ToTimeSpan());
            this.dtpTo.Value = DateTime.Today.Add(reservation.To.ToTimeSpan());
            this.dtpDate.Value = reservation.Date.ToDateTime(reservation.From);

            this.btnAddReservation.Enabled = false;
            this.btnEditReservation.Enabled = true;
            this.btnDeleteReservation.Enabled = true;
            this.btnAddReservation.Visible = false;
            this.btnEditReservation.Visible = true;
            this.btnDeleteReservation.Visible = true;
        }

        public void CloseView()
        {
            this.Close();
        }

        public void DisplayError(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private ReservationData? inputReservation()
        {
            var selectedDepartment = this.cmbDepartment.SelectedItem as ListItem;
            var selectedRoom = this.cmbRoom.SelectedItem as ListItem;
            var selectedEmployee = this.cmbEmployee.SelectedItem as ListItem;

            if (selectedDepartment == null)
            {
                DisplayError("Nie wybrano wydziału");
                return null;
            }

            if (selectedRoom == null)
            {
                DisplayError("Nie wybrano sali");
                return null;
            }

            if (selectedEmployee == null)
            {
                DisplayError("Nie wybrano osoby dokonującej rezerwacji");
                return null;
            }

            return new ReservationData(
                selectedDepartment,
                selectedRoom,
                selectedEmployee,
                TimeOnly.FromDateTime(this.dtpFrom.Value),
                TimeOnly.FromDateTime(this.dtpTo.Value),
                DateOnly.FromDateTime(this.dtpDate.Value)
            );
        }

        private void selectedDepartment(object sender, EventArgs e)
        {
            var selected = this.cmbDepartment.SelectedItem as ListItem;

            if (selected != null)
            {
                this.SelectDepartment?.Invoke(this, selected.Value);
            }
        }

        private void selectedRoom(object sender, EventArgs e)
        {
            var selected = this.cmbRoom.SelectedItem as ListItem;

            if (selected != null)
            {
                this.SelectRoom?.Invoke(this, selected.Value);
            }
        }

        private void addReservation(object sender, EventArgs e)
        {
            var reservationData = this.inputReservation();

            if (reservationData != null)
            {
                this.AddReservation?.Invoke(this, reservationData);
            }
        }

        private void editReservation(object sender, EventArgs e)
        {
            var reservationData = this.inputReservation();

            if (reservationData != null)
            {
                this.EditReservation?.Invoke(this, reservationData);
            }
        }

        private void deleteReservation(object sender, EventArgs e)
        {
            this.DeleteReservation?.Invoke(this, EventArgs.Empty);
        }
    }
}
