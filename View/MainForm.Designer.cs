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
            comboBox1 = new ComboBox();
            treeView1 = new TreeView();
            tbpEmployeeList = new TabPage();
            pnlEmployees = new Panel();
            button1 = new Button();
            lsbEmployeeList = new ListBox();
            tbpRoomList = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            comboBox2 = new ComboBox();
            button2 = new Button();
            listBox1 = new ListBox();
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
            pnlReservations.Controls.Add(comboBox1);
            pnlReservations.Controls.Add(treeView1);
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
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Segoe UI", 19F);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(82, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(434, 43);
            comboBox1.TabIndex = 3;
            comboBox1.Text = "Wydział Matematyki Stosowanej";
            // 
            // treeView1
            // 
            treeView1.BackColor = Color.FromArgb(37, 37, 37);
            treeView1.BorderStyle = BorderStyle.None;
            treeView1.Font = new Font("Segoe UI", 17F);
            treeView1.ForeColor = SystemColors.Window;
            treeView1.Indent = 28;
            treeView1.Location = new Point(82, 145);
            treeView1.Name = "treeView1";
            treeNode1.Name = "reservation_403_1";
            treeNode1.Text = "dr hab. Adam Zielonka, prof PŚ (8:30-10:00)";
            treeNode2.Name = "reservation_403_2";
            treeNode2.Text = "tech. Dawid Piotrowski (12:00-13:30)";
            treeNode3.Name = "room403";
            treeNode3.Text = "403";
            treeNode4.Name = "room306";
            treeNode4.Text = "306";
            treeView1.Nodes.AddRange(new TreeNode[] { treeNode3, treeNode4 });
            treeView1.Size = new Size(767, 388);
            treeView1.TabIndex = 1;
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
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(listBox1);
            panel1.Location = new Point(35, 36);
            panel1.Margin = new Padding(32);
            panel1.Name = "panel1";
            panel1.Size = new Size(931, 589);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(76, 89);
            label1.Name = "label1";
            label1.Size = new Size(339, 31);
            label1.TabIndex = 7;
            label1.Text = "44-100 Gliwice, ul. Kaszubska 23";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 19F);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(76, 43);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(434, 43);
            comboBox2.TabIndex = 6;
            comboBox2.Text = "Wydział Matematyki Stosowanej";
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
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.FromArgb(37, 37, 37);
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.Font = new Font("Segoe UI", 15F);
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "408 (sala wykladowa, 120 miejsc)", "306 (sala komputerowa, 24 miejsca)" });
            listBox1.Location = new Point(76, 163);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(726, 364);
            listBox1.TabIndex = 0;
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
        private TreeView treeView1;
        private TabPage tbpRoomList;
        private Panel pnlReservations;
        private ComboBox comboBox1;
        private Button btnAddReservation;
        private Panel pnlEmployees;
        private ListBox lsbEmployeeList;
        private Button button1;
        private Panel panel1;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
        private ComboBox comboBox2;
        private DateTimePicker dtpReservationDate;
    }
}
