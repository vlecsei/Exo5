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
    
    public partial class FRM_MDI : Form
    {
        private FRM_Exo5 FRM_Princ;
        private FRM_Chrono FRM_C;
        private FRM_Random FRM_R;

        public FRM_MDI()
        {
            InitializeComponent();
            FRM_Princ = new FRM_Exo5 { MdiParent = this };
            FRM_Princ.Show();
        }

        private void chronoToolStripMenuItem1_Click(object sender, EventArgs e)
        {   
            if (this.FRM_C == null)
            {
                this.FRM_C = new FRM_Chrono(this.FRM_Princ);
                this.FRM_C.MdiParent = this;

                this.FRM_C.Show();
            }
            else
            {
                this.FRM_C.Activate();
            }
            this.FRM_C.Txt_Chrono.Text = this.FRM_Princ.chrono.ToString();
            
        }

        private void nombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.FRM_R == null)
            {
                this.FRM_R = new FRM_Random(this.FRM_Princ);
                this.FRM_R.MdiParent = this;

                this.FRM_R.Show();
            }
            else
            {
                this.FRM_R.Activate();
            }
            this.FRM_R.Txt_Nbr_Aleatoire.Text = this.FRM_Princ.nombre.ToString();
        }


        public void fermeChrono()
        {
            this.FRM_C = null;
        }

        public void fermeNbrAleatoire()
        {
            this.FRM_R = null;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
