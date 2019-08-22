using MHRS.BLL;
using MHRS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MHRS.UIWinForm
{
    public partial class HastaGiris : Form
    {
        HastalarController _hastalarController;
        LoginDTO login;
        public HastaGiris()
        {
            InitializeComponent();
            _hastalarController = new HastalarController();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            login = new LoginDTO();
            login.EMail = txtMail.Text;
            login.Sifre = txtSifre.Text;

            string result = _hastalarController.Login(login);
            foreach (var item in _hastalarController.GetUsers())
            {
                if (item.TcNo == result)
                {
                    HastaEkrani frm = new HastaEkrani(login.EMail, item.TcNo);
                    frm.Owner = this;
                    frm.Show();
                    this.Hide();
                }
            }
        }

   
        private void lnkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit frm = new HastaKayit();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void HastaGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
