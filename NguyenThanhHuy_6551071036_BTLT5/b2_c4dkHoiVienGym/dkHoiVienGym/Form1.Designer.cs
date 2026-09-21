namespace dkHoiVienGym
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboGoiTap = new ComboBox();
            numSoBuoiTuan = new NumericUpDown();
            btnDangKy = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).BeginInit();
            SuspendLayout();
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(0, 0);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(100, 23);
            txtHoTen.TabIndex = 0;
            toolTip1.SetToolTip(txtHoTen, "Nhập Họ Tên học viên");
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(92, 40);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(100, 23);
            txtSDT.TabIndex = 1;
            toolTip1.SetToolTip(txtSDT, "Nhập đúng 10 chữ số, không chứa khoảng trắng hay ký tự đặc biệt");
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(100, 23);
            txtEmail.TabIndex = 2;
            toolTip1.SetToolTip(txtEmail, "Email dùng để nhận thông báo lịch tập và khuyến mãi");
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(276, 76);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(200, 23);
            dtpNgaySinh.TabIndex = 3;
            toolTip1.SetToolTip(dtpNgaySinh, "Ngày sinh");
            // 
            // cboGoiTap
            // 
            cboGoiTap.FormattingEnabled = true;
            cboGoiTap.Items.AddRange(new object[] { "Basis", "Vip", "Premium" });
            cboGoiTap.Location = new Point(276, 193);
            cboGoiTap.Name = "cboGoiTap";
            cboGoiTap.Size = new Size(121, 23);
            cboGoiTap.TabIndex = 4;
            toolTip1.SetToolTip(cboGoiTap, "Gói VIP và Premium có kèm");
            // 
            // numSoBuoiTuan
            // 
            numSoBuoiTuan.Location = new Point(466, 177);
            numSoBuoiTuan.Maximum = new decimal(new int[] { 7, 0, 0, 0 });
            numSoBuoiTuan.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSoBuoiTuan.Name = "numSoBuoiTuan";
            numSoBuoiTuan.Size = new Size(120, 23);
            numSoBuoiTuan.TabIndex = 5;
            toolTip1.SetToolTip(numSoBuoiTuan, "Số buổi/tuần");
            numSoBuoiTuan.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnDangKy
            // 
            btnDangKy.Location = new Point(428, 253);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(75, 23);
            btnDangKy.TabIndex = 6;
            btnDangKy.Text = "Đăng Ký";
            btnDangKy.UseVisualStyleBackColor = true;
            btnDangKy.Click += btnDangKy_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDangKy);
            Controls.Add(numSoBuoiTuan);
            Controls.Add(cboGoiTap);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numSoBuoiTuan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboGoiTap;
        private NumericUpDown numSoBuoiTuan;
        private Button btnDangKy;
        private ToolTip toolTip1;
    }
}
