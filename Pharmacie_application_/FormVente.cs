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
    public partial class FormVente : Form
    {
        public FormVente()
        {
            InitializeComponent();
            textBoxQuantite.Text = "1";
            // Créer et configurer le bouton "OK"
     
            buttonOK.Text = "OK";
            buttonOK.DialogResult = DialogResult.OK; // Définir le résultat de fermeture du formulaire sur OK
            buttonOK.Click += ButtonOK_Click; // Ajouter un gestionnaire d'événements pour le clic sur le bouton OK

            // Positionner le bouton "OK" dans le formulaire
            //buttonOK.Location = new Point(150, 100); // Modifier les coordonnées selon vos besoins

            // Ajouter le bouton "OK" au formulaire
            this.Controls.Add(buttonOK);
        }
        private void ButtonOK_Click(object sender, EventArgs e)
        {
            // Vérifiez si la quantité saisie est valide
            int quantite;
            if (int.TryParse(textBoxQuantite.Text, out quantite))
            {
                // Vérifiez si la quantité est supérieure à zéro
                if (quantite > 0)
                {
                    // La quantité est valide, fermez le formulaire avec le résultat OK
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("La quantité saisie doit être supérieure à zéro.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Veuillez saisir un nombre entier valide pour la quantité.", "Erreur de saisie", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
