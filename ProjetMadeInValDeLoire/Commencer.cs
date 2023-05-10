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
    public partial class Commencer : Form
    {

        private String username;
        private String password;

        public Commencer()
        {
            InitializeComponent();
        }

        public Commencer(String username, String password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void difficulte1_Click(object sender, EventArgs e)
        {
            start("Collégiens");
        }

        private void difficulte2_Click(object sender, EventArgs e)
        {
            start("Lycéens");
        }

        private void difficulte3_Click(object sender, EventArgs e)
        {
            start("Etudiants");
        }

        private void difficulte4_Click(object sender, EventArgs e)
        {
            start("Professionnels");
        }

        private void start(String difficulte)
        {
            this.Hide();
            if (username == null && password == null)
            {
                Question quest = new Question(difficulte);
                quest.Closed += (s, args) => this.Close();
                quest.Show();
            }
            else
            {
                Question quest = new Question(difficulte, username, password);
                quest.Closed += (s, args) => this.Close();
                quest.Show();
            }
        }
    }
}
