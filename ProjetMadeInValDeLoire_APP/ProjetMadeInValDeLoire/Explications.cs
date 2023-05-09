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
    public partial class Explications : Form
    {
        public Explications()
        {
            InitializeComponent();
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
