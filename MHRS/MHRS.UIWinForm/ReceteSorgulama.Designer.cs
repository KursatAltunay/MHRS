namespace MHRS.UIWinForm
{
    partial class ReceteSorgulama
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnHastaRecete = new System.Windows.Forms.Button();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.txtReceteId = new System.Windows.Forms.TextBox();
            this.lstIlaclar = new System.Windows.Forms.ListBox();
            this.lsvTumReceteler = new System.Windows.Forms.ListView();
            this.ReceteID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilac1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilac2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilac3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ilac4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.SeaGreen;
            this.label2.Location = new System.Drawing.Point(367, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "TcNo:";
            // 
            // btnHastaRecete
            // 
            this.btnHastaRecete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHastaRecete.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHastaRecete.Location = new System.Drawing.Point(435, 38);
            this.btnHastaRecete.Name = "btnHastaRecete";
            this.btnHastaRecete.Size = new System.Drawing.Size(151, 23);
            this.btnHastaRecete.TabIndex = 14;
            this.btnHastaRecete.Text = "Tüm Reçeteleri Sorgula";
            this.btnHastaRecete.UseVisualStyleBackColor = true;
            this.btnHastaRecete.Click += new System.EventHandler(this.btnHastaRecete_Click);
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(435, 12);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(151, 20);
            this.txtTc.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "ReçeteID:";
            // 
            // btnSorgula
            // 
            this.btnSorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSorgula.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnSorgula.Location = new System.Drawing.Point(137, 39);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(100, 23);
            this.btnSorgula.TabIndex = 10;
            this.btnSorgula.Text = "Reçete Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // txtReceteId
            // 
            this.txtReceteId.Location = new System.Drawing.Point(86, 13);
            this.txtReceteId.Name = "txtReceteId";
            this.txtReceteId.Size = new System.Drawing.Size(151, 20);
            this.txtReceteId.TabIndex = 9;
            // 
            // lstIlaclar
            // 
            this.lstIlaclar.FormattingEnabled = true;
            this.lstIlaclar.Location = new System.Drawing.Point(7, 68);
            this.lstIlaclar.Name = "lstIlaclar";
            this.lstIlaclar.Size = new System.Drawing.Size(230, 186);
            this.lstIlaclar.TabIndex = 8;
            // 
            // lsvTumReceteler
            // 
            this.lsvTumReceteler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ReceteID,
            this.Ilac1,
            this.Ilac2,
            this.Ilac3,
            this.Ilac4});
            this.lsvTumReceteler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsvTumReceteler.Location = new System.Drawing.Point(255, 67);
            this.lsvTumReceteler.Name = "lsvTumReceteler";
            this.lsvTumReceteler.Size = new System.Drawing.Size(331, 186);
            this.lsvTumReceteler.TabIndex = 16;
            this.lsvTumReceteler.UseCompatibleStateImageBehavior = false;
            this.lsvTumReceteler.View = System.Windows.Forms.View.Details;
            // 
            // ReceteID
            // 
            this.ReceteID.Text = "ReçeteID";
            this.ReceteID.Width = 74;
            // 
            // Ilac1
            // 
            this.Ilac1.Text = "İlaç 1";
            this.Ilac1.Width = 71;
            // 
            // Ilac2
            // 
            this.Ilac2.Text = "İlaç 2";
            this.Ilac2.Width = 68;
            // 
            // Ilac3
            // 
            this.Ilac3.Text = "İlaç 3";
            this.Ilac3.Width = 57;
            // 
            // Ilac4
            // 
            this.Ilac4.Text = "İlaç 4";
            this.Ilac4.Width = 55;
            // 
            // ReceteSorgulama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(598, 270);
            this.Controls.Add(this.lsvTumReceteler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnHastaRecete);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSorgula);
            this.Controls.Add(this.txtReceteId);
            this.Controls.Add(this.lstIlaclar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ReceteSorgulama";
            this.Text = "ReceteSorgulama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHastaRecete;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.TextBox txtReceteId;
        private System.Windows.Forms.ListBox lstIlaclar;
        private System.Windows.Forms.ListView lsvTumReceteler;
        private System.Windows.Forms.ColumnHeader ReceteID;
        private System.Windows.Forms.ColumnHeader Ilac1;
        private System.Windows.Forms.ColumnHeader Ilac2;
        private System.Windows.Forms.ColumnHeader Ilac3;
        private System.Windows.Forms.ColumnHeader Ilac4;
    }
}