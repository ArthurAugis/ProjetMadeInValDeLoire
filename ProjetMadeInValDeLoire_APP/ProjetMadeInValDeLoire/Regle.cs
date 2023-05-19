using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjetMadeInValDeLoire
{
    public partial class Regle : Form
    {
        private String username;
        private String password;

        public Regle()
        {
            InitializeComponent();
        }

        public Regle(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void button1_Click(object sender, EventArgs e)
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
    }
}
