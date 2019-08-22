namespace MHRS.UIWinForm
{
    partial class HastaEkrani
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
            this.btnYeniRandevu = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TcNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnYeniRandevu
            // 
            this.btnYeniRandevu.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnYeniRandevu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniRandevu.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnYeniRandevu.Location = new System.Drawing.Point(404, 32);
            this.btnYeniRandevu.Name = "btnYeniRandevu";
            this.btnYeniRandevu.Size = new System.Drawing.Size(130, 23);
            this.btnYeniRandevu.TabIndex = 5;
            this.btnYeniRandevu.Text = "Yeni Randevu Olustur";
            this.btnYeniRandevu.UseVisualStyleBackColor = false;
            this.btnYeniRandevu.Click += new System.EventHandler(this.btnYeniRandevu_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TcNo,
            this.columnHeader1,
            this.columnHeader2});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(380, 350);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // TcNo
            // 
            this.TcNo.Text = "TcNo";
            this.TcNo.Width = 99;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "RandevuTarihi";
            this.columnHeader1.Width = 102;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Randevu Saati";
            this.columnHeader2.Width = 109;
            // 
            // HastaEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(546, 350);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnYeniRandevu);
            this.Name = "HastaEkrani";
            this.Text = "HastaEkrani";
            this.Load += new System.EventHandler(this.HastaEkrani_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnYeniRandevu;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader TcNo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}