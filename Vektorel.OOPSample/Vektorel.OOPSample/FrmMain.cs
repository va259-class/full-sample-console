namespace Vektorel.OOPSample
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mstAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu uygulama Vektörel Laboratuvarlarýnda itina ile hazýrlandý.");
        }

        private void mstExit_Click(object sender, EventArgs e)
        {
            var dr = MessageBox.Show("Uygulamadan çýkýþ yapýlýyor. Onaylýyor musunuz?", "Çýkýþ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mstCreateCity_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCreateCity>();
        }

        private void mstCreateCounty_Click(object sender, EventArgs e)
        {
            OpenForm<FrmCreateCounty>();
        }

        private void mstDataAnalysis_Click(object sender, EventArgs e)
        {
            OpenForm<FrmDataAnalysis>();
        }

        private void OpenForm<T>() where T : Form
        {
            var f = Activator.CreateInstance<T>(); // var f =  new T();
            f.MdiParent = this;
            f.Show();
        }
    }
}
