namespace MHRS.UIWinForm
{
    partial class DoktorRandevuEkle
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
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.pnlBosRandevu = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(80, 12);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 0;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // pnlBosRandevu
            // 
            this.pnlBosRandevu.Location = new System.Drawing.Point(25, 51);
            this.pnlBosRandevu.Name = "pnlBosRandevu";
            this.pnlBosRandevu.Size = new System.Drawing.Size(313, 152);
            this.pnlBosRandevu.TabIndex = 1;
            // 
            // DoktorRandevuEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(362, 233);
            this.Controls.Add(this.pnlBosRandevu);
            this.Controls.Add(this.dtpTarih);
            this.Name = "DoktorRandevuEkle";
            this.Text = "DoktorRandevuEkle";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel pnlBosRandevu;
    }
}