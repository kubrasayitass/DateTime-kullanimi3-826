namespace DateTime_kulllanımı3_826
{
    partial class Form1
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
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblOdemeGunu = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(50, 55);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 0;
            this.btnHesapla.Text = "hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(193, 52);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(31, 13);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "Tarih";
            // 
            // lblOdemeGunu
            // 
            this.lblOdemeGunu.AutoSize = true;
            this.lblOdemeGunu.Location = new System.Drawing.Point(193, 81);
            this.lblOdemeGunu.Name = "lblOdemeGunu";
            this.lblOdemeGunu.Size = new System.Drawing.Size(66, 13);
            this.lblOdemeGunu.TabIndex = 2;
            this.lblOdemeGunu.Text = "ödeme günü";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(310, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblOdemeGunu);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnHesapla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblOdemeGunu;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

