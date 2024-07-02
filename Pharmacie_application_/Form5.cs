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
    public partial class Form5 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();
        public Form5()
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
            dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // Activation de la sélection de ligne entière
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.RowTemplate.Height = 35;
            LoadData();
            // Créer une colonne DataGridViewTextBoxColumn
            // Créer une colonne DataGridViewButtonColumn
            

            // Ajouter la colonne de boutons à la fin du DataGridView
     



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
                            medicament.DateExpiration,
                            medicament.Prix,
                            medicament.Quantité
                        };
            dataGridView.DataSource = query.ToList();
        }
        int selectedMedicamentId = -1;

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifiez si une cellule est cliquée dans le DataGridView
            if (e.RowIndex >= 0)
            {
                // Enregistrez l'ID du médicament de la ligne sélectionnée
                selectedMedicamentId = (int)dataGridView.Rows[e.RowIndex].Cells["Id"].Value;
            }
        }


        private void Vendre_butt_Click(object sender, EventArgs e)
        {
            if (selectedMedicamentId != -1)
            {
                // Ouvrir un formulaire ou une boîte de dialogue pour saisir le nombre de pièces à vendre
                // Supposons que vous ayez un formulaire nommé "FormVente" avec un TextBox "textBoxQuantite"
                var medicament = context.medicaments.FirstOrDefault(m => m.Id == selectedMedicamentId);
                if (medicament.DateExpiration < DateTime.Now)
                {
                    MessageBox.Show("La date de medicament est expiree");
                    return;

                }

                FormVente formVente = new FormVente();
                DialogResult result = formVente.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Récupérer la quantité de pièces saisie par l'utilisateur
                    int quantiteVendue = Convert.ToInt32(formVente.textBoxQuantite.Text);

                    // Mettre à jour la quantité disponible dans la table Medicament
                    // Supposons que vous ayez un accès à votre base de données via un ORM ou directement
                    // Exemple avec LINQ to SQL :
                    
                    if (medicament != null)
                    {
                       
                        if (medicament.Quantité >= quantiteVendue )
                        {
                            medicament.Quantité -= quantiteVendue;
                            Vente v = new Vente();
                            v.ID_medicament = medicament.Id;
                            v.DateVente = DateTime.Now;
                            v.NombreVente = quantiteVendue;
                            v.Prix_total = quantiteVendue * medicament.Prix;
                            context.Ventes.InsertOnSubmit(v);
                            context.SubmitChanges();
                            LoadData();
                        }
                     
                        else
                        {
                            MessageBox.Show("La quantite est insuffisante");
                        }

                       
                    }
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un médicament dans la liste.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Ventes_Button_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.ShowDialog();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
