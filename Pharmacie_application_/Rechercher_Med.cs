using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Rechercher_Med : Form
    {
        PharmacieDataContext context = new PharmacieDataContext();
        public Rechercher_Med()
        {
            InitializeComponent();
            dataGridView.BackgroundColor = Color.White;

            // Couleur des en-têtes de colonne
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60); // Exemple de couleur rouge

            // Couleur de texte des en-têtes de colonne
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Police pour les en-têtes de colonne
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 10, FontStyle.Bold);

            // Couleur de fond des lignes de données alternées
            dataGridView.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Exemple de couleur grise claire

            // Couleur de fond des cellules sélectionnées
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(46, 204, 113); // Exemple de couleur verte

            // Couleur de texte des cellules sélectionnées
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Bordure de la grille
            dataGridView.BorderStyle = BorderStyle.None;

            // Activation de la sélection de ligne entière
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowTemplate.Height = 40;

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            // Vérifiez que l'index de la ligne est valide et que l'utilisateur n'a pas cliqué sur l'en-tête de colonne
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Récupérez l'ID du médicament à partir de la ligne sélectionnée
                int medicamentID = (int)dataGridView.Rows[e.RowIndex].Cells["ID"].Value;

                // Récupérez le médicament correspondant à l'ID sélectionné
                var selectedMedicament = context.medicaments.FirstOrDefault(m => m.Id == medicamentID);

                if (selectedMedicament != null)
                {
                    byte[] imageBytes = selectedMedicament.Image.ToArray();
                    // Afficher l'image du médicament dans une nouvelle fenêtre
                    AfficherImageMedicament(selectedMedicament); // Supposant que le champ de l'image s'appelle "Image" dans votre modèle
                }
            }
        }
        private void AfficherImageMedicament(medicament m)
        {
            // Créez une nouvelle fenêtre pour afficher l'image
            FormImageMedicament formImage = new FormImageMedicament(m); // Créez un nouveau formulaire pour afficher l'image du médicament
            formImage.ShowDialog();
        }
    }
}
