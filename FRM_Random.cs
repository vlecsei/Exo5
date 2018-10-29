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
    public partial class FRM_Random : Form
    {
        private FRM_Exo5 FRM_Princ;

        public FRM_Random(FRM_Exo5 r)
        {
            InitializeComponent();
            this.FRM_Princ = r;
        }

        private void Btn_Fermer_Click(object sender, EventArgs e)
        {
            ((FRM_MDI)(this.FRM_Princ.MdiParent)).fermeNbrAleatoire();
            this.Close();
        }

        private void Btn_Actualiser_Click(object sender, EventArgs e)
        {
            this.Txt_Nbr_Aleatoire.Text = this.FRM_Princ.nombre.ToString();
        }
    }
}
