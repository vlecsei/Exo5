namespace Exo5
{
    partial class FRM_Chrono
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
            this.Lbl_Chrono = new System.Windows.Forms.Label();
            this.Txt_Chrono = new System.Windows.Forms.TextBox();
            this.Btn_Actualiser = new System.Windows.Forms.Button();
            this.Btn_Fermer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_Chrono
            // 
            this.Lbl_Chrono.AutoSize = true;
            this.Lbl_Chrono.Location = new System.Drawing.Point(12, 21);
            this.Lbl_Chrono.Name = "Lbl_Chrono";
            this.Lbl_Chrono.Size = new System.Drawing.Size(41, 13);
            this.Lbl_Chrono.TabIndex = 0;
            this.Lbl_Chrono.Text = "Chrono";
            // 
            // Txt_Chrono
            // 
            this.Txt_Chrono.Location = new System.Drawing.Point(85, 18);
            this.Txt_Chrono.Name = "Txt_Chrono";
            this.Txt_Chrono.Size = new System.Drawing.Size(141, 20);
            this.Txt_Chrono.TabIndex = 2;
            // 
            // Btn_Actualiser
            // 
            this.Btn_Actualiser.Location = new System.Drawing.Point(26, 53);
            this.Btn_Actualiser.Name = "Btn_Actualiser";
            this.Btn_Actualiser.Size = new System.Drawing.Size(75, 23);
            this.Btn_Actualiser.TabIndex = 3;
            this.Btn_Actualiser.Text = "Actualiser";
            this.Btn_Actualiser.UseVisualStyleBackColor = true;
            // 
            // Btn_Fermer
            // 
            this.Btn_Fermer.Location = new System.Drawing.Point(151, 53);
            this.Btn_Fermer.Name = "Btn_Fermer";
            this.Btn_Fermer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Fermer.TabIndex = 4;
            this.Btn_Fermer.Text = "Fermer";
            this.Btn_Fermer.UseVisualStyleBackColor = true;
            this.Btn_Fermer.Click += new System.EventHandler(this.Btn_Fermer_Click);
            // 
            // FRM_Chrono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 93);
            this.Controls.Add(this.Btn_Fermer);
            this.Controls.Add(this.Btn_Actualiser);
            this.Controls.Add(this.Txt_Chrono);
            this.Controls.Add(this.Lbl_Chrono);
            this.Name = "FRM_Chrono";
            this.Text = "FRM_Chrono";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Chrono;
        private System.Windows.Forms.TextBox Txt_Chrono;
        private System.Windows.Forms.Button Btn_Actualiser;
        private System.Windows.Forms.Button Btn_Fermer;
    }
}