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
    public partial class EczaneGiris : Form
    {
        EczanelerController _eczanelerController;
        LoginDTO login;
        public EczaneGiris()
        {
            InitializeComponent();
            _eczanelerController = new EczanelerController();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            login = new LoginDTO();
            login.EMail = txtMail.Text;
            login.Sifre = txtSifre.Text;

            //login işleminde oluşturduğumuzu kontrol ettik
            string result = _eczanelerController.Login(login);

            int eczaneID;
            if (int.TryParse(result, out eczaneID))
            {

                ReceteSorgulama frm = new ReceteSorgulama(eczaneID);
                frm.Owner = this;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(result);
            }

            
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {
           
        }

        private void EczaneGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}

