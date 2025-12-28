namespace Vektorel.OOPSample
{
    partial class FrmSetCapacity
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
            btnNotify = new Button();
            nudCapacity = new NumericUpDown();
            txtCounty = new TextBox();
            txtCity = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCapacity).BeginInit();
            SuspendLayout();
            // 
            // btnNotify
            // 
            btnNotify.Location = new Point(107, 144);
            btnNotify.Name = "btnNotify";
            btnNotify.Size = new Size(92, 23);
            btnNotify.TabIndex = 13;
            btnNotify.Text = "Bildirim Yap";
            btnNotify.UseVisualStyleBackColor = true;
            btnNotify.Click += btnNotify_Click;
            // 
            // nudCapacity
            // 
            nudCapacity.Location = new Point(12, 115);
            nudCapacity.Maximum = new decimal(new int[] { 500000000, 0, 0, 0 });
            nudCapacity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCapacity.Name = "nudCapacity";
            nudCapacity.Size = new Size(187, 23);
            nudCapacity.TabIndex = 12;
            nudCapacity.TextAlign = HorizontalAlignment.Right;
            nudCapacity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCounty
            // 
            txtCounty.Location = new Point(12, 71);
            txtCounty.Name = "txtCounty";
            txtCounty.ReadOnly = true;
            txtCounty.Size = new Size(187, 23);
            txtCounty.TabIndex = 11;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 27);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(187, 23);
            txtCity.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 97);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 9;
            label3.Text = "Su Kapasitesi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 8;
            label2.Text = "İlçe";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 7;
            label1.Text = "Şehir";
            // 
            // FrmSetCapacity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(206, 182);
            Controls.Add(btnNotify);
            Controls.Add(nudCapacity);
            Controls.Add(txtCounty);
            Controls.Add(txtCity);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSetCapacity";
            Text = "Kapasite Bildirimi";
            ((System.ComponentModel.ISupportInitialize)nudCapacity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnNotify;
        private NumericUpDown nudCapacity;
        private TextBox txtCounty;
        private TextBox txtCity;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}