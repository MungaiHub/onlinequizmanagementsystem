using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlinequizmanagementsystem
{
    public partial class Form1 : Form

     

    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       // private void Form1_Load(object sender, EventArgs e)
      //{
//panel1.Visible = false;
//            wronglabel.Visible = false; 
//}

        //private void txtselectuser_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {
          panel1.Visible = false;
          panel2.Visible = false;
          wronglabel.Visible = false;
            wronglabel2.Visible = false;
        }

        private void txtselectuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(txtselectuser.SelectedIndex == 0)
            {
                panel2.Visible = true;
                panel1.Visible = false;
            }
            else if (txtselectuser.SelectedIndex == 1)
            {
                panel1.Visible = true;
                panel2.Visible = false;
            }
        }

        private void checkBoxshowhide_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxshowhide.Checked == true)
            {
                txtpassword.PasswordChar = '\0';
                checkBoxshowhide.Text = "hide password";
            }
            else
            {
                txtpassword.PasswordChar = '*';
                checkBoxshowhide.Text = "show password";
            }
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
         if(txtusername.Text=="amosmungai" && txtpassword.Text == "mungai")
            {
                wronglabel.Visible = false;
              Admin te = new Admin();
                te.Show();
                this.Hide();
            }
         else
            {
                wronglabel.Visible = true;
            }
        }

        private void btnstudentregister_Click(object sender, EventArgs e)
        {
            wronglabel2.Visible = false;
            student registrationForm = new student();
            registrationForm.Show();
            this.Hide();
        }

        private void checkBoxshowhide2_CheckedChanged(object sender, EventArgs e)
        {
           if (checkBoxshowhide2.Checked == true)
            {
              txtpassword2.PasswordChar = '\0';
                checkBoxshowhide2.Text = "Hide Password";
            }
            else
            {
                txtpassword2.PasswordChar = '*';
                checkBoxshowhide2.Text = "show Password";
            }
        }

    private void btnstudentlogin_Click(object sender, EventArgs e)
    {
            wronglabel2.Visible = false;
            string registrationNumber = txtstudentregNo.Text.Trim();
        string password = txtpassword2.Text.Trim();
            


            if (string.IsNullOrEmpty(registrationNumber) || string.IsNullOrEmpty(password))
        {
                
                MessageBox.Show("Please enter both registration number and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        else if (!IsRegistered(registrationNumber, password))
        {

                wronglabel2.Visible = true;
        }
            else
            {

                wronglabel2.Visible = false;
                MessageBox.Show("login successful.");
              ;
                quizform quizform = new quizform("1",registrationNumber);
                quizform.Show();
                this.Hide();
            }

        }

        private bool IsRegistered(string registrationNumber, string password)
        {
            fuction database = new fuction();
                          string query = "SELECT 1 FROM Studentinfo si " +
                           "INNER JOIN Enrollments e ON si.RegistrationNumber = e.RegistrationNumber " +
                           "WHERE si.RegistrationNumber = '" + registrationNumber + "' AND si.Password = '" + password + "'";

            DataSet ds = database.GetData(query);
            return (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0);
        }
    }




    }

        //private void btnstudentregister_Click(object sender, EventArgs e)
        //{

        // }
    
    


