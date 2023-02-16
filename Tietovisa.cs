using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TietovisaForms {
    public partial class Tietovisa : Form {
        // I quess this works
        public string Topic {
            get {
                return TopicSelect.SelectedText.ToString();
            }
            set {
                TopicSelect.Items.Add(value);
            }
        }
        private class Question {
            public Question(string topic, string question, string[] answers, uint rightAns) => (this.topic, this.question, this.answers, this.rigthAnswer) = (topic, question, answers, rightAns);
            public readonly string question;
            readonly string topic;
            public readonly string[] answers = new string[3];
            readonly uint rigthAnswer;
            public uint RightAnswer() {
                return rigthAnswer;
            }

        }

        uint CurrQuestion = 0;
        uint numOfQuestions = 4;
        List<Question> questions = new List<Question>();

        public void StartGame(string conStr) { //this method is called from Form1.cs

            var con = new SQLiteConnection(conStr);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText=$"SELECT * FROM tb_question ORDER BY RANDOM() LIMIT {numOfQuestions};"; //Nikolai: questions are in random order
            var reader = cmd.ExecuteReader();

            while(reader.Read()) {
                // TODO: Make this not a variable
                string[] qs = new string[3] { reader["Answer1"].ToString(),
                                              reader["Answer2"].ToString(),
                                              reader["Answer3"].ToString()};

                questions.Add(new Question(reader["Topic"].ToString(),
                                           reader["Question"].ToString(),
                                           qs, // This should never fail
                                           uint.Parse(reader["Right_Answer"].ToString())));
            }
            con.Clone();
            // Show the current answer
            RefreshAnswer();
        }

        private void RefreshAnswer() {
            UpdateBtns(questions[(int)CurrQuestion].answers);
            LbQuestion.Text=questions[(int)CurrQuestion].question;
        }

        private void UpdateBtns(string[] questions) {
            BtnQuestion1.Text=questions[0];
            BtnQuestion2.Text=questions[1];
            BtnQuestion3.Text=questions[2];
        }
        /* Nikolai: Instead of indicating the correct answer with message "Oikein!", we are going to simply go to the next one.
         */
        private void ValidateAnswer(object sender, System.EventArgs e) {
            var btn = (Button)sender;
            if(btn.Text != questions[(int)CurrQuestion].answers[questions[(int)CurrQuestion].RightAnswer()-1]) {
                MessageBox.Show("Väärin.");
            } else {
                GoNext();
            }
        }

        /* Nikolai: Had to move everything to GoNext() method, because this one is called from button thus cannot be simply called from other places in the code*/
        private void NextAnswer(object sender, System.EventArgs e) {
            GoNext();
        }

        private void GoNext()
        {
            CurrQuestion++;
            if (CurrQuestion >= numOfQuestions)
            {
                MessageBox.Show("Pääsit kysymysten loppuun.");
                // put stats in the future
            }
            else
            {
                UpdateBtns(questions[(int)CurrQuestion].answers);
                LbQuestion.Text = questions[(int)CurrQuestion].question;
            }
        }

        public Tietovisa() {
            InitializeComponent();

        }
    }
}
