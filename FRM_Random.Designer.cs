namespace Exo5
{
    partial class FRM_Random
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
            this.Lbl_Nbr_Aleatoire = new System.Windows.Forms.Label();
            this.Txt_Nbr_Aleatoire = new System.Windows.Forms.TextBox();
            this.Btn_Actualiser = new System.Windows.Forms.Button();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Nbr_Aleatoire
            // 
            this.Lbl_Nbr_Aleatoire.AutoSize = true;
            this.Lbl_Nbr_Aleatoire.Location = new System.Drawing.Point(12, 23);
            this.Lbl_Nbr_Aleatoire.Name = "Lbl_Nbr_Aleatoire";
            this.Lbl_Nbr_Aleatoire.Size = new System.Drawing.Size(88, 13);
            this.Lbl_Nbr_Aleatoire.TabIndex = 0;
            this.Lbl_Nbr_Aleatoire.Text = "Nombre Aléatoire";
            // 
            // Txt_Nbr_Aleatoire
            // 
            this.Txt_Nbr_Aleatoire.Enabled = false;
            this.Txt_Nbr_Aleatoire.Location = new System.Drawing.Point(106, 20);
            this.Txt_Nbr_Aleatoire.Name = "Txt_Nbr_Aleatoire";
            this.Txt_Nbr_Aleatoire.ReadOnly = true;
            this.Txt_Nbr_Aleatoire.Size = new System.Drawing.Size(125, 20);
            this.Txt_Nbr_Aleatoire.TabIndex = 1;
            // 
            // Btn_Actualiser
            // 
            this.Btn_Actualiser.Location = new System.Drawing.Point(25, 56);
            this.Btn_Actualiser.Name = "Btn_Actualiser";
            this.Btn_Actualiser.Size = new System.Drawing.Size(75, 23);
            this.Btn_Actualiser.TabIndex = 2;
            this.Btn_Actualiser.Text = "Actualiser";
            this.Btn_Actualiser.UseVisualStyleBackColor = true;
            this.Btn_Actualiser.Click += new System.EventHandler(this.Btn_Actualiser_Click);
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.Location = new System.Drawing.Point(156, 56);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fermer.TabIndex = 3;
            this.Btn_Fermer.Text = "Fermer";
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // FRM_Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 97);
            this.Controls.Add(this.Btn_Fermer);
            this.Controls.Add(this.Btn_Actualiser);
            this.Controls.Add(this.Txt_Nbr_Aleatoire);
            this.Controls.Add(this.Lbl_Nbr_Aleatoire);
            this.Name = "FRM_Random";
            this.Text = "FRM_Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Nbr_Aleatoire;
        private System.Windows.Forms.Button Btn_Actualiser;
        private System.Windows.Forms.Button Btn_Fermer;
        internal System.Windows.Forms.TextBox Txt_Nbr_Aleatoire;
    }
}