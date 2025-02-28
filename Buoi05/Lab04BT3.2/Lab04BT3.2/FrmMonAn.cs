namespace Lab04BT3._2
{
    public partial class FrmMonAn : Form
    {
        public FrmMonAn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var tenMon = txtTenMon.Text.Trim();
            if (!lstThucDon.Items.Contains(tenMon))
            {
                lstThucDon.Items.Add(tenMon);
                txtTenMon.Clear();
            }
        }

        private void txtTenMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                btnThem_Click(sender, e);
            }
        }

        private void txtTenMon_KeyUp(object sender, KeyEventArgs e)
        {
            btnThem.Enabled = txtTenMon.Text.Trim().Length > 0;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            foreach (var item in lstThucDon.SelectedItems)
            {
                if (!lstChon.Items.Contains(item))
                {
                    lstChon.Items.Add(item);
                }
            }
        }

        private void btnChonTatCa_Click(object sender, EventArgs e)
        {
            lstChon.Items.Clear();
            foreach (var item in lstThucDon.Items)
            {
                lstChon.Items.Add(item);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            while (lstChon.SelectedItems.Count > 0)
            {
                lstChon.Items.Remove(lstChon.SelectedItem);
            }
        }

        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            lstChon.Items.Clear();
        }
    }
}
