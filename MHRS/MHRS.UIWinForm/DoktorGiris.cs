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
    public partial class DoktorGiris : Form
    {
        DoktorlarController _doktorlarController;
        LoginDTO login;
        public DoktorGiris()
        {
            InitializeComponent();
            _doktorlarController = new DoktorlarController();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            login = new LoginDTO();
            login.EMail = txtMail.Text;
            login.Sifre = txtSifre.Text;
            
            string result = _doktorlarController.Login(login);

            int docID;
            if (int.TryParse(result, out docID))
            {

                DoktorCalismaGunu frm = new DoktorCalismaGunu(docID);
                frm.Owner = this;
                frm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show(result);
            }
           
        }

        private void DoktorGiris_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }
    }
}
