namespace GUICompteBancaire
{
    partial class CreationCompte
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
            label1 = new Label();
            label2 = new Label();
            textPropietaire = new TextBox();
            textSolde = new TextBox();
            buttonOk = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 13);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "Proprietaire";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 1;
            label2.Text = "Solde Initial";
            // 
            // textPropietaire
            // 
            textPropietaire.Location = new Point(130, 10);
            textPropietaire.MaxLength = 50;
            textPropietaire.Name = "textPropietaire";
            textPropietaire.Size = new Size(125, 27);
            textPropietaire.TabIndex = 2;
            // 
            // textSolde
            // 
            textSolde.Location = new Point(130, 61);
            textSolde.MaxLength = 13;
            textSolde.Name = "textSolde";
            textSolde.Size = new Size(125, 27);
            textSolde.TabIndex = 3;
            textSolde.TextAlign = HorizontalAlignment.Right;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(161, 107);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 4;
            buttonOk.Text = "OK";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // CreationCompte
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 148);
            Controls.Add(buttonOk);
            Controls.Add(textSolde);
            Controls.Add(textPropietaire);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CreationCompte";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreationCompte";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonOk;
        public TextBox textPropietaire;
        public TextBox textSolde;
    }
}