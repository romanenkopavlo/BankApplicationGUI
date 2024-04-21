using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUICompteBancaire
{
    public partial class CreationCompte : Form
    {
        public CreationCompte()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string proprietaire = textPropietaire.Text;
            string solde = textSolde.Text;

            if (string.IsNullOrEmpty(proprietaire)) 
            {
                MessageBox.Show("Le nom du Proprietaire ne peut pas etre vide!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            decimal soldeInital = 0;
            if (!decimal.TryParse(solde, out soldeInital))
            {
                MessageBox.Show("Le solde n'est pas correct!", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
