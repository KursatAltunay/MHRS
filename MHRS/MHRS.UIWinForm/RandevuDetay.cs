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
    public partial class RandevuDetay : Form
    {
        Randevular seciliRandevu;
        RandevularController _randevularController;
        Muayeneler muayene;
        MuayenelerController _muayenelerController;

        public bool geldiMi = true;

        public RandevuDetay(Randevular randevu)
        {
            InitializeComponent();
            seciliRandevu = randevu;
            muayene = new Muayeneler();
            _muayenelerController = new MuayenelerController();
            _randevularController = new RandevularController();
        }

        private void RandevuDetay_Load(object sender, EventArgs e)
        {
            lblHastaAdi.Text = _randevularController.HastaAdiBul(seciliRandevu.TcNo);
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            if (cbGelmedi.Checked == true)
            {
                geldiMi = false;
                muayene.HastaGeldiMi = 0;
            }
            muayene.HastaGeldiMi = 1;
            muayene.RandevuID = seciliRandevu.RandevuID;
            muayene.MuayeneNot = txtNot.Text;

            _muayenelerController.Add(muayene);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ReceteYaz frmReceteYaz = new ReceteYaz(seciliRandevu.TcNo);
            frmReceteYaz.Owner = this;
            frmReceteYaz.ShowDialog();

        }

        private void btnRandevu_Click(object sender, EventArgs e)
        {
            DoktorRandevuEkle frmRandEkle = new DoktorRandevuEkle(seciliRandevu);
            frmRandEkle.Owner = this;
            frmRandEkle.ShowDialog();
        }
    }
}
