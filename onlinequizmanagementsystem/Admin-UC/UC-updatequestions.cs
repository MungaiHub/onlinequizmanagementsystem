using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlinequizmanagementsystem.Admin_UC
{
    public partial class UC_updatequestions : UserControl
    {
        fuction fn = new fuction();
        string query;
        public UC_updatequestions()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxquestion.Items.Clear();
            query = $"SELECT qNo FROM Questions WHERE qSet = '{comboBoxset.Text}'";
            DataSet ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                comboBoxquestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UC_updatequestions_Load(object sender, EventArgs e)
        {
            LoadQuestionSets();
        }

        private void comboBoxquestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestionDetails();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            clearall();
        }
        public void clearall()
        {
           
         txtquestion.Clear();
         txtoption1.Clear();
         txtoption2.Clear();
         txtoption3.Clear();
         txtoption4.Clear();
         txtanswer.Clear();
             comboBoxset.SelectedIndex = -1;
            comboBoxquestion.SelectedIndex = -1;


        }

        private void btnupdate_Click(object sender, EventArgs e)
            
            {
                UpdateQuestion();
        }
  
    private void btnsync_Click(object sender, EventArgs e)
        {
            LoadQuestionSets();
        }
        private void LoadQuestionSets()
        {
            comboBoxset.Items.Clear();
            query = "SELECT DISTINCT qSet FROM Questions";
            DataSet ds = fn.GetData(query);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBoxset.Items.Add(row["qSet"].ToString());
            }
        }

        private void LoadQuestionDetails()
        {
            string qSet = comboBoxset.Text;
            int qNo = int.Parse(comboBoxquestion.Text);

            LoadOptionText(qSet, qNo, "A", txtoption1);
            LoadOptionText(qSet, qNo, "B", txtoption2);
            LoadOptionText(qSet, qNo, "C", txtoption3);
            LoadOptionText(qSet, qNo, "D", txtoption4);

            query = $"SELECT Question, Answer FROM Questions Q " +
                    $"LEFT JOIN Answers A ON Q.qId = A.qId " +
                    $"WHERE Q.qSet = '{qSet}' AND Q.qNo = {qNo}";

            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                txtquestion.Text = ds.Tables[0].Rows[0]["Question"].ToString();
                txtanswer.Text = ds.Tables[0].Rows[0]["Answer"].ToString();
            }
        }
        private void LoadOptionText(string qSet, int qNo, string optionChar, TextBox textBox)
        {
            query = $"SELECT O.OptionText " +
                    $"FROM Questions Q " +
                    $"INNER JOIN Options O ON Q.qId = O.qId " +
                    $"WHERE Q.qSet = '{qSet}' AND Q.qNo = {qNo} AND O.Optionchar = '{optionChar}'";

            DataSet ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                textBox.Text = ds.Tables[0].Rows[0]["OptionText"].ToString();
            }
            else
            {
                // Clear the text box if no option is found
                textBox.Text = "";
            }
        }


        private void UpdateQuestion()
        {
            if (comboBoxquestion.SelectedIndex != -1)
            {
                string qSet = comboBoxset.Text;
                string qNo = comboBoxquestion.Text;
                string question = txtquestion.Text;
                string Option1 = txtoption1.Text;
                string Option2 = txtoption2.Text;
                string Option3 = txtoption3.Text;
                string Option4 = txtoption4.Text;
                string answer = txtanswer.Text;

                query = $"UPDATE Questions SET Question = '{question}' WHERE qSet = '{qSet}' AND qNo = {qNo}";
                fn.setData(query, $"Question {qNo} in set {qSet} is updated.",true);

               
                UpdateOptionsAndAnswers(qSet, qNo, Option1, Option2, Option3, Option4, answer);
            }
            else
            {
                MessageBox.Show("Select a question first.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateOptionsAndAnswers(string qSet, string qNo, string Option1, string Option2, string Option3, string Option4, string answer)
        {
            
            query = $"UPDATE Options SET OptionText = '{Option1}' WHERE qId IN (SELECT qId FROM Questions WHERE qSet = '{qSet}' AND qNo = {qNo} AND Optionchar = 'A')";
            fn.setData(query, "",false);

            query = $"UPDATE Options SET OptionText = '{Option2}' WHERE qId IN (SELECT qId FROM Questions WHERE qSet = '{qSet}' AND qNo = {qNo} AND Optionchar = 'B')";
            fn.setData(query, "", false);

            query = $"UPDATE Options SET OptionText = '{Option3}' WHERE qId IN (SELECT qId FROM Questions WHERE qSet = '{qSet}' AND qNo = {qNo} AND Optionchar = 'C')";
            fn.setData(query, "",false);

            query = $"UPDATE Options SET OptionText = '{Option4}' WHERE qId IN (SELECT qId FROM Questions WHERE qSet = '{qSet}' AND qNo = {qNo} AND Optionchar = 'D')";
            fn.setData(query, "",false);

            query = $"UPDATE Answers SET Answer = '{answer}' WHERE qId IN (SELECT qId FROM Questions WHERE qSet = '{qSet}' AND qNo = {qNo})";
            fn.setData(query, "",false);
        }
    }
}


        // private void UC_updatequestions_Load(object sender, EventArgs e)
        //{

        //}

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
    

