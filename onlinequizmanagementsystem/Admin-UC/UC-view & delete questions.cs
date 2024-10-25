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
    public partial class UC_view___delete_questions : UserControl
    {
        fuction fn = new fuction();
        string query;

        public UC_view___delete_questions()
        {
            InitializeComponent();
        }

        private void UC_view___delete_questions_Load(object sender, EventArgs e)
        {
            LoadQuestionSets();
        }

        private void LoadQuestionSets()
        {
            comboBoxset.Items.Clear();
            comboBoxset.Items.Add("All Questions");
            query = "select distinct qSet from questions";
            DataSet ds = fn.GetData(query);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                comboBoxset.Items.Add(row["qSet"].ToString());
            }
        }

        private void comboBoxset_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadQuestions();
        }

        private void LoadQuestions()
        {
            if (comboBoxset.SelectedIndex != 0)
            {
                query = "SELECT Q.qId, Q.qNo, Q.Question, O1.OptionText AS OptionA, O2.OptionText AS OptionB, O3.OptionText AS OptionC, O4.OptionText AS OptionD, A.Answer " +
                        "FROM Questions Q " +
                        "LEFT JOIN Options O1 ON Q.qId = O1.qId AND O1.Optionchar = 'A' " +
                        "LEFT JOIN Options O2 ON Q.qId = O2.qId AND O2.Optionchar = 'B' " +
                        "LEFT JOIN Options O3 ON Q.qId = O3.qId AND O3.Optionchar = 'C' " +
                        "LEFT JOIN Options O4 ON Q.qId = O4.qId AND O4.Optionchar = 'D' " +
                        "LEFT JOIN Answers A ON Q.qId = A.qId " +
                        "WHERE Q.qSet = '" + comboBoxset.Text + "'";
            }
            else
            {
                query = "SELECT Q.qId, Q.qNo, Q.Question, O1.OptionText AS OptionA, O2.OptionText AS OptionB, O3.OptionText AS OptionC, O4.OptionText AS OptionD, A.Answer " +
                        "FROM Questions Q " +
                        "LEFT JOIN Options O1 ON Q.qId = O1.qId AND O1.Optionchar = 'A' " +
                        "LEFT JOIN Options O2 ON Q.qId = O2.qId AND O2.Optionchar = 'B' " +
                        "LEFT JOIN Options O3 ON Q.qId = O3.qId AND O3.Optionchar = 'C' " +
                        "LEFT JOIN Options O4 ON Q.qId = O4.qId AND O4.Optionchar = 'D' " +
                        "LEFT JOIN Answers A ON Q.qId = A.qId";
            }

            DataSet ds = fn.GetData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnsync_Click(object sender, EventArgs e)
        {
            LoadQuestionSets();
            LoadQuestions();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure?", "Delete Confirmation !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (qId != 0)
                {
                    query = "DELETE FROM Options WHERE qId = " + qId;
                    fn.setData(query, "",false);

                    query = "DELETE FROM Answers WHERE qId = " + qId;
                    fn.setData(query, "",false);

                    query = "DELETE FROM Questions WHERE qId = " + qId + " AND qNo = " + qNo;
                    fn.setData(query, "Question Deleted.",true);

                    LoadQuestions();
                }
                else
                {
                    MessageBox.Show("Please select a question to delete.", "No Question Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        int qId, qNo;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                qId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["qId"].Value.ToString());
                qNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["qNo"].Value.ToString());
            }
            catch { }
        }
    }
}