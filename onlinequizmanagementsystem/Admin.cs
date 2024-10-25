using onlinequizmanagementsystem.Admin_UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlinequizmanagementsystem
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

       

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            uC_addnewquestion1.Visible = false;
            uC_updatequestions1.Visible = false;
            uC_view___delete_questions1.Visible = false;
            uC_student_report1.Visible = false;


        }

        private void btnaddnewquestion_Click(object sender, EventArgs e)
        {
            uC_addnewquestion1.Visible = true;
            uC_addnewquestion1.BringToFront();
        }

        private void btnupdatequestions_Click(object sender, EventArgs e)
        {
         uC_updatequestions1.Visible=true;
            uC_updatequestions1.BringToFront();
        }

        private void btnviewdeletequestions_Click(object sender, EventArgs e)
        {
            uC_view___delete_questions1.Visible = true;
            uC_view___delete_questions1.BringToFront();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           
            this.Hide();

         
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void btnstudentreport_Click(object sender, EventArgs e)
        {
           uC_student_report1.Visible = true;
            uC_student_report1.BringToFront();
        }
    }
}
