using dpiotrowski_lab2.Model;
using dpiotrowski_lab2.Presenter.EmployeeList;
using dpiotrowski_lab2.View.Main;

namespace dpiotrowski_lab2
{
    public partial class MainForm : Form, IEmployeeListView
    {
        private ModelManager model;
        private EmployeeListPresenter employeeListPresenter;

        public MainForm(ModelManager model)
        {
            InitializeComponent();

            this.model = model;
            this.employeeListPresenter = new EmployeeListPresenter(model.EmployeeList, this);
        }

        public void UpdateEmployeeList(List<EmployeeListItem> employees)
        {
            this.lsbEmployeeList.Items.Clear();

            foreach(EmployeeListItem employee in employees)
            {
                this.lsbEmployeeList.Items.Add(employee);
            }
        }
    }
}
