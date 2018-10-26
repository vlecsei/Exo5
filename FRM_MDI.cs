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
        public FRM_MDI()
        {
            InitializeComponent();
            FRM_Exo5 FRM_Princ;
            FRM_Princ = new FRM_Exo5{ MdiParent = this };
            FRM_Princ.Show();
        }

        private void chronoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FRM_Chrono FRM_C;
            FRM_C = new FRM_Chrono { MdiParent = this };
            FRM_C.Show();
        }

        private void FRM_MDI_Load(object sender, EventArgs e)
        {

        }

        
    }
}
