namespace dpiotrowski_lab2
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEmployeeHeader = new Label();
            btnAddEmployee = new Button();
            btnEditEmployee = new Button();
            btnDeleteEmployee = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblTitlePrefix = new Label();
            lblTitlePostfix = new Label();
            tbxFirstName = new TextBox();
            tbxLastName = new TextBox();
            tbxTitlePrefix = new TextBox();
            tbxTitlePostfix = new TextBox();
            SuspendLayout();
            // 
            // lblEmployeeHeader
            // 
            lblEmployeeHeader.AutoSize = true;
            lblEmployeeHeader.Font = new Font("Segoe UI", 19F);
            lblEmployeeHeader.ForeColor = SystemColors.Window;
            lblEmployeeHeader.Location = new Point(29, 32);
            lblEmployeeHeader.Name = "lblEmployeeHeader";
            lblEmployeeHeader.Size = new Size(151, 36);
            lblEmployeeHeader.TabIndex = 0;
            lblEmployeeHeader.Text = "Prowadzący";
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.FromArgb(43, 92, 255);
            btnAddEmployee.FlatAppearance.BorderSize = 0;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Segoe UI", 11F);
            btnAddEmployee.ForeColor = SystemColors.Window;
            btnAddEmployee.Location = new Point(300, 374);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(223, 35);
            btnAddEmployee.TabIndex = 19;
            btnAddEmployee.Text = "Dodaj prowadzącego";
            btnAddEmployee.UseVisualStyleBackColor = false;
            // 
            // btnEditEmployee
            // 
            btnEditEmployee.BackColor = Color.FromArgb(43, 92, 255);
            btnEditEmployee.Enabled = false;
            btnEditEmployee.FlatAppearance.BorderSize = 0;
            btnEditEmployee.FlatStyle = FlatStyle.Flat;
            btnEditEmployee.Font = new Font("Segoe UI", 11F);
            btnEditEmployee.ForeColor = SystemColors.Window;
            btnEditEmployee.Location = new Point(300, 353);
            btnEditEmployee.Name = "btnEditEmployee";
            btnEditEmployee.Size = new Size(223, 35);
            btnEditEmployee.TabIndex = 20;
            btnEditEmployee.Text = "Edytuj prowadzącego";
            btnEditEmployee.UseVisualStyleBackColor = false;
            btnEditEmployee.Visible = false;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.FromArgb(255, 43, 43);
            btnDeleteEmployee.Enabled = false;
            btnDeleteEmployee.FlatAppearance.BorderSize = 0;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Font = new Font("Segoe UI", 11F);
            btnDeleteEmployee.ForeColor = SystemColors.Window;
            btnDeleteEmployee.Location = new Point(300, 394);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(223, 35);
            btnDeleteEmployee.TabIndex = 21;
            btnDeleteEmployee.Text = "Usuń prowadzącego";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Visible = false;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI", 10F);
            lblFirstName.ForeColor = SystemColors.Window;
            lblFirstName.Location = new Point(29, 99);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(37, 19);
            lblFirstName.TabIndex = 22;
            lblFirstName.Text = "imię:";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI", 10F);
            lblLastName.ForeColor = SystemColors.Window;
            lblLastName.Location = new Point(29, 140);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(67, 19);
            lblLastName.TabIndex = 23;
            lblLastName.Text = "nazwisko:";
            // 
            // lblTitlePrefix
            // 
            lblTitlePrefix.AutoSize = true;
            lblTitlePrefix.Font = new Font("Segoe UI", 10F);
            lblTitlePrefix.ForeColor = SystemColors.Window;
            lblTitlePrefix.Location = new Point(29, 184);
            lblTitlePrefix.Name = "lblTitlePrefix";
            lblTitlePrefix.Size = new Size(86, 19);
            lblTitlePrefix.TabIndex = 24;
            lblTitlePrefix.Text = "tytuł (prefix):";
            // 
            // lblTitlePostfix
            // 
            lblTitlePostfix.AutoSize = true;
            lblTitlePostfix.Font = new Font("Segoe UI", 10F);
            lblTitlePostfix.ForeColor = SystemColors.Window;
            lblTitlePostfix.Location = new Point(29, 229);
            lblTitlePostfix.Name = "lblTitlePostfix";
            lblTitlePostfix.Size = new Size(93, 19);
            lblTitlePostfix.TabIndex = 25;
            lblTitlePostfix.Text = "tytuł (postfix):";
            // 
            // tbxFirstName
            // 
            tbxFirstName.Font = new Font("Segoe UI", 12F);
            tbxFirstName.Location = new Point(179, 93);
            tbxFirstName.Name = "tbxFirstName";
            tbxFirstName.Size = new Size(204, 29);
            tbxFirstName.TabIndex = 26;
            // 
            // tbxLastName
            // 
            tbxLastName.Font = new Font("Segoe UI", 12F);
            tbxLastName.Location = new Point(179, 134);
            tbxLastName.Name = "tbxLastName";
            tbxLastName.Size = new Size(204, 29);
            tbxLastName.TabIndex = 27;
            // 
            // tbxTitlePrefix
            // 
            tbxTitlePrefix.Font = new Font("Segoe UI", 12F);
            tbxTitlePrefix.Location = new Point(179, 178);
            tbxTitlePrefix.Name = "tbxTitlePrefix";
            tbxTitlePrefix.Size = new Size(204, 29);
            tbxTitlePrefix.TabIndex = 28;
            // 
            // tbxTitlePostfix
            // 
            tbxTitlePostfix.Font = new Font("Segoe UI", 12F);
            tbxTitlePostfix.Location = new Point(179, 223);
            tbxTitlePostfix.Name = "tbxTitlePostfix";
            tbxTitlePostfix.Size = new Size(204, 29);
            tbxTitlePostfix.TabIndex = 29;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(tbxTitlePostfix);
            Controls.Add(tbxTitlePrefix);
            Controls.Add(tbxLastName);
            Controls.Add(tbxFirstName);
            Controls.Add(lblTitlePostfix);
            Controls.Add(lblTitlePrefix);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(btnEditEmployee);
            Controls.Add(btnAddEmployee);
            Controls.Add(lblEmployeeHeader);
            Name = "EmployeeForm";
            Text = "Prowadzący";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmployeeHeader;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private Button btnAddEmployee;
        private Button btnEditEmployee;
        private Button btnDeleteEmployee;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblTitlePrefix;
        private Label lblTitlePostfix;
        private TextBox tbxFirstName;
        private TextBox tbxLastName;
        private TextBox tbxTitlePrefix;
        private TextBox tbxTitlePostfix;
    }
}