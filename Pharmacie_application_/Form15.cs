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
    public partial class Form15 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();

        public Form15()
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
            LoadDataGrid();

        }
        private void LoadDataGrid()
        {
            try
            {
                // Date actuelle
                DateTime dateActuelle = DateTime.Now;

                // Date dans 30 jours
                DateTime dateLimite = dateActuelle.AddDays(30);

                // Requête pour récupérer les médicaments qui expirent dans les 30 prochains jours et dont la quantité est inférieure à 20
                var medicamentsProchesExpiration = from medicament in context.medicaments
                                                   where  medicament.DateExpiration <= dateLimite
                                                   || medicament.Quantité < 20
                                                   select new
                                                   {
                                                       medicament.Id,
                                                       medicament.Nom,
                                                       medicament.Description,
                                                       medicament.Dosage,
                                                       medicament.Fabricant,
                                                       medicament.fournisseur,
                                                       medicament.Prix,
                                                       medicament.Quantité,
                                                       medicament.DateExpiration,
                                                       Cause = medicament.DateExpiration <= dateLimite ? "La date est expirée" : "La quantité est inférieure"
                                                   };

                // Lier les résultats à la source de données du DataGridView
                dataGridView.DataSource = medicamentsProchesExpiration.ToList();
            }
            catch (Exception ex)
            {
                // Gérer les erreurs éventuelles
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form15_Load(object sender, EventArgs e)
        {

        }
    }
}
