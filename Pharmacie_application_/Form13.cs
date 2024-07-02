using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Form13 : Form
    {
        PharmacieDataContext context = new PharmacieDataContext();

        public Form13()
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
                var donnees = from commande in context.commandes
                              join medicament in context.medicaments
                              on commande.id_medicament equals medicament.Id
                              join fournisseur in context.fournisseurs
                              on commande.id_fournisseur equals fournisseur.id
                              where commande.statut == "finished"
                              select new
                              {
                                  //commande.Id, // L'identifiant de la commande
                                  Medicament = medicament.Nom, // Le nom du médicament
                                  Fournisseur = fournisseur.nom, // Le nom du fournisseur
                                  fournisseur.tel,
                                  commande.date_commande, // La date de commande
                                  commande.date_livraison, // La date de livraison
                                  commande.statut, // Le statut de la commande
                                  commande.quantite, // La quantité de commande
                                  medicament.Prix,
                                  commande.montant_total // Le montant total de la commande
                              };

                // Remplir le DataGridView avec les données récupérées
                dataGridView.DataSource = donnees.ToList();
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la récupération des données
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
