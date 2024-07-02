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
    public partial class Form6 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();

        public Form6()
        {
            InitializeComponent();
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
            dataGridView.RowTemplate.Height = 35;
            LoadData();

        }
        private void LoadData()
        {
            var query = from login in context.logins
                        select new
                        {
                            login.Id,
                            login.CIN,
                            login.firstName,
                            login.lastName,
                            login.email,
                            login.password
                          
                           
                        };
            dataGridView.DataSource = query.ToList();
        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.ShowDialog();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une ligne sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Récupérez l'ID du médicament à partir de la ligne sélectionnée
                int userID = (int)dataGridView.SelectedRows[0].Cells["Id"].Value; // Assurez-vous de remplacer "Id" par le nom de la colonne correspondant à l'identifiant

                // Récupérez le médicament correspondant à l'ID sélectionné
                var userToDelete = context.logins.FirstOrDefault(m => m.Id == userID);

                if (userToDelete != null)
                {
                    // Supprimez les ventes associées à ce médicament
          

                    // Supprimez le médicament de la base de données
                    context.logins.DeleteOnSubmit(userToDelete);
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

        private void Modifier_Click(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une ligne sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Récupérez les données de la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Récupérez l'ID du médicament à partir de la ligne sélectionnée
                int medicamentID = (int)selectedRow.Cells["Id"].Value;

                // Récupérez le médicament correspondant à l'ID sélectionné
                var selectedMedicament = context.logins.FirstOrDefault(m => m.Id == medicamentID);

                if (selectedMedicament != null)
                {
                    // Créez une instance de votre autre formulaire et passez les données
                    Modifier_user formModifier = new Modifier_user(selectedMedicament, context);
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
    }
}

