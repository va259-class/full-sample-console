using Vektorel.Data.Concretes;
using Vektorel.Data.Managers;

namespace Vektorel.OOPSample
{
    public partial class FrmCreateCity : Form
    {
        public FrmCreateCity()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            erpNotify.Clear();
            if (string.IsNullOrEmpty(txtCity.Text))
            {
                erpNotify.SetError(txtCity, "Şehir boş geçilemez");
                return;
            }
            var success = DataRepository.AddCity(txtCity.Text);
            if (success)
            {
                txtCity.Clear();
                txtCity.Focus();
                return;
            }

            erpNotify.SetError(txtCity, "Şehir Eklenemedi");
        }

        private void txtCity_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }
    }
}
