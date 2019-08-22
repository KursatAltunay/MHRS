namespace MHRS.UIWinForm
{
    partial class RandevuDetay
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblHastaAdi = new System.Windows.Forms.Label();
            this.btnRandevu = new System.Windows.Forms.Button();
            this.cbGelmedi = new System.Windows.Forms.CheckBox();
            this.txtNot = new System.Windows.Forms.TextBox();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Adı:";
            // 
            // lblHastaAdi
            // 
            this.lblHastaAdi.AutoSize = true;
            this.lblHastaAdi.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblHastaAdi.Location = new System.Drawing.Point(110, 22);
            this.lblHastaAdi.Name = "lblHastaAdi";
            this.lblHastaAdi.Size = new System.Drawing.Size(0, 13);
            this.lblHastaAdi.TabIndex = 1;
            // 
            // btnRandevu
            // 
            this.btnRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRandevu.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnRandevu.Location = new System.Drawing.Point(244, 100);
            this.btnRandevu.Name = "btnRandevu";
            this.btnRandevu.Size = new System.Drawing.Size(96, 43);
            this.btnRandevu.TabIndex = 64;
            this.btnRandevu.Text = "Yeni Randevu";
            this.btnRandevu.UseVisualStyleBackColor = true;
            this.btnRandevu.Click += new System.EventHandler(this.btnRandevu_Click);
            // 
            // cbGelmedi
            // 
            this.cbGelmedi.AutoSize = true;
            this.cbGelmedi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbGelmedi.ForeColor = System.Drawing.Color.SeaGreen;
            this.cbGelmedi.Location = new System.Drawing.Point(26, 280);
            this.cbGelmedi.Name = "cbGelmedi";
            this.cbGelmedi.Size = new System.Drawing.Size(108, 17);
            this.cbGelmedi.TabIndex = 62;
            this.cbGelmedi.Text = "Hasta Gelmedi";
            this.cbGelmedi.UseVisualStyleBackColor = true;
            // 
            // txtNot
            // 
            this.txtNot.Location = new System.Drawing.Point(26, 49);
            this.txtNot.Multiline = true;
            this.txtNot.Name = "txtNot";
            this.txtNot.Size = new System.Drawing.Size(197, 209);
            this.txtNot.TabIndex = 65;
            // 
            // btnTamamla
            // 
            this.btnTamamla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTamamla.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTamamla.Location = new System.Drawing.Point(244, 149);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(96, 42);
            this.btnTamamla.TabIndex = 66;
            this.btnTamamla.Text = "Tamamla";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.SeaGreen;
            this.button1.Location = new System.Drawing.Point(244, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 46);
            this.button1.TabIndex = 67;
            this.button1.Text = "Reçete Yaz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RandevuDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(352, 309);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.txtNot);
            this.Controls.Add(this.btnRandevu);
            this.Controls.Add(this.cbGelmedi);
            this.Controls.Add(this.lblHastaAdi);
            this.Controls.Add(this.label1);
            this.Name = "RandevuDetay";
            this.Text = "RandevuDetay";
            this.Load += new System.EventHandler(this.RandevuDetay_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHastaAdi;
        private System.Windows.Forms.Button btnRandevu;
        private System.Windows.Forms.CheckBox cbGelmedi;
        private System.Windows.Forms.TextBox txtNot;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button button1;
    }
}