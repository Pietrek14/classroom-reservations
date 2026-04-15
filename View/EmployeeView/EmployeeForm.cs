using dpiotrowski_lab2.Presenter.EmployeePresenter;
using dpiotrowski_lab2.View.EmployeeView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dpiotrowski_lab2
{
    public partial class EmployeeForm : Form, ISingleEmployeeView
    {
        public event EventHandler<EmployeeData>? AddEmployee;
        public event EventHandler<EmployeeData>? EditEmployee;
        public event EventHandler? DeleteEmployee;

        public EmployeeForm()
        {
            InitializeComponent();
        }

        public void LoadEmployeeForEdition(EmployeeData employee)
        {
            this.tbxFirstName.Text = employee.FirstName;
            this.tbxLastName.Text = employee.LastName;
            this.tbxTitlePrefix.Text = employee.TitlePrefix;
            this.tbxTitleSuffix.Text = employee.TitleSuffix;

            this.btnAddEmployee.Enabled = false;
            this.btnEditEmployee.Enabled = true;
            this.btnDeleteEmployee.Enabled = true;
            this.btnAddEmployee.Visible = false;
            this.btnEditEmployee.Visible = true;
            this.btnDeleteEmployee.Visible = true;
        }

        public void CloseView()
        {
            this.Close();
        }

        public void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private EmployeeData inputEmployee()
        {
            return new EmployeeData(
                this.tbxFirstName.Text,
                this.tbxLastName.Text,
                this.tbxTitlePrefix.Text,
                this.tbxTitleSuffix.Text
            );
        }

        private void addEmployee(object sender, EventArgs e)
        {
            this.AddEmployee?.Invoke(this, inputEmployee());
        }

        private void editEmployee(object sender, EventArgs e)
        {
            this.EditEmployee?.Invoke(this, inputEmployee());
        }

        private void deleteEmployee(object sender, EventArgs e)
        {
            this.DeleteEmployee?.Invoke(this, EventArgs.Empty);
        }
    }
}
