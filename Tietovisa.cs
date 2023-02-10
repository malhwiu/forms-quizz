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
            public Question(string topic, string question, string[] answers, uint rightAns)
                            => (this.topic, this.question, this.answers, this.rigthAnswer)=
                               (topic, question, answers, rightAns);
            public readonly string question;
            readonly string topic;
            public readonly string[] answers = new string[3];
            readonly uint rigthAnswer;
            public uint RightAnswer() {
                return rigthAnswer;
            }

        }
        uint CurrQuestion = 0;
        uint numOfQuestions = 3;
        List<Question> questions = new List<Question>();

        public void StartGame() {

            var con = new SQLiteConnection(Form1.conStr);
            con.Open();
            var cmd = con.CreateCommand();
            cmd.CommandText=$"SELECT * FROM tb_question LIMIT {numOfQuestions};";
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

        private void ValidateAnswer(object sender, System.EventArgs e) {
            var btn = (Button)sender;
            if(btn.Text==
               questions[(int)CurrQuestion].answers[questions[(int)CurrQuestion].RightAnswer()-1]) {
                MessageBox.Show("Oikein.");
            } else {
                MessageBox.Show("Väärin.");
            }
        }

        private void NextAnswer(object sender, System.EventArgs e) {
            CurrQuestion++;
            if(CurrQuestion>=numOfQuestions) {
                MessageBox.Show("Pääsit kysymysten loppuun.");

            } else {
                UpdateBtns(questions[(int)CurrQuestion].answers);
                LbQuestion.Text=questions[(int)CurrQuestion].question;
            }
        }

        public Tietovisa() {
            InitializeComponent();

        }
    }
}
