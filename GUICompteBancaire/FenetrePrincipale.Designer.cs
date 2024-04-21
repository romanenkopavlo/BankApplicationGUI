namespace GUICompteBancaire
{
    partial class FenetrePrincipale
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuPrincipale = new MenuStrip();
            fichierToolStripMenuItem = new ToolStripMenuItem();
            ouvrirToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            quitterToolStripMenuItem = new ToolStripMenuItem();
            creerToolStripMenuItem = new ToolStripMenuItem();
            menuPrincipale.SuspendLayout();
            SuspendLayout();
            // 
            // menuPrincipale
            // 
            menuPrincipale.ImageScalingSize = new Size(20, 20);
            menuPrincipale.Items.AddRange(new ToolStripItem[] { fichierToolStripMenuItem });
            menuPrincipale.Location = new Point(0, 0);
            menuPrincipale.Name = "menuPrincipale";
            menuPrincipale.Padding = new Padding(7, 3, 0, 3);
            menuPrincipale.Size = new Size(1242, 30);
            menuPrincipale.TabIndex = 0;
            menuPrincipale.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            fichierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ouvrirToolStripMenuItem, creerToolStripMenuItem, toolStripSeparator1, quitterToolStripMenuItem });
            fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            fichierToolStripMenuItem.Size = new Size(66, 24);
            fichierToolStripMenuItem.Text = "Fichier";
            // 
            // ouvrirToolStripMenuItem
            // 
            ouvrirToolStripMenuItem.Name = "ouvrirToolStripMenuItem";
            ouvrirToolStripMenuItem.Size = new Size(224, 26);
            ouvrirToolStripMenuItem.Text = "Ouvrir";
            ouvrirToolStripMenuItem.Click += ouvrirToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(221, 6);
            // 
            // quitterToolStripMenuItem
            // 
            quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            quitterToolStripMenuItem.Size = new Size(224, 26);
            quitterToolStripMenuItem.Text = "Quitter";
            quitterToolStripMenuItem.Click += quitterToolStripMenuItem_Click;
            // 
            // creerToolStripMenuItem
            // 
            creerToolStripMenuItem.Name = "creerToolStripMenuItem";
            creerToolStripMenuItem.Size = new Size(224, 26);
            creerToolStripMenuItem.Text = "Creer";
            creerToolStripMenuItem.Click += creerToolStripMenuItem_Click;
            // 
            // FenetrePrincipale
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 803);
            Controls.Add(menuPrincipale);
            IsMdiContainer = true;
            MainMenuStrip = menuPrincipale;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FenetrePrincipale";
            Text = "Gestion Compte Bancaire";
            menuPrincipale.ResumeLayout(false);
            menuPrincipale.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuPrincipale;
        private ToolStripMenuItem fichierToolStripMenuItem;
        private ToolStripMenuItem ouvrirToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem quitterToolStripMenuItem;
        private ToolStripMenuItem creerToolStripMenuItem;
    }
}
