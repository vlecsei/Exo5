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
        private FRM_A_Propos FRM_About;

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
                this.FRM_C = new FRM_Chrono { MdiParent = this};
                this.FRM_C.Show();
                this.FRM_C.FormClosing += new FormClosingEventHandler(this.fermeChrono);
                
            }
            else
            {
                this.FRM_C.Activate();
            }
            
            
        }

        private void nombreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.FRM_R == null)
            {
                this.FRM_R = new FRM_Random { MdiParent = this };
                this.FRM_R.Show();
                this.FRM_R.FormClosing += new FormClosingEventHandler(this.fermeNbrAleatoire);

            }
            else
            {
                this.FRM_R.Activate();
            }
                
            
        }


        private void fermeChrono(object sender, EventArgs e)
        {
            this.FRM_C = null;
        }

        private void fermeNbrAleatoire(object sender, EventArgs e)
        {
            this.FRM_R = null;
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aProposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FRM_About == null)
            {
                this.FRM_About = new FRM_A_Propos();
                this.FRM_About.ShowDialog();
                this.FRM_About.FormClosing += new FormClosingEventHandler(this.fermeAbout);

            }
            else
            {
                this.FRM_About.Activate();
            }
        }

        private void fermeAbout(object sender, EventArgs e)
        {
            this.FRM_About = null;
        }
    }
}
