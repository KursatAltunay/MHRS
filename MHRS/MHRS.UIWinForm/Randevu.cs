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
    public partial class Randevu : Form
    {
        HastanelerController _hastanelerControllerBLL;
        PolikliniklerController _polikliniklerControllerBLL;
        DoktorlarController _doktorlarControllerBLL;
        DetaylarController _detaylarControllerBLL;
        RandevularController _randevularControllerBLL;        
        List<Poliklinikler> listex = new List<Poliklinikler>();
        List<Hastaneler> listey = new List<Hastaneler>();
        List<Doktorlar> listex1 = new List<Doktorlar>();
        List<Doktorlar> listeDrByH = new List<Doktorlar>();
        string tcNo;

        public Randevu(string Tc)
        {
            InitializeComponent();
            _detaylarControllerBLL = new DetaylarController();
            tcNo = Tc;

        }

        private void Randevu_Load(object sender, EventArgs e)
        {
            dtpTarih.MinDate = DateTime.Today;
            _randevularControllerBLL = new RandevularController();

            //_hastanelerControllerBLL = new HastanelerController();
            //List<Hastaneler> liste1 = _hastanelerControllerBLL.GetHastanelers();

            //cmbHastane.DisplayMember = "HastaneAdi";
            //cmbHastane.ValueMember = "HastaneID";
            //cmbHastane.DataSource = liste1;
            //cmbHastane.SelectedValue = 0;

            _polikliniklerControllerBLL = new PolikliniklerController();

            List<Poliklinikler> liste2 = _polikliniklerControllerBLL.GetPoliklinikler();

            cmbPoliklinik.DisplayMember = "PoliklinikAdi";
            cmbPoliklinik.ValueMember = "PoliklinikID";
            cmbPoliklinik.DataSource = liste2;
            cmbPoliklinik.SelectedValue = 0;
            
            //if (cmbHastane.Text != "")
            //{
            //    listex = _detaylarControllerBLL.GetPoliklinikByHastane(Convert.ToInt32(cmbHastane.SelectedValue));
            //    cmbPoliklinik.DisplayMember = "PoliklinikAdi";
            //    cmbPoliklinik.ValueMember = "PoliklinikID";
            //    cmbPoliklinik.DataSource = listex;

            //}
                       
            _doktorlarControllerBLL = new DoktorlarController();

            List<Doktorlar> liste3 = _doktorlarControllerBLL.GetDoctors();
            cmbDoktor.DisplayMember = "DrAdSoyad";
            cmbDoktor.ValueMember = "DrID";
            cmbDoktor.DataSource = liste3;
            cmbDoktor.SelectedValue = 0;

            cmbHastane.Enabled = false;
            cmbDoktor.Enabled = false;

        }

        private void cmbHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(cmbHastane.SelectedValue);
            int b = Convert.ToInt32(cmbPoliklinik.SelectedValue);
            //listex = _detaylarControllerBLL.GetPoliklinikByHastane(a);
            //cmbPoliklinik.DisplayMember = "PoliklinikAdi";
            //cmbPoliklinik.ValueMember = "PoliklinikID";
            //cmbPoliklinik.DataSource = listex;

            listeDrByH = _detaylarControllerBLL.GetDoktorlarByHastane(a, b);
            cmbDoktor.DisplayMember = "DrAdSoyad";
            cmbDoktor.ValueMember = "DrID";
            cmbDoktor.DataSource = listeDrByH;
            cmbDoktor.Enabled = true;
        }

        private void cmbPoliklinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(cmbPoliklinik.SelectedValue);
            //listex1 = _detaylarControllerBLL.GetDoktorByPoliklinikID(a);
            //cmbDoktor.DisplayMember = "DrAdSoyad";
            //cmbDoktor.ValueMember = "DrID";
            //cmbDoktor.DataSource = listex1;

            listey = _detaylarControllerBLL.GetHastanelerByPoliklinikID(a);
            cmbHastane.DisplayMember = "HastaneAdi";
            cmbHastane.ValueMember = "HastaneID";
            cmbHastane.DataSource = listey;
            cmbHastane.SelectedValue = 0;
            cmbHastane.Enabled = true; 
            cmbDoktor.Enabled = false; 
            cmbDoktor.Text = ""; 
        }

        private void btnRandevuAra_Click(object sender, EventArgs e)
        {
            RandevuGetir();
        }

        private void Lbl_Click(object sender, EventArgs e)
        {
            Label tiklanan = sender as Label;
            DialogResult onay = new DialogResult();
            onay = MessageBox.Show("Randevuyu kaydetmek istiyor musunuz?", "Onay", MessageBoxButtons.OKCancel);

            if (onay == DialogResult.OK)
            {
                Randevular kaydedilecek = new Randevular();
                kaydedilecek.Saat = tiklanan.Text;
                kaydedilecek.Tarih = dtpTarih.Value.Date;
                kaydedilecek.TcNo = tcNo;
                kaydedilecek.DetayID = _detaylarControllerBLL.GetDetayID(Convert.ToInt32(cmbDoktor.SelectedValue));
                _randevularControllerBLL.Add(kaydedilecek);
            }
            RandevuGetir();
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

        void RandevuGetir()
        {
            pnlBosRandevu.Controls.Clear();
            List<string> doluSaatler = new List<string>();
            List<string> tumSaatler = new List<string>();
            doluSaatler = _randevularControllerBLL.GetDoluSaatler(dtpTarih.Value.Date, Convert.ToInt32(cmbDoktor.SelectedValue));
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
    }

}
