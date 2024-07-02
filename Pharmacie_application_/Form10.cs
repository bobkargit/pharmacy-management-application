using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Form10 : Form
    {
        PharmacieDataContext context = new PharmacieDataContext();
        public Form10()
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
            SupprimerEtMettreAJour();
            LoadForm();
        }

        private void SupprimerEtMettreAJour()
        {
            try
            {
                // Récupérez toutes les commandes où la date de livraison est égale à la date système
                var commandesASupprimer = from cmd in context.commandes
                                          where cmd.statut == "en cours"
                                          select cmd;

                // Parcourez chaque commande à supprimer
                foreach (var commande in commandesASupprimer)
                {
                    if(commande.date_livraison == DateTime.Now.Date) {
                    // Ajoutez la quantité de commande à la quantité de médicament correspondante
                       int idMedicament = commande.id_medicament ?? 0;
                       int quantiteCommande = commande.quantite ?? 0;
                       commande.statut = "finished";
                       medicament medicament = context.medicaments.FirstOrDefault(m => m.Id == idMedicament);
                       if (medicament != null)
                       {
                        medicament.Quantité += quantiteCommande;
                       }
                        context.SubmitChanges();
                        // Supprimez la commande de la base de données
                        //context.commandes.DeleteOnSubmit(commande);
                    }
                    
                }

                // Enregistrez les modifications dans la base de données
                

                // Affichez un message de succès
                // MessageBox.Show("Les commandes ont été supprimées avec succès et les quantités de médicaments ont été mises à jour.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Affichez un message d'erreur si une exception se produit lors de la suppression des commandes ou de la mise à jour des médicaments
                //MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                              select new
                              {
                                  //commande.Id, // L'identifiant de la commande
                                  Id=commande.id_commande,
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
                donnees = donnees.OrderByDescending(v => v.Id);

                // Remplir le DataGridView avec les données récupérées
                dataGridView.DataSource = donnees.ToList();
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la récupération des données
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void cours_button_Click(object sender, EventArgs e)
        { // Accédez au formulaire parent
            Form parentForm = this.ParentForm;

            // Vérifiez si le formulaire parent est du type attendu
            if (parentForm is Form2)
            {
                // Accédez au panel dans le formulaire parent
                System.Windows.Forms.Panel panel2 = (parentForm as Form2).Panel2;

                // Créez une instance du formulaire que vous souhaitez afficher
                Form12 formulaireNouveau = new Form12();

                // Assurez-vous que le formulaire occupe toute la zone du panel
                formulaireNouveau.TopLevel = false;
                formulaireNouveau.FormBorderStyle = FormBorderStyle.None;
                formulaireNouveau.Dock = DockStyle.Fill;

                // Supprimez tous les contrôles existants dans le panel
                panel2.Controls.Clear();

                // Ajoutez le formulaire au panel
                panel2.Controls.Add(formulaireNouveau);

                // Affichez le formulaire
                formulaireNouveau.Show();
            }

        }

        private void terminne_butt_Click(object sender, EventArgs e)
        {
            Form parentForm = this.ParentForm;

            // Vérifiez si le formulaire parent est du type attendu
            if (parentForm is Form2)
            {
                // Accédez au panel dans le formulaire parent
                System.Windows.Forms.Panel panel2 = (parentForm as Form2).Panel2;

                // Créez une instance du formulaire que vous souhaitez afficher
                Form13 formulaireNouveau = new Form13();

                // Assurez-vous que le formulaire occupe toute la zone du panel
                formulaireNouveau.TopLevel = false;
                formulaireNouveau.FormBorderStyle = FormBorderStyle.None;
                formulaireNouveau.Dock = DockStyle.Fill;

                // Supprimez tous les contrôles existants dans le panel
                panel2.Controls.Clear();

                // Ajoutez le formulaire au panel
                panel2.Controls.Add(formulaireNouveau);

                // Affichez le formulaire
                formulaireNouveau.Show();
            }

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

        private void Livree_butt_Click(object sender, EventArgs e)
        {
            if (selectedMedicamentId != -1)
            {
                // Récupérer le statut de la commande de la ligne sélectionnée
                var commande = context.commandes.FirstOrDefault(c => c.id_commande == selectedMedicamentId);
                // Vérifier si le statut de la commande est "fini"
                if (commande != null) 
                { 
                    if (commande.statut == "finished")
                    {
                        // Afficher un MessageBox pour indiquer que la commande est terminée
                        MessageBox.Show("La commande est déjà livrée.", "Statut de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        commande.statut = "finished";
                        medicament medicament = context.medicaments.FirstOrDefault(m => m.Id == commande.id_medicament);
                        if (medicament != null)
                        {
                            medicament.Quantité += commande.quantite;
                        }

                        // Soumettre les modifications à la base de données
                        context.SubmitChanges();

                        // Afficher un MessageBox pour indiquer que le statut de la commande a été mis à jour
                        MessageBox.Show("Le statut de la commande a été mis à jour avec succès.", "Statut de la commande", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    LoadForm();
                }
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner une commande dans la liste.", "Avertissement", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            // Vérifiez s'il y a une ligne sélectionnée dans le DataGridView
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Récupérez l'ID de la commande à partir de la ligne sélectionnée
                int commID = (int)dataGridView.SelectedRows[0].Cells["Id"].Value; // Assurez-vous de remplacer "Id" par le nom de la colonne correspondant à l'identifiant

                // Récupérez la commande correspondant à l'ID sélectionné
                var commToDelete = context.commandes.FirstOrDefault(m => m.id_commande == commID);

                if (commToDelete != null)
                {
                    // Supprimez la commande de la base de données
                    context.commandes.DeleteOnSubmit(commToDelete);
                    context.SubmitChanges();

                    MessageBox.Show("La commande a été supprimée avec succès.");
                    LoadForm();
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

        private void Modifier_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Récupérez les données de la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];

                // Récupérez l'ID du médicament à partir de la ligne sélectionnée
                int medicamentID = (int)selectedRow.Cells["Id"].Value;

                // Récupérez le médicament correspondant à l'ID sélectionné
                var selectedMedicament = context.commandes.FirstOrDefault(m => m.id_commande == medicamentID);

                if (selectedMedicament != null)
                {
                    // Créez une instance de votre autre formulaire et passez les données
                    ModifierCommande formModifier = new ModifierCommande(selectedMedicament, context);
                    formModifier.ShowDialog();

                    // Rechargez les données dans le DataGridView après la modification
                    LoadForm();
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
