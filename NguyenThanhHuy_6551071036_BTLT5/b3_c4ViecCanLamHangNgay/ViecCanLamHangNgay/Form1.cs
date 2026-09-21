namespace ViecCanLamHangNgay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lstCongViec.ContextMenuStrip = cmsCongViec;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtCongViecMoi.Text))
            {
                lstCongViec.Items.Add(txtCongViecMoi.Text);
                txtCongViecMoi.Clear();
                txtCongViecMoi.Focus();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                string congViec = lstCongViec.SelectedItem.ToString();

                if (!congViec.StartsWith("[Hoàn thành] "))
                {
                    int index = lstCongViec.SelectedIndex;
                    lstCongViec.Items[index] = "[Hoàn thành] " + congViec;
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (lstCongViec.SelectedItem != null)
            {
                lstCongViec.Items.Remove(lstCongViec.SelectedItem);
            }
            else
            {
                MessageBox.Show(
                    "Vui lòng chọn công việc trước khi xóa!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Bạn có chắc muốn xóa tất cả công việc không?",
        "Xác nhận",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                lstCongViec.Items.Clear();
            }
        }

        private void cmsCongViec_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }
    }
}
