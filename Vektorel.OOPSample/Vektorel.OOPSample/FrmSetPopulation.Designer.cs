namespace Vektorel.OOPSample
{
    partial class FrmSetPopulation
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtCity = new TextBox();
            txtCounty = new TextBox();
            nudPopulation = new NumericUpDown();
            btnNotify = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPopulation).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "Şehir";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 53);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "İlçe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 97);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Nüfus";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(8, 27);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(187, 23);
            txtCity.TabIndex = 3;
            // 
            // txtCounty
            // 
            txtCounty.Location = new Point(8, 71);
            txtCounty.Name = "txtCounty";
            txtCounty.ReadOnly = true;
            txtCounty.Size = new Size(187, 23);
            txtCounty.TabIndex = 4;
            // 
            // nudPopulation
            // 
            nudPopulation.Location = new Point(8, 115);
            nudPopulation.Maximum = new decimal(new int[] { 5000000, 0, 0, 0 });
            nudPopulation.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudPopulation.Name = "nudPopulation";
            nudPopulation.Size = new Size(187, 23);
            nudPopulation.TabIndex = 5;
            nudPopulation.TextAlign = HorizontalAlignment.Right;
            nudPopulation.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnNotify
            // 
            btnNotify.Location = new Point(103, 144);
            btnNotify.Name = "btnNotify";
            btnNotify.Size = new Size(92, 23);
            btnNotify.TabIndex = 6;
            btnNotify.Text = "Bildirim Yap";
            btnNotify.UseVisualStyleBackColor = true;
            btnNotify.Click += btnNotify_Click;
            // 
            // FrmSetPopulation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(203, 183);
            Controls.Add(btnNotify);
            Controls.Add(nudPopulation);
            Controls.Add(txtCounty);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSetPopulation";
            Text = "Nüfus Bildirimi";
            ((System.ComponentModel.ISupportInitialize)nudPopulation).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtCity;
        private TextBox txtCounty;
        private NumericUpDown nudPopulation;
        private Button btnNotify;
    }
}