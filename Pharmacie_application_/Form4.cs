using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pharmacie_application_
{
    public partial class Form4 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();
        public Form4()
        {
            InitializeComponent();
            guna2DateTimePicker1.MinDate = DateTime.Now;
            LoadComboBox();
        }
        private void LoadComboBox()
        {
            try
            {
                // Exécutez la requête LINQ pour récupérer les données
                var query = from fournisseur in context.fournisseurs
                            select fournisseur.nom; // Remplacez 'Nom' par le nom de la propriété que vous souhaitez afficher dans le ComboBox

                // Parcourez les résultats et ajoutez-les au ComboBox
                foreach (var nom in query)
                {
                    ComboBox.Items.Add(nom);
                }
            }
            catch (Exception ex)
            {
                // Gérez toute exception qui pourrait survenir lors de la récupération des données
                MessageBox.Show("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            try
            {
               
                medicament nouveauMedicament = new medicament();


                nouveauMedicament.Nom = Nom_medi.Text;
                nouveauMedicament.Description = Descr_medi.Text;
                nouveauMedicament.Forme = Forme_medi.Text;
                nouveauMedicament.Fabricant = Fabricant_medi.Text;
                nouveauMedicament.Dosage = Dosage_medi.Text;
                nouveauMedicament.Quantité = int.Parse(Qnt_medi.Text);
                nouveauMedicament.Prix = decimal.Parse(Prix_medi.Text);
                nouveauMedicament.DateExpiration = guna2DateTimePicker1.Value;
                nouveauMedicament.Catégorie = Cate_medi.Text;
                nouveauMedicament.fournisseur = ComboBox.SelectedItem.ToString();

                // Si une image est disponible, convertissez-la en tableau d'octets
                if (picture.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        picture.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        nouveauMedicament.Image = ms.ToArray();
                    }
                }

                // Ajoutez l'entité medicament à votre contexte de données
                context.medicaments.InsertOnSubmit(nouveauMedicament);

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
                MessageBox.Show("Une erreur s'est produite lors de l'ajout du médicament : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void ChoisirImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            // Filtre les types de fichiers à afficher
            openFileDialog1.Filter = "Images (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";

            // Affiche la boîte de dialogue de sélection de fichier
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Charge l'image sélectionnée dans le Guna2PictureBox
                picture.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void guna2ContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
