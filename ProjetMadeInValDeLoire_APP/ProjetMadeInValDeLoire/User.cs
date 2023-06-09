﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetMadeInValDeLoire
{
    public class User
    {

        // Création d'utilisateur dans la BDD
        public void createUser(MySqlConnection bdd, String identifiant, String nom, String mdp, String prenom, Label lbl)
        {
            MySqlCommand cmd = (MySqlCommand)bdd.CreateCommand();
            String requete = "INSERT INTO `utilisateur`(`login`, `nom`, `password`, `prenom`) VALUES ('" + identifiant + "', '" + nom + "', '" + mdp + "', '" + prenom + "');";
            cmd.CommandText = requete;
            MySqlDataReader dr;
            try
            {
                // Connexion réussie à la BDD
                dr = cmd.ExecuteReader();
                lbl.Text = "Inscription réussie";
                lbl.ForeColor = Color.Green;
                dr.Close();
            }
            catch (MySqlException error)
            {
                // Connexion échoué à la BDD
                lbl.Text = "Une erreur est survenue lors de l'inscription, veuillez réessayer plus tard : " + error.Message;
                lbl.ForeColor = Color.Red;
            }
        }

        // Méthode permettant de hashé le mot de passe de l'utilisateur
        public string HashMdp(string text, string salt = "")
        {
            if (String.IsNullOrEmpty(text))
            {
                return String.Empty;
            }

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textBytes = System.Text.Encoding.UTF8.GetBytes(text + salt);
                byte[] hashBytes = sha.ComputeHash(textBytes);

                string hash = BitConverter
                    .ToString(hashBytes)
                    .Replace("-", String.Empty);

                return hash;
            }
        }
    }
}
