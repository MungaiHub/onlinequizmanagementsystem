using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace onlinequizmanagementsystem
{ 
    public partial class student : Form
    {
        fuction fn = new fuction();
        string query;
        DataSet ds;

        
        public student()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {


            this.Hide();


            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnregisterandprocced_Click(object sender, EventArgs e)
        {
            {
                
                if (string.IsNullOrWhiteSpace(txtregistrationNo.Text) ||
                    string.IsNullOrWhiteSpace(txtfirstname.Text) ||
                    string.IsNullOrWhiteSpace(txtlastname.Text) ||
                    string.IsNullOrWhiteSpace(comboBoxgender.Text) ||
                    string.IsNullOrWhiteSpace(txtaddress.Text) ||
                    string.IsNullOrWhiteSpace(txtemailaddress.Text) ||
                    string.IsNullOrWhiteSpace(txtphonenumber.Text) ||
                    string.IsNullOrWhiteSpace(txtpassword.Text) ||
                    string.IsNullOrWhiteSpace(txtschool.Text) ||
                    string.IsNullOrWhiteSpace(txtcourse.Text) ||
                    string.IsNullOrWhiteSpace(txtyearofstudy.Text) ||
                    string.IsNullOrWhiteSpace(txtsemester.Text) ||
                    string.IsNullOrWhiteSpace(txtgraduationyear.Text))
                {
                    MessageBox.Show("All fields are mandatory. Please fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
                string registrationNumber = txtregistrationNo.Text.Trim();
            string firstName = txtfirstname.Text.Trim();
            string lastName = txtlastname.Text.Trim();
            string gender = comboBoxgender.Text.Trim();
            DateTime dateOfBirth = dtpdateofbirth.Value;
            string address = txtaddress.Text.Trim();
            string emailAddress = txtemailaddress.Text.Trim();
            string phoneNumber = txtphonenumber.Text.Trim();
            string password = txtpassword.Text.Trim();
            string schoolName = txtschool.Text.Trim();
            string courseName = txtcourse.Text.Trim();
            string yearOfStudy = txtyearofstudy.Text.Trim();
            string semester = txtsemester.Text.Trim();
            int graduationYear = Convert.ToInt32(txtgraduationyear.Text.Trim());

            query = "INSERT INTO Studentinfo (RegistrationNumber, FirstName, LastName, Gender, DateOfBirth, Address, EmailAddress, PhoneNumber, Password) " +
                   "VALUES ('" + registrationNumber + "', '" + firstName + "', '" + lastName + "', '" + gender + "', '" + dateOfBirth.ToString("yyyy-MM-dd") + "', '" + address + "', '" + emailAddress + "', '" + phoneNumber + "', '" + password + "')";
            fn.setData(query, "",false);

           
            insertSchool(schoolName);

            int courseID = insertCourse(courseName, schoolName);

            insertEnrollment(registrationNumber, courseID, yearOfStudy, semester, graduationYear.ToString());


            quizform quizform = new quizform("1",registrationNumber);
            quizform.Show();
            this.Hide();

        }

        private void insertEnrollment(string registrationNumber, string yearOfStudy, string semester, string graduationYear)
        {
            query = "INSERT INTO Enrollments (RegistrationNumber, YearOfStudy, Semester, GraduationYear) " +
                    "VALUES ('" + registrationNumber + "', '" + yearOfStudy + "', '" + semester + "', '" + graduationYear + "')";
            fn.setData(query, "",false);
        }

        private void insertSchool(string schoolName)
        {
            query = "INSERT INTO Schools (SchoolName) VALUES ('" + schoolName + "')";
            fn.setData(query, "",false);
        }

        private int insertCourse(string courseName, string schoolName)
        {
           
            query = "SELECT SchoolID FROM Schools WHERE SchoolName = '" + schoolName + "'";
            ds = fn.GetData(query);

            if (ds.Tables[0].Rows.Count > 0)
            {
                string schoolID = ds.Tables[0].Rows[0]["SchoolID"].ToString();

                query = "INSERT INTO Courses (CourseName, SchoolID) VALUES ('" + courseName + "', '" + schoolID + "')";
                fn.setData(query, "",false);

                query = "SELECT CourseID FROM Courses WHERE CourseName = '" + courseName + "' AND SchoolID = '" + schoolID + "'";
                ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    
                    return Convert.ToInt32(ds.Tables[0].Rows[0]["CourseID"]);
                }
            }

            MessageBox.Show("Course not found or CourseID not retrieved.");
            return -1; 
        }

        private void insertEnrollment(string registrationNumber, int courseID, string yearOfStudy, string semester, string graduationYear)
        {
            query = "INSERT INTO Enrollments (RegistrationNumber, CourseID, YearOfStudy, Semester, GraduationYear) " +
         "VALUES ('" + registrationNumber + "', " + courseID + ", '" + yearOfStudy + "', '" + semester + "', '" + graduationYear + "')";
            fn.setData(query, "Registration successful!press OK to proceed to test.",true);
        }


    }
    }
