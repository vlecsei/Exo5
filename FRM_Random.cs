using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo5
{
    public partial class FRM_Random : Form
    {

        public FRM_Random()
        {
            InitializeComponent();
            this.affiche();
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Actualiser_Click(object sender, EventArgs e)
        {
            this.affiche();
        }

        private void FRM_Random_Activated(object sender, EventArgs e)
        {
            this.affiche();
        }

        private void affiche()
        {
            this.Txt_Nbr_Aleatoire.Text = Donnees.LeNombre.ToString();
        }
    }
}
