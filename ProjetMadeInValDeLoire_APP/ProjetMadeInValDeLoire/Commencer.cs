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
    public partial class Commencer : Form
    {

        private String username;
        private String password;

        public Commencer()
        {
            InitializeComponent();
        }

        // Méthode pour ouvrir la fenêtre pour choisir la difficulté
        public Commencer(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        // Evenement clique pour le bouton difficulté 1
        private void difficulte1_Click(object sender, EventArgs e)
        {
            start(1);
        }

        // Evenement clique pour le bouton difficulté 1
        private void difficulte2_Click(object sender, EventArgs e)
        {
            start(2);
        }

        // Evenement clique pour le bouton difficulté 1
        private void difficulte3_Click(object sender, EventArgs e)
        {
            start(3);
        }

        // Evenement clique pour le bouton difficulté 1
        private void difficulte4_Click(object sender, EventArgs e)
        {
            start(4);
        }

        // Méthode pour lancer le quiz avec la difficulté voulue
        private void start(int difficulte)
        {
            this.Hide();
            if (username == null && password == null)
            {
                Question quest = new Question(difficulte);
                quest.Closed += (s, args) => this.Close();
                quest.Show();
            }
            else
            {
                Question quest = new Question(difficulte, username, password);
                quest.Closed += (s, args) => this.Close();
                quest.Show();
            }
        }
    }
}
