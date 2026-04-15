namespace dpiotrowski_lab2
{
    partial class RoomForm
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
            lblRoomHeader = new Label();
            btnAddRoom = new Button();
            btnEditRoom = new Button();
            btnDeleteRoom = new Button();
            lblRoomNumber = new Label();
            lblRoomType = new Label();
            lblCapacity = new Label();
            cmbRoomType = new ComboBox();
            numCapacity = new NumericUpDown();
            lblDepartmentAddress = new Label();
            cmbDepartment = new ComboBox();
            tbxRoomNumber = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numCapacity).BeginInit();
            SuspendLayout();
            // 
            // lblRoomHeader
            // 
            lblRoomHeader.AutoSize = true;
            lblRoomHeader.Font = new Font("Segoe UI", 19F);
            lblRoomHeader.ForeColor = SystemColors.Window;
            lblRoomHeader.Location = new Point(29, 32);
            lblRoomHeader.Name = "lblRoomHeader";
            lblRoomHeader.Size = new Size(61, 36);
            lblRoomHeader.TabIndex = 0;
            lblRoomHeader.Text = "Sala";
            // 
            // btnAddRoom
            // 
            btnAddRoom.BackColor = Color.FromArgb(43, 92, 255);
            btnAddRoom.FlatAppearance.BorderSize = 0;
            btnAddRoom.FlatStyle = FlatStyle.Flat;
            btnAddRoom.Font = new Font("Segoe UI", 11F);
            btnAddRoom.ForeColor = SystemColors.Window;
            btnAddRoom.Location = new Point(300, 374);
            btnAddRoom.Name = "btnAddRoom";
            btnAddRoom.Size = new Size(223, 35);
            btnAddRoom.TabIndex = 19;
            btnAddRoom.Text = "Dodaj salę";
            btnAddRoom.UseVisualStyleBackColor = false;
            btnAddRoom.Click += addRoom;
            // 
            // btnEditRoom
            // 
            btnEditRoom.BackColor = Color.FromArgb(43, 92, 255);
            btnEditRoom.Enabled = false;
            btnEditRoom.FlatAppearance.BorderSize = 0;
            btnEditRoom.FlatStyle = FlatStyle.Flat;
            btnEditRoom.Font = new Font("Segoe UI", 11F);
            btnEditRoom.ForeColor = SystemColors.Window;
            btnEditRoom.Location = new Point(300, 353);
            btnEditRoom.Name = "btnEditRoom";
            btnEditRoom.Size = new Size(223, 35);
            btnEditRoom.TabIndex = 20;
            btnEditRoom.Text = "Edytuj salę";
            btnEditRoom.UseVisualStyleBackColor = false;
            btnEditRoom.Visible = false;
            btnEditRoom.Click += editRoom;
            // 
            // btnDeleteRoom
            // 
            btnDeleteRoom.BackColor = Color.FromArgb(255, 43, 43);
            btnDeleteRoom.Enabled = false;
            btnDeleteRoom.FlatAppearance.BorderSize = 0;
            btnDeleteRoom.FlatStyle = FlatStyle.Flat;
            btnDeleteRoom.Font = new Font("Segoe UI", 11F);
            btnDeleteRoom.ForeColor = SystemColors.Window;
            btnDeleteRoom.Location = new Point(300, 394);
            btnDeleteRoom.Name = "btnDeleteRoom";
            btnDeleteRoom.Size = new Size(223, 35);
            btnDeleteRoom.TabIndex = 21;
            btnDeleteRoom.Text = "Usuń salę";
            btnDeleteRoom.UseVisualStyleBackColor = false;
            btnDeleteRoom.Visible = false;
            btnDeleteRoom.Click += deleteRoom;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Segoe UI", 10F);
            lblRoomNumber.ForeColor = SystemColors.Window;
            lblRoomNumber.Location = new Point(29, 164);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(52, 19);
            lblRoomNumber.TabIndex = 23;
            lblRoomNumber.Text = "numer:";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 10F);
            lblRoomType.ForeColor = SystemColors.Window;
            lblRoomType.Location = new Point(29, 208);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(72, 19);
            lblRoomType.TabIndex = 24;
            lblRoomType.Text = "rodzaj sali:";
            // 
            // lblCapacity
            // 
            lblCapacity.AutoSize = true;
            lblCapacity.Font = new Font("Segoe UI", 10F);
            lblCapacity.ForeColor = SystemColors.Window;
            lblCapacity.Location = new Point(29, 253);
            lblCapacity.Name = "lblCapacity";
            lblCapacity.Size = new Size(78, 19);
            lblCapacity.TabIndex = 25;
            lblCapacity.Text = "pojemność:";
            // 
            // cmbRoomType
            // 
            cmbRoomType.Font = new Font("Segoe UI", 11F);
            cmbRoomType.FormattingEnabled = true;
            cmbRoomType.Items.AddRange(new object[] { "wykładowa", "komputerowa", "ćwiczeniowa" });
            cmbRoomType.Location = new Point(179, 203);
            cmbRoomType.Name = "cmbRoomType";
            cmbRoomType.Size = new Size(204, 28);
            cmbRoomType.TabIndex = 31;
            cmbRoomType.Text = "wykładowa";
            // 
            // numCapacity
            // 
            numCapacity.Font = new Font("Segoe UI", 11F);
            numCapacity.Location = new Point(179, 249);
            numCapacity.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            numCapacity.Name = "numCapacity";
            numCapacity.Size = new Size(204, 27);
            numCapacity.TabIndex = 32;
            // 
            // lblDepartmentAddress
            // 
            lblDepartmentAddress.AutoSize = true;
            lblDepartmentAddress.Font = new Font("Segoe UI", 11F);
            lblDepartmentAddress.ForeColor = SystemColors.Window;
            lblDepartmentAddress.Location = new Point(29, 122);
            lblDepartmentAddress.Name = "lblDepartmentAddress";
            lblDepartmentAddress.Size = new Size(221, 20);
            lblDepartmentAddress.TabIndex = 34;
            lblDepartmentAddress.Text = "44-100 Gliwice, ul. Kaszubska 23";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 11F);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(29, 91);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(281, 28);
            cmbDepartment.TabIndex = 33;
            cmbDepartment.Text = "Wydział Matematyki Stosowanej";
            cmbDepartment.SelectedIndexChanged += selectedDepartment;
            // 
            // tbxRoomNumber
            // 
            tbxRoomNumber.Font = new Font("Segoe UI", 11F);
            tbxRoomNumber.Location = new Point(179, 159);
            tbxRoomNumber.Name = "tbxRoomNumber";
            tbxRoomNumber.Size = new Size(204, 27);
            tbxRoomNumber.TabIndex = 35;
            // 
            // RoomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(tbxRoomNumber);
            Controls.Add(lblDepartmentAddress);
            Controls.Add(cmbDepartment);
            Controls.Add(numCapacity);
            Controls.Add(cmbRoomType);
            Controls.Add(lblCapacity);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNumber);
            Controls.Add(btnDeleteRoom);
            Controls.Add(btnEditRoom);
            Controls.Add(btnAddRoom);
            Controls.Add(lblRoomHeader);
            Name = "RoomForm";
            Text = "Sala";
            ((System.ComponentModel.ISupportInitialize)numCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRoomHeader;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private Button btnAddRoom;
        private Button btnEditRoom;
        private Button btnDeleteRoom;
        private Label lblRoomNumber;
        private Label lblRoomType;
        private Label lblCapacity;
        private ComboBox cmbRoomType;
        private NumericUpDown numCapacity;
        private Label lblDepartmentAddress;
        private ComboBox cmbDepartment;
        private TextBox tbxRoomNumber;
    }
}