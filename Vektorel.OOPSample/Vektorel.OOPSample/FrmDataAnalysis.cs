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
            DataRepository.OnCountyUpdated += DataRepository_OnCountyUpdated;
        }

        private void DataRepository_OnCountyUpdated(City city)
        {
            var selected = lstCities.SelectedItem as City;
            if (selected.Id == city.Id)
            {
                RefreshSelectedCityInformation();
            }
        }

        private void FrmDataAnalysis_Load(object sender, EventArgs e)
        {
            lstCities.DataSource = DataRepository.Cities;
            lstCities.DisplayMember = nameof(City.Name);
        }

        private void lstCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshSelectedCityInformation();
        }

        private void RefreshSelectedCityInformation()
        {
            var selectedCity = lstCities.SelectedItem as City;
            txtCityName.Text = selectedCity.Name;
            txtPopulation.Text = selectedCity.Population.ToString();
            txtCapacity.Text = selectedCity.Capacity.ToString();

            dgvCounties.DataSource = null;
            dgvCounties.DataSource = selectedCity.GetCounties();
        }

        // veri olan hücrenin sağ tıklanması
        private void dgvCounties_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dgvCounties.ClearSelection();
                dgvCounties.Rows[e.RowIndex].Selected = true;
                dgvCounties.ContextMenuStrip = ctxGridRightClick;
                return;
            }

            else if (e.RowIndex < 0)
            {
                dgvCounties.ContextMenuStrip = null;
            }
        }

        // grid üzerinde herhangi bir yer
        private void dgvCounties_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var location = dgvCounties.HitTest(e.X, e.Y);
                if (location.Type == DataGridViewHitTestType.None)
                {
                    dgvCounties.ContextMenuStrip = null;
                }
            }
        }

        private void tsmCapacity_Click(object sender, EventArgs e)
        {
            var city = lstCities.SelectedItem as City;
            var county = dgvCounties.SelectedRows[0].DataBoundItem as County;

            var f = new FrmSetCapacity(city, county);
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void tsmPopulation_Click(object sender, EventArgs e)
        {
            var city = lstCities.SelectedItem as City;
            var county = dgvCounties.SelectedRows[0].DataBoundItem as County;

            var f = new FrmSetPopulation(city, county);
            f.MdiParent = this.MdiParent;
            f.Show();
        }
    }
}
