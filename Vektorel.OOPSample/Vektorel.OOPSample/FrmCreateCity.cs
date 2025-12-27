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
            var c = new City();
            c.Name = txtCity.Text;

            DataRepository.Cities.Add(c);
        }
    }
}
