using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetMadeInValDeLoire
{
    public partial class Accueil : Form
    {
        private String username;
        private String password;

        public Accueil()
        {
            InitializeComponent();
        }

        public Accueil(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        // Evenement clique pour le bouton règles
        private void regle_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Hide();
            if (username == null && password == null)
            {
                Regle regle = new Regle();
                regle.Closed += (s, args) => this.Close();
                regle.Show();
            }
            else
            {
                Regle regle = new Regle(username, password);
                regle.Closed += (s, args) => this.Close();
                regle.Show();
            }
        }

        // Evenement clique pour le bouton commencer
        private void commencer_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (username == null && password == null)
            {
                Commencer commencer = new Commencer();
                commencer.Closed += (s, args) => this.Close();
                commencer.Show();
            }
            else
            {
                Commencer commencer = new Commencer(username, password);
                commencer.Closed += (s, args) => this.Close();
                commencer.Show();
            }
        }

        // Evenement clique pour le bouton connecter/s'inscrire
        private void connecter_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (username == null && password == null)
            {
                Connexion connexion = new Connexion();
                connexion.Closed += (s, args) => this.Close();
                connexion.Show();
            }
            else
            {
                Connexion connexion = new Connexion(username, password);
                connexion.Closed += (s, args) => this.Close();
                connexion.Show();
            }
        }

        // Bouton quitter l'application
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
