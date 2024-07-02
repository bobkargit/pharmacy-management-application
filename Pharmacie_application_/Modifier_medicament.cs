using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Modifier_medicament : Form
    {
        private PharmacieDataContext context ;
        private medicament selectedMedicament;
        public Modifier_medicament()
        {
            InitializeComponent();
        }
        public Modifier_medicament(medicament m, PharmacieDataContext con)
        {
            InitializeComponent();
            selectedMedicament = m;
            context = con;
            LoadComboBox();
            Nom_medi.Text= selectedMedicament.Nom;
            Descr_medi.Text= selectedMedicament.Description;
            Forme_medi.Text= selectedMedicament.Forme;
            Fabricant_medi.Text= selectedMedicament.Fabricant;
            Dosage_medi.Text= selectedMedicament.Dosage;
            Qnt_medi.Text = selectedMedicament.Quantité.ToString();
            Prix_medi.Text = selectedMedicament.Prix.ToString();
            guna2DateTimePicker1.Value= selectedMedicament.DateExpiration.Value;
            Cate_medi.Text= selectedMedicament.Catégorie;
            ComboBox.Text= selectedMedicament.fournisseur;
            byte[] imageBytes = selectedMedicament.Image.ToArray();

            // Convertir les octets de l'image en Image
            Image image = ByteArrayToImage(imageBytes);
            guna2PictureBox1.Image = image;

        }
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            Image image;
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                image = Image.FromStream(ms);
            }
            return image;
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

        private void Add_butt_Click(object sender, EventArgs e)
        {
            try
            {
                // Créez une nouvelle instance de l'entité medicament
                //context.medicaments.Attach(selectedMedicament);

                // Affectez les valeurs récupérées à partir de vos contrôles d'interface utilisateur aux propriétés de l'entité medicament
                selectedMedicament.Nom = Nom_medi.Text;
                selectedMedicament.Description = Descr_medi.Text;
                selectedMedicament.Forme = Forme_medi.Text;
                selectedMedicament.Fabricant = Fabricant_medi.Text;
                selectedMedicament.Dosage = Dosage_medi.Text;
                selectedMedicament.Quantité = int.Parse(Qnt_medi.Text);
                selectedMedicament.Prix = decimal.Parse(Prix_medi.Text);
                selectedMedicament.DateExpiration = guna2DateTimePicker1.Value;
                selectedMedicament.Catégorie = Cate_medi.Text;
                selectedMedicament.fournisseur = ComboBox.SelectedItem.ToString();

                // Si une image est disponible, convertissez-la en tableau d'octets
                if (guna2PictureBox1.Image != null)
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        guna2PictureBox1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                        selectedMedicament.Image = ms.ToArray();
                    }
                }

                // Ajoutez l'entité medicament à votre contexte de données
                //context.medicaments.InsertOnSubmit(nouveauMedicament);

                // Enregistrez les modifications dans la base de données
                context.SubmitChanges();

                // Affichez un message de succès
                MessageBox.Show("Le médicament a été modifiee avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                guna2PictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
