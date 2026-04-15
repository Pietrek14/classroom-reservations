namespace dpiotrowski_lab2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode1 = new TreeNode("dr hab. Adam Zielonka, prof PŚ (8:30-10:00)");
            TreeNode treeNode2 = new TreeNode("tech. Dawid Piotrowski (12:00-13:30)");
            TreeNode treeNode3 = new TreeNode("403", new TreeNode[] { treeNode1, treeNode2 });
            TreeNode treeNode4 = new TreeNode("306");
            tbcMainLayout = new TabControl();
            tbpReservationList = new TabPage();
            pnlReservations = new Panel();
            dtpReservationDate = new DateTimePicker();
            btnAddReservation = new Button();
            cmbReservationDepartmentSelection = new ComboBox();
            trvReservationList = new TreeView();
            tbpEmployeeList = new TabPage();
            pnlEmployees = new Panel();
            button1 = new Button();
            lsbEmployeeList = new ListBox();
            tbpRoomList = new TabPage();
            panel1 = new Panel();
            lblDepartmentAddress = new Label();
            cmbRoomDepartmentSelection = new ComboBox();
            button2 = new Button();
            lsbRoomList = new ListBox();
            tbcMainLayout.SuspendLayout();
            tbpReservationList.SuspendLayout();
            pnlReservations.SuspendLayout();
            tbpEmployeeList.SuspendLayout();
            pnlEmployees.SuspendLayout();
            tbpRoomList.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbcMainLayout
            // 
            tbcMainLayout.Alignment = TabAlignment.Bottom;
            tbcMainLayout.Controls.Add(tbpReservationList);
            tbcMainLayout.Controls.Add(tbpEmployeeList);
            tbcMainLayout.Controls.Add(tbpRoomList);
            tbcMainLayout.Dock = DockStyle.Fill;
            tbcMainLayout.Location = new Point(0, 0);
            tbcMainLayout.Name = "tbcMainLayout";
            tbcMainLayout.SelectedIndex = 0;
            tbcMainLayout.Size = new Size(1008, 689);
            tbcMainLayout.TabIndex = 1;
            // 
            // tbpReservationList
            // 
            tbpReservationList.BackColor = Color.FromArgb(30, 30, 30);
            tbpReservationList.Controls.Add(pnlReservations);
            tbpReservationList.Location = new Point(4, 4);
            tbpReservationList.Name = "tbpReservationList";
            tbpReservationList.Padding = new Padding(3);
            tbpReservationList.Size = new Size(1000, 661);
            tbpReservationList.TabIndex = 1;
            tbpReservationList.Text = "Rezerwacje";
            // 
            // pnlReservations
            // 
            pnlReservations.BackColor = Color.FromArgb(37, 37, 37);
            pnlReservations.Controls.Add(dtpReservationDate);
            pnlReservations.Controls.Add(btnAddReservation);
            pnlReservations.Controls.Add(cmbReservationDepartmentSelection);
            pnlReservations.Controls.Add(trvReservationList);
            pnlReservations.Location = new Point(37, 37);
            pnlReservations.Margin = new Padding(32);
            pnlReservations.Name = "pnlReservations";
            pnlReservations.Size = new Size(931, 589);
            pnlReservations.TabIndex = 2;
            // 
            // dtpReservationDate
            // 
            dtpReservationDate.Format = DateTimePickerFormat.Short;
            dtpReservationDate.Location = new Point(82, 101);
            dtpReservationDate.Name = "dtpReservationDate";
            dtpReservationDate.Size = new Size(200, 23);
            dtpReservationDate.TabIndex = 5;
            dtpReservationDate.ValueChanged += reservationDateSelected;
            // 
            // btnAddReservation
            // 
            btnAddReservation.BackColor = Color.FromArgb(37, 37, 37);
            btnAddReservation.FlatAppearance.BorderSize = 0;
            btnAddReservation.FlatStyle = FlatStyle.Flat;
            btnAddReservation.Font = new Font("Segoe UI", 21F);
            btnAddReservation.ForeColor = SystemColors.Window;
            btnAddReservation.Location = new Point(805, 41);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(44, 43);
            btnAddReservation.TabIndex = 4;
            btnAddReservation.Text = "+";
            btnAddReservation.UseVisualStyleBackColor = false;
            btnAddReservation.Click += addReservation;
            // 
            // cmbReservationDepartmentSelection
            // 
            cmbReservationDepartmentSelection.Font = new Font("Segoe UI", 14F);
            cmbReservationDepartmentSelection.FormattingEnabled = true;
            cmbReservationDepartmentSelection.Location = new Point(82, 51);
            cmbReservationDepartmentSelection.Name = "cmbReservationDepartmentSelection";
            cmbReservationDepartmentSelection.Size = new Size(434, 33);
            cmbReservationDepartmentSelection.TabIndex = 3;
            cmbReservationDepartmentSelection.Text = "Wydział Matematyki Stosowanej";
            cmbReservationDepartmentSelection.SelectedIndexChanged += departmentSelected;
            // 
            // trvReservationList
            // 
            trvReservationList.BackColor = Color.FromArgb(37, 37, 37);
            trvReservationList.BorderStyle = BorderStyle.None;
            trvReservationList.Font = new Font("Segoe UI", 17F);
            trvReservationList.ForeColor = SystemColors.Window;
            trvReservationList.Indent = 28;
            trvReservationList.Location = new Point(82, 145);
            trvReservationList.Name = "trvReservationList";
            treeNode1.Name = "reservation_403_1";
            treeNode1.Text = "dr hab. Adam Zielonka, prof PŚ (8:30-10:00)";
            treeNode2.Name = "reservation_403_2";
            treeNode2.Text = "tech. Dawid Piotrowski (12:00-13:30)";
            treeNode3.Name = "room403";
            treeNode3.Text = "403";
            treeNode4.Name = "room306";
            treeNode4.Text = "306";
            trvReservationList.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            trvReservationList.Size = new Size(767, 388);
            trvReservationList.TabIndex = 1;
            trvReservationList.AfterSelect += reservationSelected;
            // 
            // tbpEmployeeList
            // 
            tbpEmployeeList.BackColor = Color.FromArgb(30, 30, 30);
            tbpEmployeeList.Controls.Add(pnlEmployees);
            tbpEmployeeList.Location = new Point(4, 4);
            tbpEmployeeList.Name = "tbpEmployeeList";
            tbpEmployeeList.Padding = new Padding(3);
            tbpEmployeeList.Size = new Size(1000, 661);
            tbpEmployeeList.TabIndex = 0;
            tbpEmployeeList.Text = "Prowadzący";
            // 
            // pnlEmployees
            // 
            pnlEmployees.BackColor = Color.FromArgb(37, 37, 37);
            pnlEmployees.Controls.Add(button1);
            pnlEmployees.Controls.Add(lsbEmployeeList);
            pnlEmployees.Location = new Point(35, 36);
            pnlEmployees.Margin = new Padding(32);
            pnlEmployees.Name = "pnlEmployees";
            pnlEmployees.Size = new Size(931, 589);
            pnlEmployees.TabIndex = 3;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 37, 37);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 21F);
            button1.ForeColor = SystemColors.Window;
            button1.Location = new Point(803, 41);
            button1.Name = "button1";
            button1.Size = new Size(44, 43);
            button1.TabIndex = 5;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += addEmployee;
            // 
            // lsbEmployeeList
            // 
            lsbEmployeeList.BackColor = Color.FromArgb(37, 37, 37);
            lsbEmployeeList.BorderStyle = BorderStyle.None;
            lsbEmployeeList.Font = new Font("Segoe UI", 15F);
            lsbEmployeeList.ForeColor = SystemColors.Window;
            lsbEmployeeList.FormattingEnabled = true;
            lsbEmployeeList.Items.AddRange(new object[] { "dr hab. Adam Zielonka, prof. PŚ", "tech. Dawid Piotrowski", "mgr² inż. Beniamin Stecuła" });
            lsbEmployeeList.Location = new Point(71, 58);
            lsbEmployeeList.Name = "lsbEmployeeList";
            lsbEmployeeList.Size = new Size(726, 476);
            lsbEmployeeList.TabIndex = 0;
            lsbEmployeeList.SelectedIndexChanged += employeeSelected;
            // 
            // tbpRoomList
            // 
            tbpRoomList.BackColor = Color.FromArgb(30, 30, 30);
            tbpRoomList.Controls.Add(panel1);
            tbpRoomList.Location = new Point(4, 4);
            tbpRoomList.Name = "tbpRoomList";
            tbpRoomList.Size = new Size(1000, 661);
            tbpRoomList.TabIndex = 2;
            tbpRoomList.Text = "Sale";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(37, 37, 37);
            panel1.Controls.Add(lblDepartmentAddress);
            panel1.Controls.Add(cmbRoomDepartmentSelection);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lsbRoomList);
            panel1.Location = new Point(35, 36);
            panel1.Margin = new Padding(32);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 589);
            panel1.TabIndex = 4;
            // 
            // lblDepartmentAddress
            // 
            lblDepartmentAddress.AutoSize = true;
            lblDepartmentAddress.Font = new Font("Segoe UI", 12F);
            lblDepartmentAddress.ForeColor = SystemColors.Window;
            lblDepartmentAddress.Location = new Point(76, 89);
            lblDepartmentAddress.Name = "lblDepartmentAddress";
            lblDepartmentAddress.Size = new Size(236, 21);
            lblDepartmentAddress.TabIndex = 7;
            lblDepartmentAddress.Text = "44-100 Gliwice, ul. Kaszubska 23";
            // 
            // cmbRoomDepartmentSelection
            // 
            cmbRoomDepartmentSelection.Font = new Font("Segoe UI", 14F);
            cmbRoomDepartmentSelection.FormattingEnabled = true;
            cmbRoomDepartmentSelection.Location = new Point(76, 53);
            cmbRoomDepartmentSelection.Name = "cmbRoomDepartmentSelection";
            cmbRoomDepartmentSelection.Size = new Size(434, 33);
            cmbRoomDepartmentSelection.TabIndex = 6;
            cmbRoomDepartmentSelection.Text = "Wydział Matematyki Stosowanej";
            cmbRoomDepartmentSelection.SelectedIndexChanged += departmentSelected;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(37, 37, 37);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 21F);
            button2.ForeColor = SystemColors.Window;
            button2.Location = new Point(803, 41);
            button2.Name = "button2";
            button2.Size = new Size(44, 43);
            button2.TabIndex = 5;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = false;
            button2.Click += addRoom;
            // 
            // lsbRoomList
            // 
            lsbRoomList.BackColor = Color.FromArgb(37, 37, 37);
            lsbRoomList.BorderStyle = BorderStyle.None;
            lsbRoomList.Font = new Font("Segoe UI", 15F);
            lsbRoomList.ForeColor = SystemColors.Window;
            lsbRoomList.FormattingEnabled = true;
            lsbRoomList.Items.AddRange(new object[] { "408 (sala wykladowa, 120 miejsc)", "306 (sala komputerowa, 24 miejsca)" });
            lsbRoomList.Location = new Point(76, 134);
            lsbRoomList.Name = "lsbRoomList";
            lsbRoomList.Size = new Size(726, 392);
            lsbRoomList.TabIndex = 0;
            lsbRoomList.SelectedIndexChanged += roomSelected;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 689);
            Controls.Add(tbcMainLayout);
            Name = "MainForm";
            Text = "Rezerwacja sal";
            tbcMainLayout.ResumeLayout(false);
            tbpReservationList.ResumeLayout(false);
            pnlReservations.ResumeLayout(false);
            tbpEmployeeList.ResumeLayout(false);
            pnlEmployees.ResumeLayout(false);
            tbpRoomList.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabControl tbcMainLayout;
        private TabPage tbpEmployeeList;
        private TabPage tbpReservationList;
        private TreeView trvReservationList;
        private TabPage tbpRoomList;
        private Panel pnlReservations;
        private ComboBox cmbReservationDepartmentSelection;
        private Button btnAddReservation;
        private Panel pnlEmployees;
        private ListBox lsbEmployeeList;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private ListBox lsbRoomList;
        private Label lblDepartmentAddress;
        private ComboBox cmbRoomDepartmentSelection;
        private DateTimePicker dtpReservationDate;
    }
}
