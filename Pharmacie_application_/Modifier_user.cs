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
    public partial class Modifier_user : Form
    {
        private login selectedf;
        private PharmacieDataContext context;
        public Modifier_user()
        {
            InitializeComponent();
        }
        public Modifier_user(login f, PharmacieDataContext c)
        {
            InitializeComponent();
            selectedf = f;
            context = c;
            ComboBox1.Items.Add("User");
            ComboBox1.Items.Add("Admin");

            Nom.Text=selectedf.lastName;
            Prenom.Text= selectedf.firstName;
            CIN.Text=selectedf.CIN;
            Email.Text=selectedf.email;
            Password.Text=selectedf.password;
            ComboBox1.Text = selectedf.type;
        }

        private void Add_butt_Click(object sender, EventArgs e)
        {
            selectedf.lastName = Nom.Text;
            selectedf.firstName = Prenom.Text;
            selectedf.CIN = CIN.Text;
            selectedf.email = Email.Text;
            selectedf.password = Password.Text;
            selectedf.type = ComboBox1.SelectedItem != null ? ComboBox1.SelectedItem.ToString() : null;

            context.SubmitChanges();

            this.Close();

            // Affichez un message de succès
            MessageBox.Show("Le médicament a été modifiee avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
