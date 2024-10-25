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
    public partial class UC_addnewquestion : UserControl
    {


        fuction fn = new fuction();
        string query;
        DataSet ds;
       Int64 questionNo = 1;


        public UC_addnewquestion()
        {
            InitializeComponent();
        }

        private void UC_addnewquestion_Load(object sender, EventArgs e)
        {
            query = "Select max(qset) from questions";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
            {
                Int64 qid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtset.Text = (qid + 1).ToString();
            }
            else
            {
                txtset.Text = "1";

            }
            Questionlabel.Text = questionNo.ToString();
            labelNOSET.Visible = false;
        }

      

        private void btnnext_Click(object sender, EventArgs e)
        {
            string qset = txtset.Text;
            string qNo = questionNo.ToString();
            string question = txtquestion.Text;
            string answer = txtanswer.Text;

            query = "INSERT INTO questions (qSet, qNo, Question) VALUES ('" + qset + "','" + qNo + "','" + question + "')";
            fn.setData(query, "Question Added", true); 

            query = "SELECT qId FROM questions WHERE qSet = '" + qset + "' AND qNo = '" + qNo + "'";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string qId = ds.Tables[0].Rows[0]["qId"].ToString();

                InsertOption(qId, "A", txtoption1.Text);
                InsertOption(qId, "B", txtoption2.Text);
                InsertOption(qId, "C", txtoption3.Text);
                InsertOption(qId, "D", txtoption4.Text);
                InsertAnswer(qId, answer);
            }

            clearAll();
            questionNo++;
            Questionlabel.Text = questionNo.ToString();
        }

        private void InsertOption(string qId, string optionChar, string optionText)
        {
            query = "INSERT INTO Options (qId, Optionchar, OptionText) VALUES ('" + qId + "', '" + optionChar + "', '" + optionText + "')";
            fn.setData(query, "",false);
        }

        private void InsertAnswer(string qId, string answer)
        {


            query = "INSERT INTO Answers (qId, Answer) VALUES ('" + qId + "', '" + answer + "')";
            fn.setData(query, "",false);


        }
        public void clearAll()
        {
            txtquestion.Clear();
            txtoption1.Clear();
            txtoption2.Clear();
            txtoption3.Clear();
            txtoption4.Clear();
            txtanswer.Clear();


        }

        // private void txtset_TextChanged(object sender, EventArgs e)
        //{

        //}

        private void btnreset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("unsaved data will be lost", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                clearAll();
                questionNo = 1;
                Questionlabel.Text = questionNo.ToString();

            }
        }

        private void btnfinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("set will be changed", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtset.Text = (Int64.Parse(txtset.Text.ToString()) + 1).ToString();
                Questionlabel.Text = "1";
            }
        }

        private void txtset_TextChanged(object sender, EventArgs e)
        {
            if (txtset.Text != "")
            {
                clearAll();
                query = "select qNo from questions where qSet='" + txtset.Text + "'";
                ds = fn.GetData(query);
                if (ds.Tables[0].Rows.Count != 0 && ds.Tables[0].Rows[0][0].ToString() != "")
                {
                    Questionlabel.Text = (ds.Tables[0].Rows.Count + 1).ToString();
                    questionNo = Int64.Parse(Questionlabel.Text.ToString());
                }
                else
                {
                    Questionlabel.Text = "1";
                    questionNo = Int64.Parse(Questionlabel.Text.ToString());
                    labelNOSET.Visible = true;

                }
            }
        }
    }
}
