using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Form3 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();
        public Form3()
        {
            //dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InitializeComponent();

            /*Ajouter.FillColor = Color.FromArgb(52, 152, 219); // Couleur de fond bleue

            // Définir la couleur du texte du bouton
            Ajouter.ForeColor = Color.White; // Couleur du texte blanc

            // Définir la police du texte du bouton
            Ajouter.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Police en gras

            // Définir le style de bordure du bouton (FlatStyle n'est pas utilisé dans Guna2Button)
            Ajouter.BorderThickness = 0; // Pas de bordure

            // Définir la taille du bouton
            Ajouter.Size = new Size(150, 40); // Taille personnalisée

            // Définir le curseur du bouton au survol
            Ajouter.Cursor = Cursors.Hand; // Curseur main au survol

            // Gérer les événements de survol pour ajouter des effets visuels
            Ajouter.MouseEnter += (sender, e) => Ajouter.BackColor = Color.FromArgb(41, 128, 185); // Couleur de survol plus foncée
            Ajouter.MouseLeave += (sender, e) => Ajouter.BackColor = Color.FromArgb(52, 152, 219); // Retour à la couleur de fond normale*/


            // Couleur de fond de la grille
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
            dataGridView.CellDoubleClick += DataGridView_CellDoubleClick;

            LoadData();
        }

        private void LoadData()
        {
            var query = from medicament in context.medicaments
                        select new
                        {
                            medicament.Id,
                            medicament.Nom,
                            medicament.Description,
                            medicament.Forme,
                            medicament.Fabricant,
                            medicament.fournisseur,
                            medicament.Dosage,
                            medicament.Catégorie,
                            medicament.DateExpiration,
                            medicament.Prix,
                            medicament.Quantité
                        };
            dataGridView.DataSource = query.ToList();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.ShowDialog();
        }
        private void DataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void Rename_Click(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une ligne sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Récupérez les données de la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Récupérez l'ID du médicament à partir de la ligne sélectionnée
                int medicamentID = (int)selectedRow.Cells["Id"].Value;

                // Récupérez le médicament correspondant à l'ID sélectionné
                var selectedMedicament = context.medicaments.FirstOrDefault(m => m.Id == medicamentID);

                if (selectedMedicament != null)
                {
                    // Créez une instance de votre autre formulaire et passez les données
                    Modifier_medicament formModifier = new Modifier_medicament(selectedMedicament,context);
                    formModifier.ShowDialog();

                    // Rechargez les données dans le DataGridView après la modification
                    LoadData();
                }
                else
                {
                    MessageBox.Show("Le médicament sélectionné n'a pas été trouvé dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à renommer dans le DataGridView.");
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une ligne sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
               
                int medicamentID = (int)dataGridView.SelectedRows[0].Cells["Id"].Value; // Assurez-vous de remplacer "Id" par le nom de la colonne correspondant à l'identifiant

                var medicamentToDelete = context.medicaments.FirstOrDefault(m => m.Id == medicamentID);

                if (medicamentToDelete != null)
                {
                    // Supprimez les ventes associées à ce médicament
                    var ventesToDelete = context.Ventes.Where(v => v.ID_medicament == medicamentID);
                    context.Ventes.DeleteAllOnSubmit(ventesToDelete);

                    // Supprimez le médicament de la base de données
                    context.medicaments.DeleteOnSubmit(medicamentToDelete);
                    context.SubmitChanges();

                    // Actualisez les données dans le DataGridView
                    LoadData();

                    MessageBox.Show("Le médicament a été supprimé avec succès.");
                }
                else
                {
                    MessageBox.Show("Le médicament sélectionné n'a pas été trouvé dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer dans le DataGridView.");
            }
        }





        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
