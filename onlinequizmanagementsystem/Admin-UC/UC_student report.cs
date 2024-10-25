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
    public partial class UC_student_report : UserControl
    {
        private fuction fn = new fuction();

        public UC_student_report()
        {
            InitializeComponent();
            DisplayAllStudents();
        }

        private void DisplayAllStudents()
        {
            string query = "SELECT s.RegistrationNumber, s.FirstName, s.LastName, s.Gender," +
               
                " s.EmailAddress, s.PhoneNumber, r.QuizSet, r.MarksObtained " +
                          
                "FROM Studentinfo s " +
                          
                "INNER JOIN studentResults      r ON s.RegistrationNumber = r.RegistrationNumber";
            DataSet ds = fn.GetData(query);

            if (ds.Tables.Count > 0 && ds.  Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
           
            
            }
            else
            {
                MessageBox.Show("No student records found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
            
            }
        }

        private void SearchStudents(string keyword, string quizSet)
        {
            string query = "SELECT s.RegistrationNumber, s.FirstName, s.LastName, s.Gender, s.EmailAddress," +
               
                " s.PhoneNumber, r.QuizSet, r.MarksObtained " +
                         
                          "FROM Studentinfo s " +


                           "INNER JOIN studentResults r ON s.RegistrationNumber = r.RegistrationNumber " +

                           "WHERE (s.FirstName LIKE '%" + keyword + "%' OR s.LastName LIKE '%" + keyword + "%')";






            if (!string.IsNullOrEmpty(quizSet))
            {
                query += " AND r.QuizSet = '" + quizSet + "'";
            }

            DataSet ds = fn.GetData(query);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];


            }
            else
            {
                MessageBox.Show("No matching records found.", "Information", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void txtname_TextChanged(object sender, EventArgs e)
        {
            SearchStudents(txtname.Text, txtquizset.Text);
        }

        private void txtquizset_TextChanged(object sender, EventArgs e)
        {
            SearchStudents(txtname.Text, txtquizset.Text);
        }
    }
}