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
using MHRS.DTO;
using MHRS.BLL;

namespace MHRS.UI
{
    public partial class DoktorGiris : Form
    {

        DoktorlarController _doktorlarController;
        LoginDTO login;

        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            //DTO : Data Transfer Object // veriyi al göster entity değil entitynin bir kısmını alır. 
            login = new LoginDTO();
            login.EMail = txtMail.Text;
            login.Sifre = txtSifre.Text;

            //login işleminde oluşturduğumuzu kontrol ettik
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
    }
}
