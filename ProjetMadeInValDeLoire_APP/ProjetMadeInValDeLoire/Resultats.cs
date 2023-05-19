using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
    public partial class Resultats : Form
    {
        private String username;
        private String password;
        private double score;
        private int niveau;
        MySqlConnection laConnection;
        User user = new User();

        // Méthode permettant d'afficher la page résultat sans que l'utilisateur se soit connecté.
        public Resultats(double score, int niveau)
        {
            InitializeComponent();
            this.score = score;
            this.niveau = niveau;
            txtTitre.Text = "Voici ton score : " + score + "%";
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
                message.Text = "Connexion ratée : " + ex.Message;
                message.ForeColor = Color.Red;
            }

            btnEnregistrer.Visible = false;
            txtInsMdp.UseSystemPasswordChar = true;
        }

        // Méthode permettant d'afficher la page résultat lorsque l'utilisateur c'est connecté.
        public Resultats(String username, String password, double score, int niveau)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.score = score;
            this.niveau = niveau;
            txtTitre.Text = "Voici ton score : " + score + "%";
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
                message.Text = "Connexion ratée : " + ex.Message;
                message.ForeColor = Color.Red;
            }
            label3.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button1.Visible = false;
            connecter.Visible = false;
            inscrire.Visible = false;
            txtInsIden.Visible = false;
            txtInsMdp.Visible = false;
            txtInsNom.Visible = false;
            txtInsPre.Visible = false;
            txtInsMdp.UseSystemPasswordChar = true;
        }

        // Evenement clique pour le bouton enregistrer
        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scoreboard scoreboard = new Scoreboard(niveau, username, password);
            scoreboard.Closed += (s, args) => this.Close();
            scoreboard.Show();
        }

        // Evenement clique pour le bouton accueil
        private void btnAccueil_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (username == null && password == null)
            {
                Accueil accueil = new Accueil();
                accueil.Closed += (s, args) => this.Close();
                accueil.Show();
            }
            else
            {
                Accueil accueil = new Accueil(username, password);
                accueil.Closed += (s, args) => this.Close();
                accueil.Show();
            }
        }

        // Evenement clique pour le bouton pour voir le mot de passe
        private void voirMDP_Click(object sender, EventArgs e)
        {
            if (txtInsMdp.UseSystemPasswordChar == true)
            {
                txtInsMdp.UseSystemPasswordChar = false;
            }
            else if (txtInsMdp.UseSystemPasswordChar == false)
            {
                txtInsMdp.UseSystemPasswordChar = true;
            }
        }

        // Evenement clique pour le bouton connecter
        private void connecter_Click(object sender, EventArgs e)
        {
            if (txtInsIden.Text.Length != 0 && txtInsMdp.Text.Length != 0)
            {
                MySqlCommand cmd = (MySqlCommand)laConnection.CreateCommand();
                String requete = "SELECT login, password FROM utilisateur WHERE login LIKE '" + txtInsIden.Text + "' AND password LIKE '" + user.HashMdp(txtInsMdp.Text) + "';";
                cmd.CommandText = requete;
                MySqlDataReader dr;
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        MySqlCommand cmd2 = (MySqlCommand)laConnection.CreateCommand();
                        String requete2 = "SELECT score FROM score WHERE CLE_login LIKE '" + txtInsIden.Text + "' AND CLE_quiz =" + niveau + ";";
                        cmd2.CommandText = requete2;
                        MySqlDataReader dr2;
                        try
                        {
                            dr2 = cmd2.ExecuteReader();
                            if (dr2.HasRows)
                            {
                                int scoreIndex = dr2.GetOrdinal("score");
                                while (dr2.Read())
                                {
                                    int score = dr2.GetInt32(scoreIndex);

                                    if (score < this.score)
                                    {
                                        dr2.Close();
                                        MySqlCommand cmd3 = (MySqlCommand)laConnection.CreateCommand();
                                        String requete3 = "UPDATE `score` SET `score`=" + this.score + " WHERE CLE_login LIKE '" + txtInsIden.Text + "'AND CLE_quiz = " + niveau + ";";
                                        cmd3.CommandText = requete3;
                                        MySqlDataReader dr3;
                                        try
                                        {
                                            dr3 = cmd3.ExecuteReader();
                                            dr3.Close();
                                        }
                                        catch (MySqlException error)
                                        {
                                            message.Text = error.Message;
                                        }
                                    }
                                    else
                                    {
                                        dr2.Close();
                                    }
                                }
                            }
                            else
                            {
                                dr2.Close();
                                MySqlCommand cmd3 = (MySqlCommand)laConnection.CreateCommand();
                                String requete3 = "INSERT INTO `score`(`CLE_login`, `CLE_quiz`, `score`) VALUES ('" + txtInsIden.Text + "','" + niveau + "','" + score + "');";
                                cmd3.CommandText = requete3;
                                MySqlDataReader dr3;
                                try
                                {
                                    dr3 = cmd3.ExecuteReader();
                                    dr3.Close();
                                }
                                catch (MySqlException error)
                                {
                                    message.Text = error.Message;
                                }
                            }
                        }
                        catch { }
                        
                        message.Text = "Connexion réussie";
                        message.ForeColor = Color.Green;
                        this.Hide();
                        fermetureConnexion();
                        Scoreboard scoreboard = new Scoreboard(niveau, txtInsIden.Text, user.HashMdp(txtInsMdp.Text));
                        scoreboard.Closed += (s, args) => this.Close();
                        scoreboard.Show();
                    }
                    else if (!dr.HasRows)
                    {
                        dr.Close();
                        message.Text = "Identifiant ou mot de passe incorrect";
                        message.ForeColor = Color.Red;
                    }
                }
                catch (MySqlException error)
                {
                    message.Text = "Une erreur est survenue : " + error.Message;

                }
            }
            else
            {
                message.Text = "Merci de remplir tout les champs demandés.";
                message.ForeColor = Color.Red;
            }
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

        // Evenement clique pour le bouton inscrire
        private async void inscrire_Click(object sender, EventArgs e)
        {
            if (txtInsIden.Text.Length != 0 && txtInsMdp.Text.Length != 0 && txtInsPre.Text.Length != 0 && txtInsNom.Text.Length != 0)
            {
                MySqlCommand cmd = (MySqlCommand)laConnection.CreateCommand();
                String requete = "SELECT login FROM utilisateur WHERE login LIKE '" + txtInsIden.Text + "';";
                cmd.CommandText = requete;
                MySqlDataReader dr;
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        message.Text = "Compte déjà existant";
                        message.ForeColor = Color.Red;
                    }
                    else if (!dr.HasRows)
                    {
                        dr.Close();
                        user.createUser(laConnection, txtInsIden.Text, txtInsNom.Text, user.HashMdp(txtInsMdp.Text), txtInsPre.Text, message);

                        MySqlCommand cmd3 = (MySqlCommand)laConnection.CreateCommand();
                        String requete3 = "INSERT INTO `score`(`CLE_login`, `CLE_quiz`, `score`) VALUES ('" + txtInsIden.Text + "','" + niveau + "','" + score + "');";
                        cmd3.CommandText = requete3;
                        MySqlDataReader dr3;
                        try
                        {
                            dr3 = cmd3.ExecuteReader();
                            dr3.Close();
                        }
                        catch (MySqlException error)
                        {
                            message.Text = error.Message;
                        }
                    }
                }
                catch (MySqlException error)
                {
                    message.Text = "Une erreur est survenue : " + error.Message;

                }
                this.Hide();
                fermetureConnexion();
                Scoreboard scoreboard = new Scoreboard(niveau, txtInsIden.Text, user.HashMdp(txtInsMdp.Text));
                scoreboard.Closed += (s, args) => this.Close();
                scoreboard.Show();
            }
            else
            {
                message.Text = "Merci de remplir tout les champs demandés.";
                message.ForeColor = Color.Red;
            }
        }
    }
}
