using Vektorel.Data.Concretes;

namespace Vektorel.OOPSample
{
    public partial class FrmSetCapacity : Form
    {
        private County county;
        public FrmSetCapacity(City city, County county)
        {
            InitializeComponent();
            txtCity.Text = city.Name;
            txtCounty.Text = county.Name;
            this.county = county;
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            county.Capacity = (double)nudCapacity.Value;
        }
    }
}
