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
    public partial class Modifier_fournisseur : Form
    {
        private fournisseur selectedf;
        private PharmacieDataContext context;
        public Modifier_fournisseur()
        {
            InitializeComponent();
        }
        public Modifier_fournisseur(fournisseur f, PharmacieDataContext c)
        {
            InitializeComponent();
            selectedf = f;
            context = c;
            Nom_four.Text= selectedf.nom;
            Ville_four.Text= selectedf.ville;
            Fax_four.Text= selectedf.fax;
           Email_four.Text= selectedf.email;
            Address_four.Text= selectedf.adresse;
           Tel_four.Text= selectedf.tel;
           Responsable_four.Text= selectedf.nom_pharmacien_responsable;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            selectedf.nom = Nom_four.Text;
            selectedf.ville = Ville_four.Text;
            selectedf.fax = Fax_four.Text;
            selectedf.email = Email_four.Text;
            selectedf.adresse = Address_four.Text;
            selectedf.tel = Tel_four.Text;
            selectedf.nom_pharmacien_responsable = Responsable_four.Text;
           

            // Enregistrez les modifications dans la base de données
            context.SubmitChanges();

            // Affichez un message de succès
            MessageBox.Show("Le fournisseur a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Fermez la forme actuelle
            this.Close();
        }
    }
}
