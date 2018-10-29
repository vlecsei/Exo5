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
    public partial class FRM_Chrono : Form
    {

        public FRM_Chrono()
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


        private void FRM_Chrono_Activated(object sender, EventArgs e)
        {
            this.Txt_Chrono.Text = Donnees.LeTemps.ToString();
        }

        private void affiche()
        {
            this.Txt_Chrono.Text = Donnees.LeTemps.ToString();
        }
    }
}
