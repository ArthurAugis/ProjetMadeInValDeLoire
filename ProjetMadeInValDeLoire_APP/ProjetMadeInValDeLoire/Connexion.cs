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
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void inscrire_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Inscription réussie";
            lblMessage.ForeColor = Color.Green;
        }

        private void btnConnecter_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "Connexion réussie";
            lblMessage.ForeColor = Color.Green;
        }
    }
}
