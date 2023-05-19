using Microsoft.Win32;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMadeInValDeLoire
{
    public partial class Scoreboard : Form
    {
        private int niveau;
        private String username;
        private String password;
        MySqlConnection laConnection;
        public Scoreboard(int niveau, String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.niveau = niveau;
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
            }

            List<string> top10Scores = new List<string>();

            // Permet de récupérer les 10 meilleurs scores
            string query = "SELECT CLE_login, score FROM score WHERE CLE_quiz = " + niveau + " ORDER BY score DESC LIMIT 10;";

            try
            {
                using (laConnection)
                {
                    MySqlCommand command = new MySqlCommand(query, laConnection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string login = reader.GetString(0);
                            int score = reader.GetInt32(1);
                            top10Scores.Add($"{login} : {score}%");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
            }

            List<Label> textBoxes = new List<Label> { txtTop1, txtTop2, txtTop3, txtTop4, txtTop5, txtTop6, txtTop7, txtTop8, txtTop9, txtTop10 };

            // Met les scores dans les label avec une boucle for
            for (int i = 0; i < top10Scores.Count; i++)
            {
                textBoxes[i].Text = $"{i + 1} - {top10Scores[i]}";
            }
        }

        // Evenement clique pour le bouton accueil
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            Accueil accueil = new Accueil(username, password);
            accueil.Closed += (s, args) => this.Close();
            accueil.Show();
        }


        // Permet d'ouvrir la connexion avec la BDD
        private bool ouvertureConnexion()
        {
            bool retour = true;
            try
            {
                laConnection.Open();
            }
            catch (MySqlException e)
            {
                retour = false;
            }
            return retour;
        }

        // Permet de fermer la connexion avec la BDD
        private bool fermetureConnexion()
        {
            bool retour = true;
            try
            {
                laConnection.Close();
            }
            catch (MySqlException e)
            {
                retour = false;
            }
            return retour;
        }
    }
}
