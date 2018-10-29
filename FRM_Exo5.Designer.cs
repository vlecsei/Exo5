namespace Exo5
{
    partial class FRM_Exo5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Lbl_Chrono = new System.Windows.Forms.Label();
            this.Lbl_Nbr_Aleatoire = new System.Windows.Forms.Label();
            this.Txt_Chrono = new System.Windows.Forms.TextBox();
            this.Txt_Nbr_Aleatoire = new System.Windows.Forms.TextBox();
            this.Tim_Chrono = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Lbl_Chrono
            // 
            this.Lbl_Chrono.AutoSize = true;
            this.Lbl_Chrono.Location = new System.Drawing.Point(12, 19);
            this.Lbl_Chrono.Name = "Lbl_Chrono";
            this.Lbl_Chrono.Size = new System.Drawing.Size(38, 13);
            this.Lbl_Chrono.TabIndex = 0;
            this.Lbl_Chrono.Text = "Chono";
            // 
            // Lbl_Nbr_Aleatoire
            // 
            this.Lbl_Nbr_Aleatoire.AutoSize = true;
            this.Lbl_Nbr_Aleatoire.Location = new System.Drawing.Point(12, 72);
            this.Lbl_Nbr_Aleatoire.Name = "Lbl_Nbr_Aleatoire";
            this.Lbl_Nbr_Aleatoire.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Nbr_Aleatoire.TabIndex = 1;
            this.Lbl_Nbr_Aleatoire.Text = "Nombre Aléatoire";
            // 
            // Txt_Chrono
            // 
            this.Txt_Chrono.Enabled = false;
            this.Txt_Chrono.Location = new System.Drawing.Point(108, 16);
            this.Txt_Chrono.Name = "Txt_Chrono";
            this.Txt_Chrono.ReadOnly = true;
            this.Txt_Chrono.Size = new System.Drawing.Size(140, 20);
            this.Txt_Chrono.TabIndex = 2;
            // 
            // Txt_Nbr_Aleatoire
            // 
            this.Txt_Nbr_Aleatoire.Enabled = false;
            this.Txt_Nbr_Aleatoire.Location = new System.Drawing.Point(108, 69);
            this.Txt_Nbr_Aleatoire.Name = "Txt_Nbr_Aleatoire";
            this.Txt_Nbr_Aleatoire.ReadOnly = true;
            this.Txt_Nbr_Aleatoire.Size = new System.Drawing.Size(140, 20);
            this.Txt_Nbr_Aleatoire.TabIndex = 3;
            // 
            // Tim_Chrono
            // 
            this.Tim_Chrono.Enabled = true;
            this.Tim_Chrono.Interval = 1000;
            this.Tim_Chrono.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FRM_Exo5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 127);
            this.Controls.Add(this.Txt_Nbr_Aleatoire);
            this.Controls.Add(this.Txt_Chrono);
            this.Controls.Add(this.Lbl_Nbr_Aleatoire);
            this.Controls.Add(this.Lbl_Chrono);
            this.Name = "FRM_Exo5";
            this.Text = "FRM_Exo5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Chrono;
        private System.Windows.Forms.Label Lbl_Nbr_Aleatoire;
        private System.Windows.Forms.Timer Tim_Chrono;
        internal System.Windows.Forms.TextBox Txt_Chrono;
        internal System.Windows.Forms.TextBox Txt_Nbr_Aleatoire;
    }
}