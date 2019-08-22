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
    public partial class ReceteSorgulama : Form
    {
        RecetelerController _recetelerController;
        public ReceteSorgulama(int eczaneID)
        {
            InitializeComponent();
            _recetelerController = new RecetelerController();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            lstIlaclar.Items.Clear();

            Receteler ilaclar; 
            int receteId;
            if (int.TryParse(txtReceteId.Text, out receteId)==true)
            {
                ilaclar = _recetelerController.GetRecipe(receteId);
            }
            else
            {
                throw new Exception("Hatalı Reçete ID");
            }

            if (ilaclar.Ilac1 != null)
            {
                lstIlaclar.Items.Add(ilaclar.Ilac1);
            }
            if (ilaclar.Ilac2 != null)
            {
                lstIlaclar.Items.Add(ilaclar.Ilac2);
            }
            if (ilaclar.Ilac3 != null)
            {
                lstIlaclar.Items.Add(ilaclar.Ilac3);
            }
            if (ilaclar.Ilac4 != null)
            {
                lstIlaclar.Items.Add(ilaclar.Ilac4);
            }


        }

        private void btnHastaRecete_Click(object sender, EventArgs e)
        {
            lsvTumReceteler.Items.Clear();

            List<Receteler> receteler = new List<Receteler>();

            receteler = _recetelerController.GetRecipes(txtTc.Text);

            foreach (Receteler item in receteler)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = item.ReceteID.ToString();
                lvi.SubItems.Add(item.Ilac1);
                lvi.SubItems.Add(item.Ilac2);
                lvi.SubItems.Add(item.Ilac3);
                lvi.SubItems.Add(item.Ilac4);

                lsvTumReceteler.Items.Add(lvi);
            }
        }
    }
}
