using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.Presenter.RoomPresenter;
using dpiotrowski_lab2.View.RoomView;
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
    public partial class RoomForm : Form, IRoomEditView
    {
        public event EventHandler<RoomData>? AddRoom;
        public event EventHandler<RoomData>? UpdateRoom;
        public event EventHandler? RemoveRoom;

        public event EventHandler? LoadDepartmentList;
        public event EventHandler<Guid>? SelectDepartment;

        private Guid selectedDepartmentId;

        public RoomForm()
        {
            InitializeComponent();

            this.LoadDepartmentList?.Invoke(this, EventArgs.Empty);
        }

        public void LoadRoomForEdition(RoomData room)
        {
            this.tbxRoomNumber.Text = room.RoomNumber;
            this.cmbRoomType.Text = room.RoomType;
            this.numCapacity.Value = room.Capacity;

            this.selectedDepartmentId = room.DepartmentId;
            this.loadDepartmentIntoForm();

            this.btnAddRoom.Enabled = false;
            this.btnEditRoom.Enabled = true;
            this.btnDeleteRoom.Enabled = true;
            this.btnAddRoom.Visible = false;
            this.btnEditRoom.Visible = true;
            this.btnDeleteRoom.Visible = true;
        }

        public void UpdateDepartmentList(List<ListItem> items)
        {
            this.cmbDepartment.Items.Clear();

            foreach (ListItem item in items)
            {
                this.cmbDepartment.Items.Add(item);
            }

            this.loadDepartmentIntoForm();
        }

        public void UpdateDepartmentAddress(string address)
        {
            this.lblDepartmentAddress.Text = address;
        }

        public void CloseView()
        {
            this.Close();
        }

        public void DisplayError(string message)
        {
            MessageBox.Show(message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private RoomData? inputRoom()
        {
            var selectedDepartment = this.cmbDepartment.SelectedItem as ListItem;

            if (selectedDepartment == null)
            {
                this.DisplayError("Należy wybrać wydział");
                return null;
            }

            var room = new RoomData(
                this.tbxRoomNumber.Text,
                this.cmbRoomType.Text,
                (uint)this.numCapacity.Value,
                selectedDepartment.Value
            );

            return room;
        }

        private void addRoom(object sender, EventArgs e)
        {
            var room = inputRoom();
            if (room != null)
            {
                this.AddRoom?.Invoke(this, room);
            }
        }

        private void editRoom(object sender, EventArgs e)
        {
            var room = inputRoom();
            if (room != null)
            {
                this.UpdateRoom?.Invoke(this, room);
            }
        }

        private void deleteRoom(object sender, EventArgs e)
        {
            this.RemoveRoom?.Invoke(this, EventArgs.Empty);
        }

        private void loadDepartmentIntoForm()
        {
            if(this.selectedDepartmentId == Guid.Empty)
            {
                this.cmbDepartment.SelectedIndex = 0;
                return;
            }

            this.cmbDepartment.SelectedIndex = this.cmbDepartment.Items
                .Cast<ListItem>()
                .ToList()
                .FindIndex(item => item.Value == this.selectedDepartmentId);
        }

        private void selectedDepartment(object sender, EventArgs e)
        {
            var selected = this.cmbDepartment.SelectedItem as ListItem;

            if (selected != null)
            {
                this.SelectDepartment?.Invoke(this, selected.Value);
            }
        }
    }
}
