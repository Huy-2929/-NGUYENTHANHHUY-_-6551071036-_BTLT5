using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai4_PhongKhamMini
{
    public partial class frmLichHen : Form
    {
        private List<string> danhSachLichHen = new List<string>();
        public frmLichHen()
        {
            InitializeComponent();
        }

        private void frmLichHen_Load(object sender, EventArgs e)
        {

        }

        private void btnDatLich_Click(object sender, EventArgs e)
        {
            string lichHen =
            txtTenBenhNhan.Text +
            " - " +
            dtpNgayGioHen.Value.ToString("dd/MM/yyyy HH:mm");

                danhSachLichHen.Add(lichHen);

                lstLichHen.Items.Add(lichHen);

                txtTenBenhNhan.Clear();
        }
    }
}
