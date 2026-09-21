namespace ViecCanLamHangNgay
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
            txtCongViecMoi = new TextBox();
            label1 = new Label();
            btnThem = new Button();
            lstCongViec = new ListBox();
            cmsCongViec = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            cmsCongViec.SuspendLayout();
            SuspendLayout();
            // 
            // txtCongViecMoi
            // 
            txtCongViecMoi.Location = new Point(136, 12);
            txtCongViecMoi.Name = "txtCongViecMoi";
            txtCongViecMoi.Size = new Size(100, 23);
            txtCongViecMoi.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Công Việc Mới";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(257, 12);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(75, 23);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // lstCongViec
            // 
            lstCongViec.Dock = DockStyle.Right;
            lstCongViec.FormattingEnabled = true;
            lstCongViec.Location = new Point(338, 0);
            lstCongViec.Name = "lstCongViec";
            lstCongViec.Size = new Size(462, 450);
            lstCongViec.TabIndex = 3;
            // 
            // cmsCongViec
            // 
            cmsCongViec.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            cmsCongViec.Name = "cmsCongViec";
            cmsCongViec.Size = new Size(190, 70);
            cmsCongViec.Opening += cmsCongViec_Opening;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(189, 22);
            toolStripMenuItem1.Text = "Đánh dấu hoàn thành";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(189, 22);
            toolStripMenuItem2.Text = "Xóa công việc này";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(189, 22);
            toolStripMenuItem3.Text = "Xóa tất cả";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstCongViec);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(txtCongViecMoi);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            cmsCongViec.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCongViecMoi;
        private Label label1;
        private Button btnThem;
        private ListBox lstCongViec;
        private ContextMenuStrip cmsCongViec;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
    }
}
