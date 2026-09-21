using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4_PhongKhamMini
{
    public partial class frmBenhNhan : Form
    {
        private List<string> danhSachBenhNhan = new List<string>();
        public frmBenhNhan()
        {
            InitializeComponent();
        }

        private void frmBenhNhan_Load(object sender, EventArgs e)
        { 
        }
        private void btnLuuTam_Click(object sender, EventArgs e)
        {
            string thongTin =
        txtHoTen.Text +
        " - " +
        numTuoi.Value +
        " tuổi - " +
        txtTrieuChung.Text;

            danhSachBenhNhan.Add(thongTin);

            lstBenhNhan.Items.Add(thongTin);

            txtHoTen.Clear();
            txtTrieuChung.Clear();
        }
    }
}

