using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TietovisaForms {
    public partial class Tietovisa : Form {
        // I quess this works
        private class Question {
            public Question(string question, string[] answers, uint rightAns)
                        => (this.question, this.answers, this.rigthAnswer) = (question, answers, rightAns);
            public readonly string question;
            public readonly string[] answers = new string[3];
            public uint rigthAnswer { get; private set; }

        }

        List<Question> questions = new List<Question>();
        uint CurrQuestion = 0;
        uint defnumOfQuestions = 0; // Number of questions defined by user
        uint correctAnswers = 0;
        int realNumOfQuestions = 0; // Number of questions found in the database
        

        public void StartGame(string conStr, uint numOfQuestions) { //this method is called from Form1.cs

            if(numOfQuestions < 1) { throw new Exception("int numOfQuestions is lower than 1"); }

            defnumOfQuestions = numOfQuestions;

            var con = new SQLiteConnection(conStr);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText=$"SELECT * FROM tb_question ORDER BY RANDOM() LIMIT {defnumOfQuestions};"; //Nikolai: show questions in random order
            var reader = cmd.ExecuteReader();

            while(reader.Read()) {
                // TODO: Make this not a variable
                string[] qs = new string[3] { reader["Answer1"].ToString(),
                                              reader["Answer2"].ToString(),
                                              reader["Answer3"].ToString()};

                questions.Add(new Question(reader["Question"].ToString(),
                                           qs, // This should never fail
                                           uint.Parse(reader["Right_Answer"].ToString())));
            }

            realNumOfQuestions = questions.Count;
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
            counter.Text = $"{CurrQuestion + 1} / {realNumOfQuestions}";
        }
        /* Nikolai: Instead of indicating the correct answer with message "Oikein!", we are going to simply go to the next one.
         */
        private void ValidateAnswer(object sender, System.EventArgs e) {
            var btn = (Button)sender;
            if(btn.Text != questions[(int)CurrQuestion].answers[questions[(int)CurrQuestion].rigthAnswer - 1]) {
                MessageBox.Show("Väärin.");
            } else {
                correctAnswers++;
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
            if (CurrQuestion >= realNumOfQuestions) // Nikolai: potential bug fixed. If user chooses more then there are questions in the database, then unexpected behaviour would occur.
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
