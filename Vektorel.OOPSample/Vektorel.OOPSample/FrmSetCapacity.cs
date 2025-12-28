using Vektorel.Data.Concretes;
using Vektorel.Data.Managers;

namespace Vektorel.OOPSample
{
    public partial class FrmSetCapacity : Form
    {
        private County county;
        private City city;
        public FrmSetCapacity(City city, County county)
        {
            InitializeComponent();
            txtCity.Text = city.Name;
            txtCounty.Text = county.Name;
            this.county = county;
            this.city = city;
            if (county.Capacity > 0)
            {
                nudCapacity.Value = (decimal)county.Capacity;
            }
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            DataRepository.UpdateCountyCapacity(city, county, (double)nudCapacity.Value);
        }
    }
}
