namespace MHRS.UIWinForm
{
    partial class DoktorCalismaGunu
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
            this.pnlRandevular = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(74, 15);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);
            this.dtpTarih.TabIndex = 43;
            this.dtpTarih.ValueChanged += new System.EventHandler(this.dtpTarih_ValueChanged);
            // 
            // pnlRandevular
            // 
            this.pnlRandevular.Location = new System.Drawing.Point(12, 41);
            this.pnlRandevular.Name = "pnlRandevular";
            this.pnlRandevular.Size = new System.Drawing.Size(314, 125);
            this.pnlRandevular.TabIndex = 62;
            // 
            // DoktorCalismaGunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(338, 263);
            this.Controls.Add(this.pnlRandevular);
            this.Controls.Add(this.dtpTarih);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "DoktorCalismaGunu";
            this.Text = "DoktorCalismaGunu";
            this.Load += new System.EventHandler(this.DoktorCalismaGunu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel pnlRandevular;
    }
}