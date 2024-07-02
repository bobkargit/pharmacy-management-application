using System;
using System.Collections;
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
    public partial class Form14 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();

        public Form14()
        {
            InitializeComponent();
            dataGridView.BackgroundColor = Color.White;

            // Couleur des en-têtes de colonne
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(231, 76, 60); // Exemple de couleur rouge

            // Couleur de texte des en-têtes de colonne
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Police pour les en-têtes de colonne
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);

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
            dataGridView.RowTemplate.Height = 35;
            LoadForm();
        }
        private void LoadForm()
        {
            try
            {
                // Requête LINQ pour récupérer les données de toutes les tables liées
                var donnees = from Vente in context.Ventes
                              join medicament in context.medicaments
                              on Vente.ID_medicament equals medicament.Id
                              select new
                              {
                                  //commande.Id, // L'identifiant de la commande
                                  Vente.ID,
                                  Medicament = medicament.Nom, // Le nom du médicament
                                  Prix=medicament.Prix,// Le nom du fournisseur
                                  Date_expiration=medicament.DateExpiration,
                                  Vente.DateVente, // La date de commande
                                  Vente.NombreVente, // La date de livraison
                                  Vente.Prix_total
                                 
                              };
                donnees = donnees.OrderByDescending(v => v.ID);

                // Remplir le DataGridView avec les données récupérées
                dataGridView.DataSource = donnees.ToList();
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la récupération des données
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une ligne sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Récupérez l'ID de la commande à partir de la ligne sélectionnée
                int commID = (int)dataGridView.SelectedRows[0].Cells["Id"].Value; // Assurez-vous de remplacer "Id" par le nom de la colonne correspondant à l'identifiant

                // Récupérez la commande correspondant à l'ID sélectionné
                var commToDelete = context.Ventes.FirstOrDefault(m => m.ID == commID);

                if (commToDelete != null)
                {
                    // Récupérez la quantité vendue
                    int quantiteVendue = commToDelete.NombreVente ?? 0;

                    // Récupérez l'ID du médicament associé à la vente
                    int medicamentID = commToDelete.ID_medicament ?? 0;

                    // Récupérez le médicament associé
                    var medicamentToUpdate = context.medicaments.FirstOrDefault(m => m.Id == medicamentID);

                    if (medicamentToUpdate != null)
                    {
                        // Ajoutez la quantité vendue à la quantité disponible du médicament
                        medicamentToUpdate.Quantité += quantiteVendue;

                        // Supprimez la commande de la base de données
                        context.Ventes.DeleteOnSubmit(commToDelete);

                        // Enregistrez les modifications dans la base de données
                        context.SubmitChanges();

                        MessageBox.Show("La commande a été supprimée avec succès et la quantité de médicament a été mise à jour.");
                        LoadForm();
                    }
                    else
                    {
                        MessageBox.Show("Le médicament associé à cette commande n'a pas été trouvé dans la base de données.");
                    }
                }
                else
                {
                    MessageBox.Show("La commande sélectionnée n'a pas été trouvée dans la base de données.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une ligne à supprimer dans le DataGridView.");
            }
        }

    }
}
