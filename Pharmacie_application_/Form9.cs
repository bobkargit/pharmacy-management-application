using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacie_application_
{
    public partial class Form9 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();

        public Form9()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                fournisseur f = new fournisseur();
                f.nom = Nom_four.Text;
                f.ville = Ville_four.Text;
                f.fax = Fax_four.Text;
                f.email = Email_four.Text;
                f.adresse= Address_four.Text;
                f.tel = Tel_four.Text;
                f.nom_pharmacien_responsable = Responsable_four.Text;
                context.fournisseurs.InsertOnSubmit(f);

                // Enregistrez les modifications dans la base de données
                context.SubmitChanges();

                // Affichez un message de succès
                MessageBox.Show("Le fournisseur a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermez la forme actuelle
                this.Close();
            }
            catch (Exception ex)
            {
                // Affichez un message d'erreur si une exception se produit lors de l'ajout du médicament
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du fournisseur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
