namespace Exo5
{
    partial class FRM_MDI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fenêtreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chronoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nombreToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fRMExo5ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fRMChronoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fRMRandomToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripTextBox1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 51);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.fenêtreToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.quitterToolStripMenuItem.Text = "Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // fenêtreToolStripMenuItem
            // 
            this.fenêtreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chronoToolStripMenuItem1,
            this.nombreToolStripMenuItem1,
            this.toolStripSeparator1,
            this.fRMExo5ToolStripMenuItem1,
            this.fRMChronoToolStripMenuItem1,
            this.fRMRandomToolStripMenuItem1});
            this.fenêtreToolStripMenuItem.Name = "fenêtreToolStripMenuItem";
            this.fenêtreToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.fenêtreToolStripMenuItem.Text = "Fenêtre";
            // 
            // chronoToolStripMenuItem1
            // 
            this.chronoToolStripMenuItem1.Name = "chronoToolStripMenuItem1";
            this.chronoToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.chronoToolStripMenuItem1.Text = "Chrono";
            this.chronoToolStripMenuItem1.Click += new System.EventHandler(this.chronoToolStripMenuItem1_Click);
            // 
            // nombreToolStripMenuItem1
            // 
            this.nombreToolStripMenuItem1.Name = "nombreToolStripMenuItem1";
            this.nombreToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.nombreToolStripMenuItem1.Text = "Nombre";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(154, 6);
            // 
            // fRMExo5ToolStripMenuItem1
            // 
            this.fRMExo5ToolStripMenuItem1.Name = "fRMExo5ToolStripMenuItem1";
            this.fRMExo5ToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.fRMExo5ToolStripMenuItem1.Text = "1 FRM_Exo5";
            // 
            // fRMChronoToolStripMenuItem1
            // 
            this.fRMChronoToolStripMenuItem1.Name = "fRMChronoToolStripMenuItem1";
            this.fRMChronoToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.fRMChronoToolStripMenuItem1.Text = "2 FRM_Chrono";
            // 
            // fRMRandomToolStripMenuItem1
            // 
            this.fRMRandomToolStripMenuItem1.Name = "fRMRandomToolStripMenuItem1";
            this.fRMRandomToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.fRMRandomToolStripMenuItem1.Text = "3 FRM_Random";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aProposToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.aProposToolStripMenuItem.Text = "A propos...";
            // 
            // FRM_MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FRM_MDI";
            this.Text = "Exo5";
            this.Load += new System.EventHandler(this.FRM_MDI_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fenêtreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chronoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nombreToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fRMExo5ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fRMChronoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fRMRandomToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
    }
}

