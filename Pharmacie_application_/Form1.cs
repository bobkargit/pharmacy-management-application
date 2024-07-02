using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacie_application_
{
    public partial class Form1 : Form
    {
        //private PharmacieDataContext context = new PharmacieDataContext();

        public Form1()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            string email1 = Box1.Text;
            string password = Box2.Text;
            using (PharmacieDataContext db = new PharmacieDataContext())
            {
                // Vérifier si l'email et le mot de passe correspondent à une entrée dans la base de données
                var user = db.logins.FirstOrDefault(u => u.email == email1 && u.password == password);

                // Si une correspondance est trouvée, rediriger l'utilisateur vers la page suivante
                if (user != null)
                {
                    Form2 form2 = new Form2();
                    string labelText = $"{user.firstName} {user.lastName}";

                    // Assigner la chaîne de caractères au label
                    form2.labelNom.Text = labelText;
                    form2.ShowDialog();
                }
                else
                {
                    // Afficher un message d'erreur si l'email ou le mot de passe est incorrect
                    ErrorLabel.Text = "Email ou mot de passe incorrect.";
                }
            }
            
           
        }

        private void ErrorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
