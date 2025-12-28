namespace Vektorel.OOPSample
{
    partial class FrmDataAnalysis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            lstCities = new ListBox();
            label1 = new Label();
            label2 = new Label();
            txtCityName = new TextBox();
            txtPopulation = new TextBox();
            groupBox1 = new GroupBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvCounties = new DataGridView();
            tabPage2 = new TabPage();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ctxGridRightClick = new ContextMenuStrip(components);
            tsmCapacity = new ToolStripMenuItem();
            tsmPopulation = new ToolStripMenuItem();
            label3 = new Label();
            txtCapacity = new TextBox();
            groupBox1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCounties).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ctxGridRightClick.SuspendLayout();
            SuspendLayout();
            // 
            // lstCities
            // 
            lstCities.FormattingEnabled = true;
            lstCities.ItemHeight = 15;
            lstCities.Location = new Point(12, 12);
            lstCities.Name = "lstCities";
            lstCities.Size = new Size(131, 334);
            lstCities.TabIndex = 0;
            lstCities.SelectedIndexChanged += lstCities_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(152, 16);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Şehir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 16);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Nüfus";
            // 
            // txtCityName
            // 
            txtCityName.Location = new Point(200, 12);
            txtCityName.Name = "txtCityName";
            txtCityName.ReadOnly = true;
            txtCityName.Size = new Size(88, 23);
            txtCityName.TabIndex = 3;
            // 
            // txtPopulation
            // 
            txtPopulation.Location = new Point(339, 13);
            txtPopulation.Name = "txtPopulation";
            txtPopulation.ReadOnly = true;
            txtPopulation.Size = new Size(88, 23);
            txtPopulation.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tabControl1);
            groupBox1.Location = new Point(149, 41);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(463, 305);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "İlçe Bilgileri";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(6, 22);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(451, 277);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvCounties);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(443, 249);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Genel Bilgiler";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvCounties
            // 
            dgvCounties.AllowUserToAddRows = false;
            dgvCounties.AllowUserToDeleteRows = false;
            dgvCounties.AllowUserToResizeColumns = false;
            dgvCounties.AllowUserToResizeRows = false;
            dgvCounties.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCounties.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCounties.Location = new Point(6, 6);
            dgvCounties.MultiSelect = false;
            dgvCounties.Name = "dgvCounties";
            dgvCounties.ReadOnly = true;
            dgvCounties.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCounties.Size = new Size(431, 237);
            dgvCounties.TabIndex = 0;
            dgvCounties.CellMouseDown += dgvCounties_CellMouseDown;
            dgvCounties.MouseDown += dgvCounties_MouseDown;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(chart1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(443, 249);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Grafik";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(6, 6);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chart1.Series.Add(series1);
            chart1.Size = new Size(431, 237);
            chart1.TabIndex = 0;
            chart1.Text = "chart1";
            // 
            // ctxGridRightClick
            // 
            ctxGridRightClick.Items.AddRange(new ToolStripItem[] { tsmCapacity, tsmPopulation });
            ctxGridRightClick.Name = "ctxGridRightClick";
            ctxGridRightClick.Size = new Size(172, 48);
            // 
            // tsmCapacity
            // 
            tsmCapacity.Name = "tsmCapacity";
            tsmCapacity.Size = new Size(171, 22);
            tsmCapacity.Text = "Su Kapasitesi Girişi";
            tsmCapacity.Click += tsmCapacity_Click;
            // 
            // tsmPopulation
            // 
            tsmPopulation.Name = "tsmPopulation";
            tsmPopulation.Size = new Size(171, 22);
            tsmPopulation.Text = "Nüfus Bildirimi";
            tsmPopulation.Click += tsmPopulation_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(433, 16);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 6;
            label3.Text = "Kapasite";
            // 
            // txtCapacity
            // 
            txtCapacity.Location = new Point(490, 12);
            txtCapacity.Name = "txtCapacity";
            txtCapacity.ReadOnly = true;
            txtCapacity.Size = new Size(88, 23);
            txtCapacity.TabIndex = 7;
            // 
            // FrmDataAnalysis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 355);
            Controls.Add(txtCapacity);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(txtPopulation);
            Controls.Add(txtCityName);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstCities);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmDataAnalysis";
            Text = "Veri Analizi";
            Load += FrmDataAnalysis_Load;
            groupBox1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCounties).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ctxGridRightClick.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCities;
        private Label label1;
        private Label label2;
        private TextBox txtCityName;
        private TextBox txtPopulation;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private DataGridView dgvCounties;
        private TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ContextMenuStrip ctxGridRightClick;
        private ToolStripMenuItem tsmCapacity;
        private ToolStripMenuItem tsmPopulation;
        private Label label3;
        private TextBox txtCapacity;
    }
}