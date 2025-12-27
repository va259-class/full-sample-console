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
    public partial class FrmCreateCounty : Form
    {
        public FrmCreateCounty()
        {
            InitializeComponent();
        }

        private void FrmCreateCounty_Load(object sender, EventArgs e)
        {
            cmbCities.DataSource = DataRepository.Cities;
            cmbCities.DisplayMember = nameof(City.Name);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var selectedCity = cmbCities.SelectedItem as City;
            DataRepository.AddCounty(selectedCity, txtCounty.Text);
        }
    }
}
