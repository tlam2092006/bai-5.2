namespace bai_5._2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private Label lblTitle;
        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblGender;
        private RadioButton rdoMale;
        private RadioButton rdoFemale;
        private Label lblCourse;
        private ComboBox cboCourse;
        private Label lblBirthDate;
        private DateTimePicker dtpBirthDate;
        private Label lblPhone;
        private MaskedTextBox mtxtPhone;
        private CheckBox chkUpdates;
        private Button btnRegister;

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
            lblTitle = new Label();
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblGender = new Label();
            rdoMale = new RadioButton();
            rdoFemale = new RadioButton();
            lblCourse = new Label();
            cboCourse = new ComboBox();
            lblBirthDate = new Label();
            dtpBirthDate = new DateTimePicker();
            lblPhone = new Label();
            mtxtPhone = new MaskedTextBox();
            chkUpdates = new CheckBox();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(24, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(520, 38);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHIẾU ĐĂNG KÝ KHÓA HỌC";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(48, 82);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(78, 20);
            lblFullName.TabIndex = 1;
            lblFullName.Text = "Họ và tên:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(160, 78);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(340, 27);
            txtFullName.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(48, 132);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(64, 20);
            lblGender.TabIndex = 3;
            lblGender.Text = "Giới tính:";
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Location = new Point(160, 130);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(65, 24);
            rdoMale.TabIndex = 4;
            rdoMale.TabStop = true;
            rdoMale.Text = "Nam";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Location = new Point(250, 130);
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Size = new Size(53, 24);
            rdoFemale.TabIndex = 5;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Nữ";
            rdoFemale.UseVisualStyleBackColor = true;
            // 
            // lblCourse
            // 
            lblCourse.AutoSize = true;
            lblCourse.Location = new Point(48, 182);
            lblCourse.Name = "lblCourse";
            lblCourse.Size = new Size(68, 20);
            lblCourse.TabIndex = 6;
            lblCourse.Text = "Khóa học:";
            // 
            // cboCourse
            // 
            cboCourse.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(160, 178);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(340, 28);
            cboCourse.TabIndex = 7;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Location = new Point(48, 232);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(75, 20);
            lblBirthDate.TabIndex = 8;
            lblBirthDate.Text = "Ngày sinh:";
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.Format = DateTimePickerFormat.Short;
            dtpBirthDate.Location = new Point(160, 228);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(200, 27);
            dtpBirthDate.TabIndex = 9;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(48, 282);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(95, 20);
            lblPhone.TabIndex = 10;
            lblPhone.Text = "Số điện thoại:";
            // 
            // mtxtPhone
            // 
            mtxtPhone.Location = new Point(160, 278);
            mtxtPhone.Mask = "(000) 000-0000";
            mtxtPhone.Name = "mtxtPhone";
            mtxtPhone.Size = new Size(200, 27);
            mtxtPhone.TabIndex = 11;
            // 
            // chkUpdates
            // 
            chkUpdates.AutoSize = true;
            chkUpdates.Location = new Point(160, 328);
            chkUpdates.Name = "chkUpdates";
            chkUpdates.Size = new Size(222, 24);
            chkUpdates.TabIndex = 12;
            chkUpdates.Text = "Nhận thông tin khóa học mới";
            chkUpdates.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(220, 378);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(140, 38);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Đăng ký";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 445);
            Controls.Add(btnRegister);
            Controls.Add(chkUpdates);
            Controls.Add(mtxtPhone);
            Controls.Add(lblPhone);
            Controls.Add(dtpBirthDate);
            Controls.Add(lblBirthDate);
            Controls.Add(cboCourse);
            Controls.Add(lblCourse);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(lblGender);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Controls.Add(lblTitle);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng ký khóa học";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
