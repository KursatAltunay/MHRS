using MHRS.BLL;
using MHRS.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS.UIWinForm
{
    public partial class ReceteYaz : Form
    {
        Receteler eklenecekRecete;
        RecetelerController _recetelerController = new RecetelerController();

        public ReceteYaz(string hastaTc)
        {
            InitializeComponent();
            eklenecekRecete = new Receteler();
            eklenecekRecete.TcNo = hastaTc;
        }

        
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            
            eklenecekRecete.Ilac1 = txtIlac1.Text;
            if (txtIlac2.Text != "")
            {
                eklenecekRecete.Ilac2 = txtIlac2.Text;
            }
            else
            {
                eklenecekRecete.Ilac2 = "-";
            }
            if (txtIlac3.Text != "")
            {
                eklenecekRecete.Ilac3 = txtIlac3.Text;
            }
            else
            {
                eklenecekRecete.Ilac3 = "-";
            }
            if (txtIlac4.Text != "")
            {
                eklenecekRecete.Ilac4 = txtIlac4.Text;
            }
            else
            {
                eklenecekRecete.Ilac4 = "-";
            }

            _recetelerController.Add(eklenecekRecete);
            Close();
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult cikis = new DialogResult();
            cikis = MessageBox.Show("Çıkış yapmak istiyor musunuz ?", "Uyarı", MessageBoxButtons.YesNo);

            if (cikis == DialogResult.Yes)
            {
                this.Close();

            }
            if (cikis == DialogResult.No)
            {
                MessageBox.Show("Sayfa kapatılmadı.");
            }

        }
    }
}
