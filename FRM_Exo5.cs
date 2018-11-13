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
    public partial class FRM_Exo5 : Form
    {
        private System.Random aleat;

        public FRM_Exo5()
        {
            InitializeComponent();
            this.aleat = new System.Random();
            this.affiche();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.affiche();
        }

        private void affiche()
        {
            Donnees.LeNombre = this.aleat.NextDouble();
            this.Txt_Nbr_Aleatoire.Text = Donnees.LeNombre.ToString();
            Donnees.LeTemps++;
            this.Txt_Chrono.Text = Donnees.LeTemps.ToString();
        }

        
    }
}
