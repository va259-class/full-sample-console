namespace Vektorel.OOPSample
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            uygulamaToolStripMenuItem = new ToolStripMenuItem();
            mstAbout = new ToolStripMenuItem();
            mstExit = new ToolStripMenuItem();
            tanımlarToolStripMenuItem = new ToolStripMenuItem();
            mstCreateCity = new ToolStripMenuItem();
            mstCreateCounty = new ToolStripMenuItem();
            veriToolStripMenuItem = new ToolStripMenuItem();
            mstSetCapacity = new ToolStripMenuItem();
            mstSetPopulation = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uygulamaToolStripMenuItem, tanımlarToolStripMenuItem, veriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(584, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // uygulamaToolStripMenuItem
            // 
            uygulamaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mstAbout, mstExit });
            uygulamaToolStripMenuItem.Name = "uygulamaToolStripMenuItem";
            uygulamaToolStripMenuItem.Size = new Size(73, 20);
            uygulamaToolStripMenuItem.Text = "Uygulama";
            // 
            // mstAbout
            // 
            mstAbout.Name = "mstAbout";
            mstAbout.Size = new Size(124, 22);
            mstAbout.Text = "Hakkında";
            mstAbout.Click += mstAbout_Click;
            // 
            // mstExit
            // 
            mstExit.Name = "mstExit";
            mstExit.Size = new Size(124, 22);
            mstExit.Text = "Çıkış";
            mstExit.Click += mstExit_Click;
            // 
            // tanımlarToolStripMenuItem
            // 
            tanımlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mstCreateCity, mstCreateCounty });
            tanımlarToolStripMenuItem.Name = "tanımlarToolStripMenuItem";
            tanımlarToolStripMenuItem.Size = new Size(64, 20);
            tanımlarToolStripMenuItem.Text = "Tanımlar";
            // 
            // mstCreateCity
            // 
            mstCreateCity.Name = "mstCreateCity";
            mstCreateCity.Size = new Size(180, 22);
            mstCreateCity.Text = "Şehir Tanımı";
            mstCreateCity.Click += mstCreateCity_Click;
            // 
            // mstCreateCounty
            // 
            mstCreateCounty.Name = "mstCreateCounty";
            mstCreateCounty.Size = new Size(180, 22);
            mstCreateCounty.Text = "İlçe Tanımı";
            mstCreateCounty.Click += mstCreateCounty_Click;
            // 
            // veriToolStripMenuItem
            // 
            veriToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mstSetCapacity, mstSetPopulation });
            veriToolStripMenuItem.Name = "veriToolStripMenuItem";
            veriToolStripMenuItem.Size = new Size(38, 20);
            veriToolStripMenuItem.Text = "Veri";
            // 
            // mstSetCapacity
            // 
            mstSetCapacity.Name = "mstSetCapacity";
            mstSetCapacity.Size = new Size(180, 22);
            mstSetCapacity.Text = "Kapasite Bildirimi";
            mstSetCapacity.Click += mstSetCapacity_Click;
            // 
            // mstSetPopulation
            // 
            mstSetPopulation.Name = "mstSetPopulation";
            mstSetPopulation.Size = new Size(180, 22);
            mstSetPopulation.Text = "Nüfus Bildirimi";
            mstSetPopulation.Click += mstSetPopulation_Click;
            // 
            // FrmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 461);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMain";
            Text = "Su Koruma Enstitüsü";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uygulamaToolStripMenuItem;
        private ToolStripMenuItem mstAbout;
        private ToolStripMenuItem mstExit;
        private ToolStripMenuItem tanımlarToolStripMenuItem;
        private ToolStripMenuItem mstCreateCity;
        private ToolStripMenuItem mstCreateCounty;
        private ToolStripMenuItem veriToolStripMenuItem;
        private ToolStripMenuItem mstSetCapacity;
        private ToolStripMenuItem mstSetPopulation;
    }
}
