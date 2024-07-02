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
    public partial class ModifierCommande : Form
    {
        private commande selectedc;
        private PharmacieDataContext context;
        public ModifierCommande()
        {
            InitializeComponent();
        }

        public ModifierCommande(commande c, PharmacieDataContext cnt)
        {

            InitializeComponent();
            this.selectedc = c;
            this.context = cnt;
            ComboBox1.SelectedItem = selectedc.medicament;
            ComboBox2.SelectedItem = selectedc.fournisseur;
            DateTimePicker1.Value = selectedc.date_commande.Value;
            DateTimePicker2.Value = selectedc.date_livraison.Value;
            Qnt.Text = selectedc.quantite.ToString();

            DateTimePicker1.MinDate = DateTime.Now;
            DateTimePicker1.MaxDate = DateTime.Now;
            DateTimePicker2.MinDate = DateTime.Now;
            ChargerMedicamentDansComboBox1();
            ChargerFournisseursDansComboBox2();

        }
        private void ChargerMedicamentDansComboBox1()
        {
            try
            {
                // Récupérez les noms des médicaments depuis votre table de médicaments
                var nomsMedicaments = from medicament in context.medicaments
                                      select medicament.Nom;

                // Assurez-vous que le ComboBox est vide avant de le remplir
                ComboBox1.Items.Clear();

                // Ajoutez les noms des médicaments récupérés au ComboBox
                foreach (var nom in nomsMedicaments)
                {
                    ComboBox1.Items.Add(nom);
                }
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la récupération des données
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChargerFournisseursDansComboBox2()
        {
            try
            {
                // Récupérez les noms des médicaments depuis votre table de médicaments
                var nomsFournisseurs = from fournisseur in context.fournisseurs
                                       select fournisseur.nom;

                // Assurez-vous que le ComboBox est vide avant de le remnlir
                ComboBox2.Items.Clear();

                // Ajoutez les noms des médicaments récupérés au ComboBox
                foreach (var nom in nomsFournisseurs)
                {
                    ComboBox2.Items.Add(nom);
                }
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la récupération des données
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private int FindIdFournisseurByNom(string nom)
        {
            int idFournisseur = -1; // Valeur par défaut si aucun médicament trouvé




            try
            {
                // Recherchez l'identifiant du médicament en fonction de son nom
                var Fournisseur = (from m in context.fournisseurs
                                   where m.nom == nom
                                   select m).FirstOrDefault();

                if (Fournisseur != null)
                {
                    // Si le médicament est trouvé, récupérez son identifiant
                    idFournisseur = Fournisseur.id; // Supposons que la propriété contenant l'identifiant soit nommée "Id"
                }
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la recherche du médicament
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idFournisseur;
        }
        private decimal FindPrixMedicamentById(int id)
        {


            decimal prix = 0;


            try
            {
                // Recherchez l'identifiant du médicament en fonction de son nom
                var medicament1 = (from m in context.medicaments
                                   where m.Id == id
                                   select m).FirstOrDefault();

                if (medicament1 != null)
                {
                    // Si le médicament est trouvé, récupérez son identifiant
                    prix = medicament1.Prix ?? 0; // Supposons que la propriété contenant l'identifiant soit nommée "Id"
                }
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la recherche du médicament
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return prix;
        }
        private int FindIdMedicamentByNom(string nom)
        {
            int idMedicament = -1; // Valeur par défaut si aucun médicament trouvé




            try
            {
                // Recherchez l'identifiant du médicament en fonction de son nom
                var medicament = (from m in context.medicaments
                                  where m.Nom == nom
                                  select m).FirstOrDefault();

                if (medicament != null)
                {
                    // Si le médicament est trouvé, récupérez son identifiant
                    idMedicament = medicament.Id; // Supposons que la propriété contenant l'identifiant soit nommée "Id"
                }
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la recherche du médicament
                MessageBox.Show("Une erreur s'est produite : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return idMedicament;
        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            int q= int.Parse(Qnt.Text);

            selectedc.id_fournisseur = FindIdFournisseurByNom(ComboBox2.SelectedItem.ToString());
            selectedc.id_medicament = FindIdMedicamentByNom(ComboBox1.SelectedItem.ToString());
            selectedc.date_commande = DateTimePicker1.Value;
            selectedc.date_livraison = DateTimePicker2.Value;
            selectedc.statut = "en cours";
            selectedc.quantite = q;
            selectedc.montant_total = q * FindPrixMedicamentById(FindIdMedicamentByNom(ComboBox1.SelectedItem.ToString()));
            

            // Enregistrez les modifications dans la base de données
            context.SubmitChanges();

            // Affichez un message de succès
            MessageBox.Show("La commande a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fermez la forme actuelle
            this.Close();

        }
    }
}
