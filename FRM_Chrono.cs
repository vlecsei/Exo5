﻿using System;
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
        private FRM_Exo5 FRM_Princ;

        public FRM_Chrono(FRM_Exo5 f)
        {
            InitializeComponent();
            this.FRM_Princ = f;
        }

        

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            ((FRM_MDI)(this.FRM_Princ.MdiParent)).fermeChrono();
            this.Close();
        }
        

        private void Btn_Actualiser_Click(object sender, EventArgs e)
        {
            this.Txt_Chrono.Text = this.FRM_Princ.chrono.ToString();
        }
    }
}
