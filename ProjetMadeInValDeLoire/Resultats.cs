using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMadeInValDeLoire
{
    public partial class Resultats : Form
    {
        private String username;
        private String password;

        public Resultats()
        {
            InitializeComponent();
        }

        public Resultats(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void btnExplications_Click(object sender, EventArgs e)
        {
            this.Hide();
            Explications explications = new Explications();
            explications.Closed += (s, args) => this.Close();
            explications.Show();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scoreboard scoreboard = new Scoreboard();
            scoreboard.Closed += (s, args) => this.Close();
            scoreboard.Show();
        }

        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueil = new Accueil();
            accueil.Closed += (s, args) => this.Close();
            accueil.Show();
        }
    }
}
