namespace Vektorel.OOPSample
{
    partial class FrmCreateCity
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
            btnAdd = new Button();
            label1 = new Label();
            txtCity = new TextBox();
            erpNotify = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)erpNotify).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(129, 56);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 1;
            label1.Text = "Şehir";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(12, 27);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(192, 23);
            txtCity.TabIndex = 2;
            txtCity.KeyDown += txtCity_KeyDown;
            // 
            // erpNotify
            // 
            erpNotify.ContainerControl = this;
            // 
            // FrmCreateCity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(221, 96);
            Controls.Add(txtCity);
            Controls.Add(label1);
            Controls.Add(btnAdd);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmCreateCity";
            Text = "Şehir Tanımı";
            ((System.ComponentModel.ISupportInitialize)erpNotify).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Label label1;
        private TextBox txtCity;
        private ErrorProvider erpNotify;
    }
}