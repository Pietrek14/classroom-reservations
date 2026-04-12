using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Presenter;
using dpiotrowski_lab2.View.Main;

namespace dpiotrowski_lab2
{
    public partial class MainForm : Form, IEmployeeListView, IRoomListView
    {
        public event EventHandler? LoadEmployeeList;
        public event EventHandler? LoadDepartmentList;
        public event EventHandler<Guid>? SelectDepartment;

        public MainForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.LoadEmployeeList?.Invoke(this, EventArgs.Empty);
            this.LoadDepartmentList?.Invoke(this, EventArgs.Empty);
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

            if(departments.Count > 0)
            {
                this.cmbReservationDepartmentSelection.SelectedIndex = 0;
                this.cmbRoomDepartmentSelection.SelectedIndex = 0;
            }

            this.RoomDepartmentSelected(null, null);
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
                this.lsbEmployeeList.Items.Add(room);
            }
        }

        private void RoomDepartmentSelected(object? sender, EventArgs? e)
        {
            if(this.cmbRoomDepartmentSelection.SelectedItem != null)
            {
                this.SelectDepartment?.Invoke(this, ((ListItem)this.cmbRoomDepartmentSelection.SelectedItem).Value);
            }
        }
    }
}
