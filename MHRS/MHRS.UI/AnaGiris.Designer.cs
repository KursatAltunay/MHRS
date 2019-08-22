namespace MHRS.UI
{
    partial class AnaGiris
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
            this.btnEczaci = new System.Windows.Forms.Button();
            this.btnDoktor = new System.Windows.Forms.Button();
            this.btnHasta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEczaci
            // 
            this.btnEczaci.Location = new System.Drawing.Point(59, 194);
            this.btnEczaci.Name = "btnEczaci";
            this.btnEczaci.Size = new System.Drawing.Size(163, 50);
            this.btnEczaci.TabIndex = 5;
            this.btnEczaci.Text = "Eczacı Girişi";
            this.btnEczaci.UseVisualStyleBackColor = true;
            // 
            // btnDoktor
            // 
            this.btnDoktor.Location = new System.Drawing.Point(59, 109);
            this.btnDoktor.Name = "btnDoktor";
            this.btnDoktor.Size = new System.Drawing.Size(163, 53);
            this.btnDoktor.TabIndex = 4;
            this.btnDoktor.Text = "Doktor Girişi";
            this.btnDoktor.UseVisualStyleBackColor = true;
            this.btnDoktor.Click += new System.EventHandler(this.btnDoktor_Click);
            // 
            // btnHasta
            // 
            this.btnHasta.Location = new System.Drawing.Point(59, 28);
            this.btnHasta.Name = "btnHasta";
            this.btnHasta.Size = new System.Drawing.Size(163, 51);
            this.btnHasta.TabIndex = 3;
            this.btnHasta.Text = "Hasta Girişi";
            this.btnHasta.UseVisualStyleBackColor = true;
            // 
            // AnaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 279);
            this.Controls.Add(this.btnEczaci);
            this.Controls.Add(this.btnDoktor);
            this.Controls.Add(this.btnHasta);
            this.Name = "AnaGiris";
            this.Text = "AnaGiris";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEczaci;
        private System.Windows.Forms.Button btnDoktor;
        private System.Windows.Forms.Button btnHasta;
    }
}