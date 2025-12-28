using Vektorel.Data.Concretes;
using Vektorel.Data.Managers;

namespace Vektorel.OOPSample
{
    public partial class FrmSetPopulation : Form
    {
        private County county;
        private City city;
        public FrmSetPopulation(City city, County county)
        {
            InitializeComponent();
            txtCity.Text = city.Name;
            txtCounty.Text = county.Name;
            this.county = county;
            this.city = city;
            if (county.Population > 0)
            {
                nudPopulation.Value = county.Population; 
            }
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            DataRepository.UpdateCountyPopulation(city, county, (uint)nudPopulation.Value);
        }
    }
}
