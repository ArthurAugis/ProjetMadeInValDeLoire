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
    public partial class Question : Form
    {

        private int questionsNbr;
        private int niveau;
        private String username;
        private String password;
        MySqlConnection laConnection;
        List<QuestionData> questions = new List<QuestionData>();
        private int points;
        private String bonnereponse;

        // Méthode permettant d'ouvrir la page avec une question suivant le niveau
        public Question(int niveau)
        {
            InitializeComponent();
            this.niveau = niveau;
            questionsNbr = 1;
            lblNbrQuestions.Text = questionsNbr + "/" + getNbrQuestions();
            getDifficulte();
            getQuestion();
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
            }
        }

        // Méthode permettant d'ouvrir la page avec une question suivant le niveau si il y a déjà une question répondue
        public Question(int niveau, int questionNbr, int points, List<QuestionData> questions)
        {
            InitializeComponent();
            this.niveau = niveau;
            questionsNbr = questionNbr;
            this.points = points;
            this.questions = questions;
            lblNbrQuestions.Text = questionsNbr + "/" + getNbrQuestions();
            getDifficulte();
            getQuestion();
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
            }
        }

        // Méthode permettant d'ouvrir la page avec une question suivant le niveau si l'utilisateur c'est connecté
        public Question(int niveau, String username, String password)
        {
            InitializeComponent();
            this.niveau = niveau;
            questionsNbr = 1;
            lblNbrQuestions.Text = questionsNbr + "/" + getNbrQuestions();
            this.username = username;
            this.password = password;
            getDifficulte();
            getQuestion();
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
            }
        }

        // Méthode permettant d'ouvrir la page avec une question suivant le niveau si l'utilisateur c'est connecté et qu'il a répondu à une question
        public Question(int niveau, int questionNbr, String username, String password, int points, List<QuestionData> questions)
        {
            InitializeComponent();
            this.niveau = niveau;
            this.points = points;
            this.questions = questions;
            questionsNbr = questionNbr;
            lblNbrQuestions.Text = questionsNbr + "/" + getNbrQuestions();
            this.username = username;
            this.password = password;
            getDifficulte();
            getQuestion();
            try
            {
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString);
                ouvertureConnexion();
            }
            catch (MySqlException ex)
            {
            }
        }

        // Permet de récupérer le nombre de questions
        private int getNbrQuestions()
        {
            int numRows = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM verifier WHERE CLE_quiz = @niveau";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@niveau", niveau);
                    try
                    {
                        connection.Open();
                        numRows = Convert.ToInt32(command.ExecuteScalar());
                    }
                    catch (Exception ex){
                        lblNbrQuestions.Text = ex.Message;
                    }
                }
            }
            return numRows;
        }

        // Permet de récupérer la difficulté choisie par le joueurs
        private void getDifficulte()
        {
            string difficulte = "";
            string connectionString = ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT nom_diff FROM difficulte WHERE CLP_difficulte = @niveau";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@niveau", niveau);
                    try
                    {
                        connection.Open();
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                difficulte = reader.GetString(0);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                }
            }
            this.difficulte.Text = "Difficulté : " + difficulte;
            this.difficulte.Left = (this.ClientSize.Width - this.difficulte.Size.Width) / 2;
        }

        // Permet de récupérer la question et les réponses dans la BDD
        private void getQuestion()
        {
            string question = "";
            int clp = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["connexionBdd"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT questions.question, questions.CLP_question FROM questions INNER JOIN verifier ON CLE_question = CLP_question WHERE verifier.CLE_quiz = @niveau";
                if (questions.Count == 0)
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@niveau", niveau);
                        try
                        {
                            connection.Open();
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    question = reader.GetString(0);
                                    clp = reader.GetInt32(1);
                                    QuestionData questionData = new QuestionData { Question = question, Clp = clp };
                                    questions.Add(questionData);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            // Handle the exception
                        }
                    }
                }

                Random random = new Random();
                int randomQuest = random.Next(questions.Count);
                QuestionData randomQuestion = questions[randomQuest];
                lblQuestion.Text = randomQuestion.Question;
                string query2 = "SELECT repondre.good_rep, reponse.reponse FROM repondre INNER JOIN reponse ON CLP_reponse = CLE_reponse WHERE repondre.CLE_question = @ques";
                using (MySqlCommand command = new MySqlCommand(query2, connection))
                {
                    command.Parameters.AddWithValue("@ques", randomQuestion.Clp);
                    try
                    {
                        if (connection.State != ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            int i = 0;
                            while (reader.Read())
                            {
                                if (reader.GetInt32(0) == 1)
                                {
                                    bonnereponse = reader.GetString(1);
                                }
                                if (i == 0)
                                {
                                    reponse1.Text = reader.GetString(1);
                                }
                                else if (i == 1)
                                {
                                    reponse2.Text = reader.GetString(1);
                                }
                                else if (i == 2)
                                {
                                    reponse3.Text = reader.GetString(1);
                                }
                                i++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        difficulte.Text = ex.Message;
                    }
                }
                questions.Remove(randomQuestion);
            }
            lblQuestion.Left = (this.ClientSize.Width - lblQuestion.Size.Width) / 2;
        }

        // Permet de mettre la prochaine question ou d'aller à la page résultat
        private void nextQuestion()
        {
            if (questionsNbr < getNbrQuestions())
            {
                this.Hide();
                if (username == null && password == null)
                {
                    Question quest = new Question(niveau, questionsNbr + 1, points, questions);
                    quest.Closed += (s, args) => this.Close();
                    quest.Show();
                }
                else
                {
                    Question quest = new Question(niveau, questionsNbr + 1, username, password, points, questions);
                    quest.Closed += (s, args) => this.Close();
                    quest.Show();
                }
            }
            else if (questionsNbr >= getNbrQuestions())
            {
                this.Hide();
                double score = 0;
                if (points == 0)
                {
                    score = 0;
                }
                else
                {
                    score = (points * 100) / getNbrQuestions();
                }
                if (username == null && password == null)
                {
                    
                    Resultats result = new Resultats(score, niveau);
                    result.Closed += (s, args) => this.Close();
                    result.Show();
                }
                else
                {
                    Resultats result = new Resultats(username, password, score, niveau);
                    result.Closed += (s, args) => this.Close();
                    result.Show();
                }
            }
        }

        // Permet de fermer la connexion avec la BDD
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

        // Evenement clique pour le bouton réponse 1
        private void reponse1_Click(object sender, EventArgs e)
        {
            if (reponse1.Text == bonnereponse)
            {
                points = points + 1;
            }
            nextQuestion();

        }

        // Evenement clique pour le bouton réponse 2
        private void reponse2_Click(object sender, EventArgs e)
        {
            if (reponse2.Text == bonnereponse)
            {
                points = points + 1;
            }
            nextQuestion();

        }

        // Evenement clique pour le bouton réponse 3
        private void reponse3_Click(object sender, EventArgs e)
        {
            if (reponse3.Text == bonnereponse)
            {
                points = points + 1;
            }
            nextQuestion();
        }

        private void difficulte_Click(object sender, EventArgs e)
        {

        }
    }
}
