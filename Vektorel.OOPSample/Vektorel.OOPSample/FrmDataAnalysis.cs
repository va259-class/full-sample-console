using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vektorel.Data.Concretes;
using Vektorel.Data.Managers;

namespace Vektorel.OOPSample
{
    public partial class FrmDataAnalysis : Form
    {
        public FrmDataAnalysis()
        {
            InitializeComponent();
        }

        private void FrmDataAnalysis_Load(object sender, EventArgs e)
        {
            lstCities.DataSource = DataRepository.Cities;
            lstCities.DisplayMember = nameof(City.Name);
        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedCity = lstCities.SelectedItem as City;
            txtCityName.Text = selectedCity.Name;
            txtPopulation.Text = selectedCity.Population.ToString();

            dgvCounties.DataSource = null;
            dgvCounties.DataSource = selectedCity.Counties;
        }
    }
}
