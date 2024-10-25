using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace onlinequizmanagementsystem
{
    public partial class quizform : Form
    {
        private List<Question> questions;
        private fuction fn = new fuction();
        private int currentQuestionIndex = 0;
        private List<string> userAnswers = new List<string>();
        private string currentStudentRegistrationNumber;
        private int remainingSeconds;


        public quizform(string setNumber, string registrationNumber)
        {
            InitializeComponent();
            currentStudentRegistrationNumber = registrationNumber;
            countdownTimer.Stop();
            LoadQuestions(setNumber);

            panel1.KeyDown += Panel1_KeyDown;

        }
        private void Panel1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && (e.KeyCode == Keys.C || e.KeyCode == Keys.V))
            {

                e.SuppressKeyPress = true;
            }
        }

        private void LoadQuestions(string setNumber)
        {
            questions = GetQuestionsFromDatabase(setNumber);
            InitializeUserAnswers();
            DisplayQuestion(currentQuestionIndex);
            remainingSeconds = questions.Count * 60;

            DisplayQuestion(currentQuestionIndex);


            countdownTimer.Interval = 1000;
            countdownTimer.Tick += CountdownTimer_Tick;
            countdownTimer.Start();


        }
        private void CountdownTimer_Tick(object sender, EventArgs e)
        {
            if (remainingSeconds > 0)
            {
                remainingSeconds--;
                int remainingMinutes = remainingSeconds / 60;
                int remainingSecondsInMinute = remainingSeconds % 60;
                lblremainingtime.Text = $"{remainingMinutes:D2}:{remainingSecondsInMinute:D2}";
            }
            else
            {
                countdownTimer.Stop();
                lblremainingtime.Text = "00:00";

            }
        }
        private List<Question> GetQuestionsFromDatabase(string setNumber)
        {
            List<Question> questions = new List<Question>();

            string query = "SELECT q.qId, q.qSet, q.qNo, q.Question, a.Answer AS AnswerText, o.Optionchar, o.OptionText " +
                           "FROM Questions q " +
                           "LEFT JOIN Answers a ON q.qId = a.qId " +
                           "LEFT JOIN Options o ON q.qId = o.qId " +
                           "WHERE q.qSet = '" + setNumber + "'";

            DataSet ds = fn.GetData(query);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                int questionId = (int)row["qId"];
                string questionSet = row["qSet"].ToString();
                int questionNumber = (int)row["qNo"];
                string questionText = row["Question"].ToString();
                string answerText = row["AnswerText"].ToString();
                string optionChar = row["Optionchar"].ToString();
                string optionText = row["OptionText"].ToString();

                Question question = questions.FirstOrDefault(q => q.QuestionId == questionId);

                if (question == null)
                {
                    question = new Question
                    {
                        QuestionId = questionId,
                        QuestionSet = questionSet,
                        QuestionNumber = questionNumber,
                        QuestionText = questionText,
                        Answer = answerText,
                        Options = new List<Option>()
                    };
                    questions.Add(question);
                }

                if (!string.IsNullOrEmpty(optionChar) && !string.IsNullOrEmpty(optionText))
                {
                    question.Options.Add(new Option
                    {
                        OptionChar = optionChar,
                        OptionText = optionText
                    });
                }
            }

            return questions;
        }
        private void InitializeUserAnswers()
        {
            for (int i = 0; i < questions.Count; i++)
            {
                userAnswers.Add("");
            }
        }


        private void DisplayQuestion(int index)
        {
            if (index >= 0 && index < questions.Count)
            {
                Question question = questions[index];
                ClearRadioButtons();
                lblquestion.Text = $"{question.QuestionNumber}. {question.QuestionText}";

                int optionIndex = 0;
                foreach (Option option in question.Options)
                {
                    optionIndex++;
                    RadioButton radioButton = null;
                    switch (optionIndex)
                    {
                        case 1:
                            radioButton = rboption1;
                            break;
                        case 2:
                            radioButton = rboption2;
                            break;
                        case 3:
                            radioButton = rboption3;
                            break;
                        case 4:
                            radioButton = rboption4;
                            break;
                    }
                    if (radioButton != null)
                    {
                        radioButton.Text = $"{option.OptionChar}. {option.OptionText}";
                        radioButton.Visible = true;
                    }
                }


                if (index < userAnswers.Count && !string.IsNullOrEmpty(userAnswers[index]))
                {
                    SetSelectedOption(userAnswers[index]);
                }

                btnprevious.Enabled = index > 0;
                btnnext.Enabled = index < questions.Count - 1;
            }
        }

        private void SetSelectedOption(string selectedOption)
        {
            switch (selectedOption)
            {
                case "A":
                    rboption1.Checked = true;
                    break;
                case "B":
                    rboption2.Checked = true;
                    break;
                case "C":
                    rboption3.Checked = true;
                    break;
                case "D":
                    rboption4.Checked = true;
                    break;
            }
        }
        private void ClearRadioButtons()
        {
            rboption1.Checked = false;
            rboption2.Checked = false;
            rboption3.Checked = false;
            rboption4.Checked = false;
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton selectedButton = (RadioButton)sender;
            if (selectedButton.Checked)
            {
                string selectedOption = selectedButton.Text.Substring(0, 1);
                if (currentQuestionIndex >= 0 && currentQuestionIndex < userAnswers.Count && userAnswers[currentQuestionIndex] != selectedOption)
                {
                    userAnswers[currentQuestionIndex] = selectedOption;
                }
            }
        }


        private void btnprevious_Click(object sender, EventArgs e)
        {
            UpdateUserAnswer();
            currentQuestionIndex--;
            DisplayQuestion(currentQuestionIndex);
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            UpdateUserAnswer();
            currentQuestionIndex++;
            DisplayQuestion(currentQuestionIndex);
        }
        private void UpdateUserAnswer()
        {
            string selectedOption = GetSelectedOption();
            if (currentQuestionIndex >= 0 && currentQuestionIndex < userAnswers.Count)
            {
                userAnswers[currentQuestionIndex] = selectedOption;
            }
        }
        private string GetSelectedOption()
        {
            if (rboption1.Checked)
                return "A";
            else if (rboption2.Checked)
                return "B";
            else if (rboption3.Checked)
                return "C";
            else if (rboption4.Checked)
                return "D";

            return "";
        }
        private void btnfinish_Click(object sender, EventArgs e)
        {
            int marksObtained = 1;

            for (int i = 0; i < questions.Count; i++)
            {
                Question question = questions[i];
                string userAnswer = userAnswers[i].Trim().ToLower();
                string correctAnswer = question.Answer.Trim().ToLower();

                string correctOptionChar = "";
                foreach (Option option in question.Options)
                {
                    if (option.OptionText.Trim().ToLower() == correctAnswer)
                    {
                        correctOptionChar = option.OptionChar.Trim().ToLower();
                        break;
                    }
                }


                if (userAnswer == correctOptionChar)
                {
                    marksObtained++;
                }
            }

            MessageBox.Show($"Total marks obtained: {marksObtained}. Moving to login page.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string nextQuizSet = GetNextQuizSet(questions[0].QuestionSet);
            if (!string.IsNullOrEmpty(nextQuizSet))
            {
                quizform nextQuizForm = new quizform(nextQuizSet, currentStudentRegistrationNumber);
                nextQuizForm.Show();
            }
            else
            {

                Form1 form = new Form1();
                form.Show();
            }

            this.Hide();
            StoreMarksInDatabase(currentStudentRegistrationNumber, questions[0].QuestionSet, marksObtained);
        }

        private string GetNextQuizSet(string currentQuizSet)
        {

            List<string> quizSets = GetAvailableQuizSets();


            int currentIndex = quizSets.IndexOf(currentQuizSet);


            if (currentIndex != -1 && currentIndex < quizSets.Count - 1)
            {
                remainingSeconds = 0;
                return quizSets[currentIndex + 1];
            }


            return null;
        }

        private List<string> GetAvailableQuizSets()
        {
            List<string> quizSets = new List<string>();


            string query = "SELECT DISTINCT qSet FROM Questions";
            DataSet ds = fn.GetData(query);


            foreach (DataRow row in ds.Tables[0].Rows)
            {
                quizSets.Add(row["qSet"].ToString());
            }

            return quizSets;
        }
        private void StoreMarksInDatabase(string registrationNumber, string quizSet, int marksObtained)
        {
            string query = "SELECT COUNT(*) FROM studentResults WHERE RegistrationNumber = '" + registrationNumber + "' AND QuizSet = '" + quizSet + "'";
            DataSet ds = fn.GetData(query);

            int count = 0;
            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            }

            if (count > 0)
            {
                MessageBox.Show("You have already attempted this quiz set.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            query = "INSERT INTO studentResults (RegistrationNumber, QuizSet, MarksObtained) VALUES ('" + registrationNumber + "', '" + quizSet + "', " + marksObtained + ")";
            fn.setData(query, "Marks stored successfully.", true);
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }

}
