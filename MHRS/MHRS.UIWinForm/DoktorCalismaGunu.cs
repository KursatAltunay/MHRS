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
    public partial class DoktorCalismaGunu : Form
    {
        RandevularController _randevularController;
        List<Randevular> randevular;
        Randevular seciliRandevu;

        public DoktorCalismaGunu(int docId)
        {
            InitializeComponent();
            _randevularController = new RandevularController();
        }

        private void DoktorCalismaGunu_Load(object sender, EventArgs e)
        {            
            RandevuGetir();
        }

        void RandevuGetir()
        {
            pnlRandevular.Controls.Clear();

            randevular = new List<Randevular>();
            randevular = _randevularController.GetAllRandevular(dtpTarih.Value.Date);

            List<string> randevuSaatleri = new List<string>();

            foreach (var item in randevular)
            {
                randevuSaatleri.Add(item.Saat);
            }
            string[,] islemYapilmisRandevu = new string[20,2];
            islemYapilmisRandevu = _randevularController.IslemYapildiMi(dtpTarih.Value.Date);
            randevuSaatleri.Sort();

            int sayac = 1;
            int top = 15;
            foreach (var item in randevuSaatleri)
            {
                Label lbl = new Label();
                
                if (sayac % 5 == 0)
                {
                    top += 25;
                    sayac = 1;
                }
                lbl.Top = top;
                lbl.Left = 50 * sayac;
                lbl.Width = 50;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                sayac++;
                lbl.Text = item;
                lbl.Click += Lbl_Click;

                pnlRandevular.Controls.Add(lbl);

                for (int i = 0; i < islemYapilmisRandevu.GetLength(0); i++)
                {
                    if (islemYapilmisRandevu[i,0]==lbl.Text)
                    {
                        if (islemYapilmisRandevu[i, 1] == "1")
                        {
                            lbl.BackColor = Color.Green;
                        }
                        else if (islemYapilmisRandevu[i, 1] == "0")
                        {
                            lbl.BackColor = Color.Red;
                        }
                    }
                }
                
            }
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label tiklanan = sender as Label;
            
            foreach (var item in randevular)
            {
                if (tiklanan.Text == item.Saat)
                {
                    seciliRandevu = item;
                    break;
                }
            }
            RandevuDetay frmDetay = new RandevuDetay(seciliRandevu);
            frmDetay.Owner = this;
            DialogResult sonuc = frmDetay.ShowDialog();
            


            if (sonuc == DialogResult.OK && frmDetay.geldiMi == false)
            {
                tiklanan.BackColor = Color.Red;
            }
            else if(sonuc == DialogResult.OK)
            {
                tiklanan.BackColor = Color.Green;
            }
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            RandevuGetir();
        }
    }
}

