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
using System.Windows.Forms.DataVisualization.Charting;
using static System.Net.Mime.MediaTypeNames;

namespace Pharmacie_application_
{
    public partial class Accueil : Form
    {
        private PharmacieDataContext context = new PharmacieDataContext();
        public Accueil()
        {
            InitializeComponent();
            CreateRoundedPanel(panel1,20);
            CreateRoundedPanel(panel2, 20);
            CreateRoundedPanel(panel3, 20);
            CreateRoundedPanel(panel4, 20);
           sommeMedicament();
           //sommeVentes();

            chart.Size = new System.Drawing.Size(850, 700);
            chart.ChartAreas.Add(new ChartArea());

            // Récupérer les données des ventes des 7 derniers jours
            DateTime dateDebut = DateTime.Today.AddDays(-7);
            DateTime dateFin = DateTime.Today;
            var ventes = context.Ventes
                .Where(vente => vente.DateVente >= dateDebut && vente.DateVente <= dateFin)
                .GroupBy(vente => vente.DateVente)
                .Select(g => new { Date = g.Key, NombreVentes = g.Sum(v => v.NombreVente) })
                .OrderBy(item => item.Date)
                .ToList();

            // Ajouter les données au graphique
            Series series = new Series();
            series.ChartType = SeriesChartType.Column;
            series.XValueType = ChartValueType.Date;
            series.YValueType = ChartValueType.Int32;

            foreach (var vente in ventes)
            {
                series.Points.AddXY(vente.Date, vente.NombreVentes);
            }

            chart.Series.Add(series);

            // Ajouter le titre et les légendes
            chart.Titles.Add("Nombre de ventes des 7 derniers jours");
            chart.ChartAreas[0].AxisX.Title = "Date";
            chart.ChartAreas[0].AxisY.Title = "Nombre de ventes";


            if (pictureBox1.Image != null)
            {
                // Charger l'image actuelle
                System.Drawing.Image image = pictureBox1.Image;

                // Définir la nouvelle taille souhaitée
                int nouvelleLargeur = 475; // Mettez la nouvelle largeur désirée ici
                int nouvelleHauteur = 300; // Mettez la nouvelle hauteur désirée ici

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
        }

    public void sommeMedicament()
        {
            int sommeQuantites = context.medicaments.Sum(m => m.Quantité ?? 0);
            medi.Text = sommeQuantites.ToString();
        }
      /* public void sommeVentes()
        {
            int sommeVentesAujourdhui = context.Ventes
            .Where(vente => vente.DateVente == DateTime.Today && vente.NombreVente != null)
            .Sum(vente => vente.NombreVente.Value);

            decimal sommePrix = context.Ventes
                .Where(vente => vente.DateVente == DateTime.Today && vente.Prix_total != null)
                .Sum(vente => vente.Prix_total.Value);

            var medicamentsProchesExpiration = from medicament in context.medicaments
                                               where ( medicament.DateExpiration <= DateTime.Now.AddDays(30))
                                                   || medicament.Quantité < 20
                                               select medicament;

            // Sélectionner le nombre de lignes
            int nombreMedicamentsProchesExpiration = medicamentsProchesExpiration.Count();

            vent.Text = sommeVentesAujourdhui.ToString();
            income.Text = sommePrix.ToString("N2") + " DH";
            notif.Text = nombreMedicamentsProchesExpiration.ToString();

       }*/
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

        private void medi_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
