using CompteBancaireLib;
using System.CodeDom.Compiler;
using System.Windows.Forms.VisualStyles;

namespace GUICompteBancaire
{
    public partial class FenetrePrincipale : Form
    {
        public FenetrePrincipale()
        {
            InitializeComponent();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ouvrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichiers CSV (.csv)|*.csv|Fichiers JSON (.json)|*.json|Tous les fichiers (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.Multiselect = false;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fichier = ofd.FileName;
                string ext = Path.GetExtension(fichier).ToLower();
                CompteAvecSauvegarde compte = null;
                try
                {
                    if (ext == ".csv")
                    {
                        compte = CompteAvecSauvegarde.LireCSV(fichier);
                    }
                    else if (ext == ".json")
                    {
                        compte = CompteAvecSauvegarde.LireJSON(fichier);
                    }
                    else
                    {
                        MessageBox.Show("Type de fichier inconnu", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    bool found = false;

                    foreach (GestionCompte gc in this.MdiChildren)
                    {
                        if (gc.Fichier == fichier)
                        {
                            found = true;
                            gc.Activate();
                            break;
                        }
                    }

                    if (!found)
                    {
                        GestionCompte nouvelleFenetre = new GestionCompte();
                        nouvelleFenetre.Fichier = fichier;
                        nouvelleFenetre.Compte = compte;
                        nouvelleFenetre.MdiParent = this;
                        nouvelleFenetre.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void creerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreationCompte fenetreCreation = new CreationCompte();
            if (fenetreCreation.ShowDialog() == DialogResult.OK)
            {
                string proprietaire = fenetreCreation.textPropietaire.Text;
                decimal solde = decimal.Parse(fenetreCreation.textSolde.Text);
                CompteAvecSauvegarde temp = new CompteAvecSauvegarde(proprietaire, solde);
                
                GestionCompte nouvelleFenetre = new GestionCompte();
                nouvelleFenetre.Fichier = "file.csv";
                nouvelleFenetre.Compte = temp;
                nouvelleFenetre.MdiParent = this;
                nouvelleFenetre.Show();
            }
        }
    }
}
