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
    public partial class FormImageMedicament : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();

        public FormImageMedicament(medicament m)
        {
            InitializeComponent();
            byte[] imageBytes = m.Image.ToArray();

            // Convertir les octets de l'image en Image
            Image image = ByteArrayToImage(imageBytes);

            // Afficher l'image dans un PictureBox
            pictureBox.Image = image;
              nom.Text=m.Nom;
              description.Text = m.Description;
              forme.Text = m.Forme;
              categorie.Text = m.Catégorie;
              prix.Text =  m.Prix.ToString();
              expiration.Text = m.DateExpiration.ToString();
              fabriquant.Text =  m.Fabricant;
              dosage.Text = m.Dosage;
              quantite.Text = m.Quantité.ToString();
    }

        // Méthode pour convertir un tableau d'octets en Image
        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            Image image;
            using (var ms = new System.IO.MemoryStream(byteArrayIn))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }

        private void FormImageMedicament_Load(object sender, EventArgs e)
        {

        }
    }
}
