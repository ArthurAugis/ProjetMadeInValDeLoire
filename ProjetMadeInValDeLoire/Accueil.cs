﻿using System;
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
        public Accueil()
        {
            InitializeComponent();
        }


        private void regle_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regle regle = new Regle();
            regle.Closed += (s, args) => this.Close();
            regle.Show();
        }

        private void commencer_Click(object sender, EventArgs e)
        {
            this.Hide();
            Commencer commencer = new Commencer();
            commencer.Closed += (s, args) => this.Close();
            commencer.Show();
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            this.Hide();
            Connexion connexion = new Connexion();
            connexion.Closed += (s, args) => this.Close();
            connexion.Show();
        }
    }
}
