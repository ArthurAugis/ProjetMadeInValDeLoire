using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMadeInValDeLoire
{
    public partial class Accueil : Form
    {
        public Accueil()
        {
            InitializeComponent();
        }

        private void difficulte1_Click(object sender, EventArgs e)
        {
            start("Collégiens");
        }

        private void difficulte2_Click(object sender, EventArgs e)
        {
            start("Lycéens");
        }

        private void difficulte3_Click(object sender, EventArgs e)
        {
            start("Etudiants");
        }

        private void difficulte4_Click(object sender, EventArgs e)
        {
            start("Professionnels");
        }

        private void start(String difficulte)
        {
            this.Hide();
            Question quest = new Question(difficulte);
            quest.Closed += (s, args) => this.Close();
            quest.Show();
        }

        private void inscrire_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Inscription réussie";
            lblMessage.ForeColor = Color.Green;
        }

        private void connexion_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Connexion réussie";
            lblMessage.ForeColor = Color.Green;
        }
    }
}
