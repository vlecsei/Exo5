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
        private double nombre;
        Int32 chrono;
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
            this.nombre = this.aleat.NextDouble();
            this.Txt_Nbr_Aleatoire.Text = this.nombre.ToString();
            this.chrono++;
            this.Txt_Chrono.Text = this.chrono.ToString();
        }

    }
}
