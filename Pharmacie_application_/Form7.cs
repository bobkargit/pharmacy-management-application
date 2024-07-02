using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacie_application_
{
    public partial class Form7 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();

        public Form7()
        {

            InitializeComponent();
            //ComboBox1.Items.Add("User");
            ComboBox1.Items.Add("Admin");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            try
            {
                login l = new login();
                l.lastName = Nom.Text;
                l.firstName = Prenom.Text;
                l.CIN = CIN.Text;
                l.email= Email.Text;
                l.password = Password.Text;
                l.type = ComboBox1.SelectedItem != null ? ComboBox1.SelectedItem.ToString() : null;
                context.logins.InsertOnSubmit(l);

                // Enregistrez les modifications dans la base de données
                context.SubmitChanges();

                // Affichez un message de succès
                MessageBox.Show("Le médicament a été ajouté avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Fermez la forme actuelle
                this.Close();
            }
            catch (Exception ex)
            {
                // Affichez un message d'erreur si une exception se produit lors de l'ajout du médicament
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du l'utilisateur : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
