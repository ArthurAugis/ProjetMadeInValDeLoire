using MySql.Data.MySqlClient;
using System;
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
    public partial class Connexion : Form
    {
        MySqlConnection laConnection;
        User user = new User();

        // Méthode pour ouvrir la page connexion
        public Connexion()
        {
            InitializeComponent();
            txtInsMdp.UseSystemPasswordChar = true;
            txtConnMdp.UseSystemPasswordChar = true;
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

        // Evenement clique pour le bouton inscrire
        private void inscrire_Click(object sender, EventArgs e)
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
                        this.Hide();
                        fermetureConnexion();
                        Commencer commencer = new Commencer(txtInsIden.Text, txtInsMdp.Text);
                        commencer.Closed += (s, args) => this.Close();
                        commencer.Show();
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

        // Evenement clique pour le bouton connecter
        private void btnConnecter_Click(object sender, EventArgs e)
        {
            if (txtConnIden.Text.Length != 0 && txtConnMdp.Text.Length != 0)
            {
                MySqlCommand cmd = (MySqlCommand)laConnection.CreateCommand();
                String requete = "SELECT login, password FROM utilisateur WHERE login LIKE '" + txtConnIden.Text + "' AND password LIKE '" + user.HashMdp(txtConnMdp.Text) + "';";
                cmd.CommandText = requete;
                MySqlDataReader dr;
                try
                {
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Close();
                        message.Text = "Connexion réussie";
                        message.ForeColor = Color.Green;
                        this.Hide();
                        fermetureConnexion();
                        Commencer commencer = new Commencer(txtConnIden.Text, txtConnMdp.Text);
                        commencer.Closed += (s, args) => this.Close();
                        commencer.Show();
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

        // Evenement clique pour voir le mot de passe
        private void voirMDP(object sender, EventArgs e)
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

        private void voirPass(object sender, EventArgs e)
        {
            if (txtConnMdp.UseSystemPasswordChar == true)
            {
                txtConnMdp.UseSystemPasswordChar = false;
            }
            else if (txtConnMdp.UseSystemPasswordChar == false)
            {
                txtConnMdp.UseSystemPasswordChar = true;
            }
        }
    }
}
