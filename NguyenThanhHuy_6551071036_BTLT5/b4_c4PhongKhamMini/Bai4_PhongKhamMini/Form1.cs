namespace Bai4_PhongKhamMini
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }

        private void menuBenhNhan_Click(object sender, EventArgs e)
        {
            frmBenhNhan form = new frmBenhNhan();

            form.MdiParent = this;

            form.Show();
        }

        private void menuLichHen_Click(object sender, EventArgs e)
        {
            frmLichHen form = new frmLichHen();

            form.MdiParent = this;

            form.Show();
        }
    }
}
