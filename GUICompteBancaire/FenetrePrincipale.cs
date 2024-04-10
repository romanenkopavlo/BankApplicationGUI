using CompteBancaireLib;

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
                CompteAvecSauvegarde compte;
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
                }
                catch (Exception ex) 
                {
                    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }
    }
}
