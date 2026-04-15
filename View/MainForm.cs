using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.View.EmployeeView;
using dpiotrowski_lab2.View.ReservationView;
using dpiotrowski_lab2.View.RoomView;
using System.Diagnostics;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace dpiotrowski_lab2
{
    public partial class MainForm : Form, IEmployeeListView, IRoomListView, IReservationListView
    {
        public event EventHandler? LoadEmployeeList;
        public event EventHandler? LoadDepartmentList;
        public event EventHandler<Guid>? SelectDepartment;
        public event EventHandler<DateOnly>? SelectDate;

        public event EventHandler<Guid>? SelectRoomToEdit;
        public event EventHandler? AddRoom;
        public event EventHandler<Guid>? SelectEmployeeToEdit;
        public event EventHandler? AddEmployee;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadEmployeeList?.Invoke(this, EventArgs.Empty);
            this.LoadDepartmentList?.Invoke(this, EventArgs.Empty);
            this.setStartingDate();
        }

        public void UpdateEmployeeList(List<ListItem> employees)
        {
            this.lsbEmployeeList.Items.Clear();

            foreach (ListItem employee in employees)
            {
                this.lsbEmployeeList.Items.Add(employee);
            }
        }

        public void UpdateDepartmentList(List<ListItem> departments)
        {
            this.cmbReservationDepartmentSelection.Items.Clear();
            this.cmbRoomDepartmentSelection.Items.Clear();
            foreach (ListItem department in departments)
            {
                this.cmbReservationDepartmentSelection.Items.Add(department);
                this.cmbRoomDepartmentSelection.Items.Add(department);
            }

            if (departments.Count > 0)
            {
                this.cmbReservationDepartmentSelection.SelectedIndex = 0;
                this.cmbRoomDepartmentSelection.SelectedIndex = 0;
            }
        }

        public void UpdateReservationList(Dictionary<ListItem, List<ListItem>> reservations)
        {
            this.trvReservationList.BeginUpdate();
            this.trvReservationList.Nodes.Clear();

            foreach (var department in reservations)
            {
                TreeNode departmentNode = new TreeNode(department.Key.Display);
                foreach (var reservation in department.Value)
                {
                    TreeNode reservationNode = new TreeNode(reservation.Display);
                    departmentNode.Nodes.Add(reservationNode);
                }
                this.trvReservationList.Nodes.Add(departmentNode);
            }

            this.trvReservationList.EndUpdate();
        }

        public void UpdateDepartmentAddress(string address)
        {
            this.lblDepartmentAddress.Text = address;
        }

        public void UpdateRoomList(List<ListItem> rooms)
        {
            this.lsbRoomList.Items.Clear();

            foreach (ListItem room in rooms)
            {
                this.lsbRoomList.Items.Add(room);
            }
        }

        public ISingleRoomView OpenSingleRoomView()
        {
            var singleRoomForm = new RoomForm();
            singleRoomForm.Show();
            return singleRoomForm;
        }

        public ISingleEmployeeView OpenSingleEmployeeView()
        {
            var singleEmployeeForm = new EmployeeForm();
            singleEmployeeForm.Show();
            return singleEmployeeForm;
        }

        private void departmentSelected(object sender, EventArgs e)
        {
            var cmbSender = (ComboBox)sender;

            var selectedItem = (ListItem?)cmbSender.SelectedItem;
            var selectedIndex = cmbSender.SelectedIndex;

            if (selectedItem != null)
            {
                this.SelectDepartment?.Invoke(this, selectedItem.Value);
            }

            // Update all other combo boxes
            var comboBoxes = new ComboBox[] { this.cmbReservationDepartmentSelection, this.cmbRoomDepartmentSelection };

            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex != selectedIndex)
                {
                    comboBox.SelectedIndex = cmbSender.SelectedIndex;
                }
            }
        }

        private void reservationDateSelected(object? sender, EventArgs? e)
        {
            DateOnly selectedDate = DateOnly.FromDateTime(this.dtpReservationDate.Value);
            this.SelectDate?.Invoke(this, selectedDate);
        }

        private void setStartingDate()
        {
            this.dtpReservationDate.Value = DateTime.Now;
            this.reservationDateSelected(null, null);
        }

        private void roomSelected(object sender, EventArgs e)
        {
            var selected = lsbRoomList.SelectedItem as ListItem;

            if (selected != null)
            {
                this.SelectRoomToEdit?.Invoke(this, selected.Value);
            }
        }

        private void addRoom(object sender, EventArgs e)
        {
            this.AddRoom?.Invoke(this, EventArgs.Empty);
        }

        private void employeeSelected(object sender, EventArgs e)
        {
            var selected = lsbEmployeeList.SelectedItem as ListItem;

            if (selected != null)
            {
                this.SelectEmployeeToEdit?.Invoke(this, selected.Value);
            }
        }

        private void addEmployee(object sender, EventArgs e)
        {
            this.AddEmployee?.Invoke(this, EventArgs.Empty);
        }
    }
}
