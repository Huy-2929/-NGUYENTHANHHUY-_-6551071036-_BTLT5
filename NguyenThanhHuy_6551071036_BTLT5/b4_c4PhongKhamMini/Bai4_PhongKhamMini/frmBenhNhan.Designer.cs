namespace Bai4_PhongKhamMini
{
    partial class frmBenhNhan
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
            txtHoTen = new TextBox();
            label2 = new Label();
            numTuoi = new NumericUpDown();
            label3 = new Label();
            txtTrieuChung = new TextBox();
            btnLuuTam = new Button();
            lstBenhNhan = new ListBox();
            ((System.ComponentModel.ISupportInitialize)numTuoi).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(104, 35);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(202, 28);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(483, 27);
            txtHoTen.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 85);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 2;
            label2.Text = "Tuổi";
            // 
            // numTuoi
            // 
            numTuoi.Location = new Point(202, 78);
            numTuoi.Name = "numTuoi";
            numTuoi.Size = new Size(76, 27);
            numTuoi.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(104, 143);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 4;
            label3.Text = "Triệu chứng";
            // 
            // txtTrieuChung
            // 
            txtTrieuChung.Location = new Point(202, 143);
            txtTrieuChung.Multiline = true;
            txtTrieuChung.Name = "txtTrieuChung";
            txtTrieuChung.Size = new Size(483, 108);
            txtTrieuChung.TabIndex = 5;
            // 
            // btnLuuTam
            // 
            btnLuuTam.Location = new Point(346, 271);
            btnLuuTam.Name = "btnLuuTam";
            btnLuuTam.Size = new Size(94, 29);
            btnLuuTam.TabIndex = 6;
            btnLuuTam.Text = "LƯU TẠM";
            btnLuuTam.UseVisualStyleBackColor = true;
            btnLuuTam.Click += btnLuuTam_Click;
            // 
            // lstBenhNhan
            // 
            lstBenhNhan.FormattingEnabled = true;
            lstBenhNhan.Location = new Point(104, 317);
            lstBenhNhan.Name = "lstBenhNhan";
            lstBenhNhan.Size = new Size(581, 104);
            lstBenhNhan.TabIndex = 7;
            // 
            // frmBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBenhNhan);
            Controls.Add(btnLuuTam);
            Controls.Add(txtTrieuChung);
            Controls.Add(label3);
            Controls.Add(numTuoi);
            Controls.Add(label2);
            Controls.Add(txtHoTen);
            Controls.Add(label1);
            Name = "frmBenhNhan";
            Text = "frmBenhNhan";
            Load += frmBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)numTuoi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtHoTen;
        private Label label2;
        private NumericUpDown numTuoi;
        private Label label3;
        private TextBox txtTrieuChung;
        private Button btnLuuTam;
        private ListBox lstBenhNhan;
    }
}