using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Form2 : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();
        public Form2()
        {
            InitializeComponent();
            Accueil accueil = new Accueil();
            LoadChildForm(accueil);
            CreateRoundedPanel(panel1, 20);

            if (pictureBox1.Image != null)
            {
                // Charger l'image actuelle
                System.Drawing.Image image = pictureBox1.Image;

                // Définir la nouvelle taille souhaitée
                int nouvelleLargeur = 158; // Mettez la nouvelle largeur désirée ici
                int nouvelleHauteur = 136; // Mettez la nouvelle hauteur désirée ici

                // Redimensionner l'image
                System.Drawing.Image imageRedimensionnee = new Bitmap(image, nouvelleLargeur, nouvelleHauteur);

                // Afficher l'image redimensionnée dans le PictureBox
                pictureBox1.Image = imageRedimensionnee;
            }
            else
            {
                // Afficher un message ou gérer le cas où il n'y a pas d'image chargée dans le PictureBox
                MessageBox.Show("Aucune image chargée dans le PictureBox.");
            }

            if (guna2CirclePictureBox1.Image != null)
            {
                // Charger l'image actuelle
                System.Drawing.Image image = guna2CirclePictureBox1.Image;

                // Définir la nouvelle taille souhaitée
                int nouvelleLargeur = 47; // Mettez la nouvelle largeur désirée ici
                int nouvelleHauteur = 41; // Mettez la nouvelle hauteur désirée ici

                // Redimensionner l'image
                System.Drawing.Image imageRedimensionnee = new Bitmap(image, nouvelleLargeur, nouvelleHauteur);

                // Afficher l'image redimensionnée dans le PictureBox
                guna2CirclePictureBox1.Image = imageRedimensionnee;
            }
            else
            {
                // Afficher un message ou gérer le cas où il n'y a pas d'image chargée dans le PictureBox
                MessageBox.Show("Aucune image chargée dans le PictureBox.");
            }


        }
        private void CreateRoundedPanel(System.Windows.Forms.Panel panel, int radius)
        {
            // Créer un chemin pour les coins arrondis
            GraphicsPath path = new GraphicsPath();
            path.AddArc(panel.ClientRectangle.X, panel.ClientRectangle.Y, radius * 2, radius * 2, 180, 90);
            path.AddArc(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Y, radius * 2, radius * 2, 270, 90);
            path.AddArc(panel.ClientRectangle.Width - radius * 2, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(panel.ClientRectangle.X, panel.ClientRectangle.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseFigure();

            // Définir le chemin comme région du panneau
            panel.Region = new Region(path);
        }

        private void LoadChildForm(Form childForm)
        {
            // Effacer le contenu actuel du panel
            panel2.Controls.Clear();

            // Définir les propriétés du formulaire enfant
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            // Afficher le formulaire enfant dans le panel principal
            panel2.Controls.Add(childForm);
            childForm.Show();
        }

        private void Medicament_butt_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            LoadChildForm(form3);

        }

        private void Stock_butt_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            LoadChildForm(form5);

        }

        private void Utilisateurs_butt_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            LoadChildForm(form6);

        }

        private void fournisseur_butt_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8();
            LoadChildForm(form8);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form10 form10 = new Form10();
            LoadChildForm(form10);
        }
        public System.Windows.Forms.Panel Panel2 { get { return panel2; } }

        private void Ventes_butt_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            LoadChildForm(form14);
        }

        private void Notification_Click(object sender, EventArgs e)
        {
            Form15 form15 = new Form15();
            LoadChildForm(form15);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Accueil_but_Click(object sender, EventArgs e)
        {
            Accueil accueil = new Accueil();
            LoadChildForm(accueil);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            String mot = search.Text;
            var result = from medicament in context.medicaments
                         where medicament.Nom.Contains(mot)
                         select new
                         {
                             medicament.Id,
                             medicament.Nom,
                             medicament.Description,
                             medicament.Forme,
                             medicament.Fabricant,
                             medicament.fournisseur,
                             medicament.Dosage,
                             medicament.Catégorie,
                             medicament.DateExpiration,
                             medicament.Prix,
                             medicament.Quantité
                         };
            Rechercher_Med r = new Rechercher_Med();
            r.dataGridView.DataSource = result.ToList();
            LoadChildForm(r);

        }
    }
}
