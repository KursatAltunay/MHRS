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
    public partial class HastaKayit : Form
    {
        HastalarController _hastalarController;
        public HastaKayit()
        {
            InitializeComponent();
            _hastalarController = new HastalarController();

        }

        private void HastaKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Show();
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler Uyuşmuyor");
                txtSifreTekrar.BackColor = Color.Red;
                txtSifreTekrar.Select();
                return;
            }

            
            Hastalar newHasta = new Hastalar();
            newHasta.TcNo = txtTC.Text;
            newHasta.HastaAdi = txtAd.Text;
            newHasta.HastaEmail = txtMail.Text;
            newHasta.HastaSifre = txtSifre.Text;
          
            bool result = false;
            try
            {
                result = _hastalarController.Add(newHasta);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(result ? "Kayıt Başarılı" : "Kayıt Başarısız");
        }

        private void HastaKayit_FormClosed_1(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void HastaKayit_Load(object sender, EventArgs e)
        {
            txtTC.MaxLength = 11;
        }
    }
}
