namespace Bai4_PhongKhamMini
{
    partial class frmLichHen
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
            label1 = new Label();
            label2 = new Label();
            dtpNgayGioHen = new DateTimePicker();
            txtTenBenhNhan = new TextBox();
            btnDatLich = new Button();
            lstLichHen = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 49);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 0;
            label1.Text = "Ngày giờ hẹn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 134);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 1;
            label2.Text = "Tên bệnh nhân";
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.Location = new Point(220, 44);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(250, 27);
            dtpNgayGioHen.TabIndex = 2;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(220, 127);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(465, 27);
            txtTenBenhNhan.TabIndex = 3;
            // 
            // btnDatLich
            // 
            btnDatLich.Location = new Point(358, 211);
            btnDatLich.Name = "btnDatLich";
            btnDatLich.Size = new Size(94, 29);
            btnDatLich.TabIndex = 4;
            btnDatLich.Text = "Đặt Lịch";
            btnDatLich.UseVisualStyleBackColor = true;
            btnDatLich.Click += btnDatLich_Click;
            // 
            // lstLichHen
            // 
            lstLichHen.FormattingEnabled = true;
            lstLichHen.Location = new Point(128, 255);
            lstLichHen.Name = "lstLichHen";
            lstLichHen.Size = new Size(557, 164);
            lstLichHen.TabIndex = 5;
            // 
            // frmLichHen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstLichHen);
            Controls.Add(btnDatLich);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(dtpNgayGioHen);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLichHen";
            Text = "frmLichHen";
            Load += frmLichHen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dtpNgayGioHen;
        private TextBox txtTenBenhNhan;
        private Button btnDatLich;
        private ListBox lstLichHen;
    }
}