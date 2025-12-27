namespace Vektorel.OOPSample
{
    partial class FrmCreateCounty
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
            txtCounty = new TextBox();
            label1 = new Label();
            button1 = new Button();
            cmbCities = new ComboBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtCounty
            // 
            txtCounty.Location = new Point(12, 71);
            txtCounty.Name = "txtCounty";
            txtCounty.Size = new Size(192, 23);
            txtCounty.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 4;
            label1.Text = "Şehir";
            // 
            // button1
            // 
            button1.Location = new Point(129, 100);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = true;
            // 
            // cmbCities
            // 
            cmbCities.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCities.FormattingEnabled = true;
            cmbCities.Location = new Point(12, 27);
            cmbCities.Name = "cmbCities";
            cmbCities.Size = new Size(192, 23);
            cmbCities.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 7;
            label2.Text = "İlçe";
            // 
            // FrmCreateCounty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 136);
            Controls.Add(label2);
            Controls.Add(cmbCities);
            Controls.Add(txtCounty);
            Controls.Add(label1);
            Controls.Add(button1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCreateCounty";
            Text = "İlçe Tanımı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCounty;
        private Label label1;
        private Button button1;
        private ComboBox cmbCities;
        private Label label2;
    }
}