using MHRS.BLL;
using MHRS.DTO;
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
    public partial class HastaEkrani : Form
    {
        Randevular currentRandevu;
        RandevularController _randevularController;
        string email, tc;
      
        public HastaEkrani(string emailGelen, string tcGelen)
        {
            InitializeComponent();
            currentRandevu = new Randevular();
            _randevularController = new RandevularController();
            email = emailGelen;
            tc = tcGelen;
        }

        private void HastaEkrani_Load(object sender, EventArgs e)
        {            
            FillList();
        }

        private void FillList()
        {
            listView1.Items.Clear();
            List<Randevular> randevu = _randevularController.GetRandevularsByTC(email);

            ListViewItem lvi;
            foreach (var item in randevu)
            {
           
                lvi = new ListViewItem();
                lvi.Text = item.TcNo;
                lvi.SubItems.Add(item.Tarih.ToShortDateString());
                lvi.SubItems.Add(item.Saat);
                lvi.Tag = item;
                listView1.Items.Add(lvi);
            }
            
        }
      
        private void btnYeniRandevu_Click(object sender, EventArgs e)
        {
            Randevu frm = new Randevu(tc);
            frm.ShowDialog();
            FillList();
        }
    }
}
