namespace dpiotrowski_lab2
{
    partial class ReservationForm
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
            lblReservationHeader = new Label();
            cmbDepartment = new ComboBox();
            lblDepartmentAddress = new Label();
            lblRoomType = new Label();
            cmbRoom = new ComboBox();
            lblRoomCapacity = new Label();
            cmbEmployee = new ComboBox();
            lblFrom = new Label();
            dtpFrom = new DateTimePicker();
            dtpTo = new DateTimePicker();
            lblTo = new Label();
            dtpDate = new DateTimePicker();
            lblDate = new Label();
            btnAddReservation = new Button();
            btnEditReservation = new Button();
            btnDeleteReservation = new Button();
            SuspendLayout();
            // 
            // lblReservationHeader
            // 
            lblReservationHeader.AutoSize = true;
            lblReservationHeader.Font = new Font("Segoe UI", 19F);
            lblReservationHeader.ForeColor = SystemColors.Window;
            lblReservationHeader.Location = new Point(29, 32);
            lblReservationHeader.Name = "lblReservationHeader";
            lblReservationHeader.Size = new Size(142, 36);
            lblReservationHeader.TabIndex = 0;
            lblReservationHeader.Text = "Rezerwacja";
            // 
            // cmbDepartment
            // 
            cmbDepartment.Font = new Font("Segoe UI", 11F);
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(29, 107);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(281, 28);
            cmbDepartment.TabIndex = 4;
            cmbDepartment.Text = "Wydział Matematyki Stosowanej";
            // 
            // lblDepartmentAddress
            // 
            lblDepartmentAddress.AutoSize = true;
            lblDepartmentAddress.Font = new Font("Segoe UI", 11F);
            lblDepartmentAddress.ForeColor = SystemColors.Window;
            lblDepartmentAddress.Location = new Point(29, 138);
            lblDepartmentAddress.Name = "lblDepartmentAddress";
            lblDepartmentAddress.Size = new Size(221, 20);
            lblDepartmentAddress.TabIndex = 8;
            lblDepartmentAddress.Text = "44-100 Gliwice, ul. Kaszubska 23";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Segoe UI", 11F);
            lblRoomType.ForeColor = SystemColors.Window;
            lblRoomType.Location = new Point(29, 210);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(113, 20);
            lblRoomType.TabIndex = 10;
            lblRoomType.Text = "sala wykładowa";
            // 
            // cmbRoom
            // 
            cmbRoom.Font = new Font("Segoe UI", 11F);
            cmbRoom.FormattingEnabled = true;
            cmbRoom.Location = new Point(29, 179);
            cmbRoom.Name = "cmbRoom";
            cmbRoom.Size = new Size(281, 28);
            cmbRoom.TabIndex = 9;
            cmbRoom.Text = "406";
            // 
            // lblRoomCapacity
            // 
            lblRoomCapacity.AutoSize = true;
            lblRoomCapacity.Font = new Font("Segoe UI", 11F);
            lblRoomCapacity.ForeColor = SystemColors.Window;
            lblRoomCapacity.Location = new Point(29, 230);
            lblRoomCapacity.Name = "lblRoomCapacity";
            lblRoomCapacity.Size = new Size(79, 20);
            lblRoomCapacity.TabIndex = 11;
            lblRoomCapacity.Text = "120 miejsc";
            // 
            // cmbEmployee
            // 
            cmbEmployee.Font = new Font("Segoe UI", 11F);
            cmbEmployee.FormattingEnabled = true;
            cmbEmployee.Location = new Point(29, 272);
            cmbEmployee.Name = "cmbEmployee";
            cmbEmployee.Size = new Size(281, 28);
            cmbEmployee.TabIndex = 12;
            cmbEmployee.Text = "tech. Dawid Piotrowski";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 10F);
            lblFrom.ForeColor = SystemColors.Window;
            lblFrom.Location = new Point(463, 112);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(28, 19);
            lblFrom.TabIndex = 13;
            lblFrom.Text = "od:";
            // 
            // dtpFrom
            // 
            dtpFrom.CalendarFont = new Font("Segoe UI", 11F);
            dtpFrom.Font = new Font("Segoe UI", 11F);
            dtpFrom.Format = DateTimePickerFormat.Time;
            dtpFrom.Location = new Point(524, 108);
            dtpFrom.Name = "dtpFrom";
            dtpFrom.Size = new Size(200, 27);
            dtpFrom.TabIndex = 14;
            // 
            // dtpTo
            // 
            dtpTo.CalendarFont = new Font("Segoe UI", 11F);
            dtpTo.Font = new Font("Segoe UI", 11F);
            dtpTo.Format = DateTimePickerFormat.Time;
            dtpTo.Location = new Point(524, 158);
            dtpTo.Name = "dtpTo";
            dtpTo.Size = new Size(200, 27);
            dtpTo.TabIndex = 16;
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 10F);
            lblTo.ForeColor = SystemColors.Window;
            lblTo.Location = new Point(463, 162);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(28, 19);
            lblTo.TabIndex = 15;
            lblTo.Text = "do:";
            // 
            // dtpDate
            // 
            dtpDate.CalendarFont = new Font("Segoe UI", 11F);
            dtpDate.Font = new Font("Segoe UI", 11F);
            dtpDate.Format = DateTimePickerFormat.Short;
            dtpDate.Location = new Point(524, 205);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(200, 27);
            dtpDate.TabIndex = 18;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 10F);
            lblDate.ForeColor = SystemColors.Window;
            lblDate.Location = new Point(463, 211);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(44, 19);
            lblDate.TabIndex = 17;
            lblDate.Text = "dzień:";
            // 
            // btnAddReservation
            // 
            btnAddReservation.BackColor = Color.FromArgb(43, 92, 255);
            btnAddReservation.FlatAppearance.BorderSize = 0;
            btnAddReservation.FlatStyle = FlatStyle.Flat;
            btnAddReservation.Font = new Font("Segoe UI", 11F);
            btnAddReservation.ForeColor = SystemColors.Window;
            btnAddReservation.Location = new Point(300, 374);
            btnAddReservation.Name = "btnAddReservation";
            btnAddReservation.Size = new Size(223, 35);
            btnAddReservation.TabIndex = 19;
            btnAddReservation.Text = "Dodaj rezerwację";
            btnAddReservation.UseVisualStyleBackColor = false;
            // 
            // btnEditReservation
            // 
            btnEditReservation.BackColor = Color.FromArgb(43, 92, 255);
            btnEditReservation.Enabled = false;
            btnEditReservation.FlatAppearance.BorderSize = 0;
            btnEditReservation.FlatStyle = FlatStyle.Flat;
            btnEditReservation.Font = new Font("Segoe UI", 11F);
            btnEditReservation.ForeColor = SystemColors.Window;
            btnEditReservation.Location = new Point(300, 353);
            btnEditReservation.Name = "btnEditReservation";
            btnEditReservation.Size = new Size(223, 35);
            btnEditReservation.TabIndex = 20;
            btnEditReservation.Text = "Edytuj rezerwację";
            btnEditReservation.UseVisualStyleBackColor = false;
            btnEditReservation.Visible = false;
            // 
            // btnDeleteReservation
            // 
            btnDeleteReservation.BackColor = Color.FromArgb(255, 43, 43);
            btnDeleteReservation.Enabled = false;
            btnDeleteReservation.FlatAppearance.BorderSize = 0;
            btnDeleteReservation.FlatStyle = FlatStyle.Flat;
            btnDeleteReservation.Font = new Font("Segoe UI", 11F);
            btnDeleteReservation.ForeColor = SystemColors.Window;
            btnDeleteReservation.Location = new Point(300, 394);
            btnDeleteReservation.Name = "btnDeleteReservation";
            btnDeleteReservation.Size = new Size(223, 35);
            btnDeleteReservation.TabIndex = 21;
            btnDeleteReservation.Text = "Usuń rezerwację";
            btnDeleteReservation.UseVisualStyleBackColor = false;
            btnDeleteReservation.Visible = false;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(800, 450);
            Controls.Add(btnDeleteReservation);
            Controls.Add(btnEditReservation);
            Controls.Add(btnAddReservation);
            Controls.Add(dtpDate);
            Controls.Add(lblDate);
            Controls.Add(dtpTo);
            Controls.Add(lblTo);
            Controls.Add(dtpFrom);
            Controls.Add(lblFrom);
            Controls.Add(cmbEmployee);
            Controls.Add(lblRoomCapacity);
            Controls.Add(lblRoomType);
            Controls.Add(cmbRoom);
            Controls.Add(lblDepartmentAddress);
            Controls.Add(cmbDepartment);
            Controls.Add(lblReservationHeader);
            Name = "ReservationForm";
            Text = "Rezerwacja";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReservationHeader;
        private ComboBox cmbDepartment;
        private Label lblDepartmentAddress;
        private Label lblRoomType;
        private ComboBox cmbRoom;
        private Label lblRoomCapacity;
        private ComboBox cmbEmployee;
        private Label lblFrom;
        private DateTimePicker dtpFrom;
        private DateTimePicker dtpTo;
        private Label lblTo;
        private DateTimePicker dtpDate;
        private Label lblDate;
        private Button btnAddReservation;
        private Button btnEditReservation;
        private Button btnDeleteReservation;
    }
}