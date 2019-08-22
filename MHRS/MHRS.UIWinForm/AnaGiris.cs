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
    public partial class AnaGiris : Form
    {
        public AnaGiris()
        {
            InitializeComponent();
        }

        private void btnDoktor_Click(object sender, EventArgs e)
        {
            DoktorGiris frm = new DoktorGiris();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnHasta_Click(object sender, EventArgs e)
        {
            HastaGiris frm = new HastaGiris();
            frm.Owner = this;
            frm.Show();
            this.Hide();
        }

        private void btnEczaci_Click(object sender, EventArgs e)
        {
            EczaneGiris frm = new EczaneGiris();
            frm.Owner = this;
            frm.Show();
            this.Hide();

        }
    }
}
