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
    public partial class DoktorRandevuEkle : Form
    {
        RandevularController _randevularController;
        Randevular kaydedilecek;
        public DoktorRandevuEkle(Randevular seciliRandevu)
        {
            InitializeComponent();
            _randevularController = new RandevularController();
            kaydedilecek = seciliRandevu;
        }

        private void dtpTarih_ValueChanged(object sender, EventArgs e)
        {
            pnlBosRandevu.Controls.Clear();
            List<string> doluSaatler = new List<string>();
            List<string> tumSaatler = new List<string>();
            int detayID = _randevularController.GetDetaydanDoktor(kaydedilecek.DetayID);
            doluSaatler = _randevularController.GetDoluSaatler(dtpTarih.Value.Date, detayID);
            SaatDoldur(ref tumSaatler);
            int sayac = 1;
            int top = 15;
            foreach (string item in tumSaatler)
            {
                if (!doluSaatler.Contains(item))
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
                    pnlBosRandevu.Controls.Add(lbl);
                }
                else
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
                    lbl.Enabled = false;
                    pnlBosRandevu.Controls.Add(lbl);
                }
            }           
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label tiklanan = sender as Label;
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Randevuyu kaydetmek istiyor musunuz?", "Onay", MessageBoxButtons.OKCancel);

            if (onay == DialogResult.OK)
            {                
                kaydedilecek.Saat = tiklanan.Text;
                kaydedilecek.Tarih = dtpTarih.Value.Date;
                _randevularController.Add(kaydedilecek);
                Close();
            }
        }

        void SaatDoldur(ref List<string> saatler)
        {
            saatler.Clear();
            saatler.Add("09:00");
            saatler.Add("09:30");
            saatler.Add("10:00");
            saatler.Add("10:30");
            saatler.Add("11:00");
            saatler.Add("11:30");
            saatler.Add("12:00");
            saatler.Add("13:00");
            saatler.Add("13:30");
            saatler.Add("14:00");
            saatler.Add("14:30");
            saatler.Add("15:00");
            saatler.Add("15:30");
            saatler.Add("16:00");
            saatler.Add("16:30");
            saatler.Add("17:00");
        }
    }
}
