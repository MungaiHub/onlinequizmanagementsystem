namespace onlinequizmanagementsystem
{
    partial class student
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(student));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxgender = new System.Windows.Forms.ComboBox();
            this.txtregistrationNo = new System.Windows.Forms.MaskedTextBox();
            this.lblregistrationNo = new System.Windows.Forms.Label();
            this.lblschool = new System.Windows.Forms.Label();
            this.lblcourse = new System.Windows.Forms.Label();
            this.lblfirstname = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbldateofbirth = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblemailaddress = new System.Windows.Forms.Label();
            this.lblphonenumber = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblgraduationyear = new System.Windows.Forms.Label();
            this.lbllastname = new System.Windows.Forms.Label();
            this.lblyearofstudy = new System.Windows.Forms.Label();
            this.txtschool = new System.Windows.Forms.MaskedTextBox();
            this.txtcourse = new System.Windows.Forms.MaskedTextBox();
            this.txtfirstname = new System.Windows.Forms.MaskedTextBox();
            this.txtlastname = new System.Windows.Forms.MaskedTextBox();
            this.txtaddress = new System.Windows.Forms.MaskedTextBox();
            this.txtemailaddress = new System.Windows.Forms.MaskedTextBox();
            this.txtphonenumber = new System.Windows.Forms.MaskedTextBox();
            this.txtpassword = new System.Windows.Forms.MaskedTextBox();
            this.txtyearofstudy = new System.Windows.Forms.MaskedTextBox();
            this.txtsemester = new System.Windows.Forms.MaskedTextBox();
            this.txtgraduationyear = new System.Windows.Forms.MaskedTextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnregisterandprocced = new System.Windows.Forms.Button();
            this.dtpdateofbirth = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registration Form";
            // 
            // comboBoxgender
            // 
            this.comboBoxgender.FormattingEnabled = true;
            this.comboBoxgender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBoxgender.Location = new System.Drawing.Point(333, 440);
            this.comboBoxgender.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.comboBoxgender.Name = "comboBoxgender";
            this.comboBoxgender.Size = new System.Drawing.Size(305, 37);
            this.comboBoxgender.TabIndex = 3;
            // 
            // txtregistrationNo
            // 
            this.txtregistrationNo.Location = new System.Drawing.Point(333, 115);
            this.txtregistrationNo.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtregistrationNo.Name = "txtregistrationNo";
            this.txtregistrationNo.Size = new System.Drawing.Size(305, 35);
            this.txtregistrationNo.TabIndex = 4;
            // 
            // lblregistrationNo
            // 
            this.lblregistrationNo.AutoSize = true;
            this.lblregistrationNo.BackColor = System.Drawing.Color.Transparent;
            this.lblregistrationNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblregistrationNo.Location = new System.Drawing.Point(88, 115);
            this.lblregistrationNo.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblregistrationNo.Name = "lblregistrationNo";
            this.lblregistrationNo.Size = new System.Drawing.Size(180, 29);
            this.lblregistrationNo.TabIndex = 5;
            this.lblregistrationNo.Text = "Registration No";
            // 
            // lblschool
            // 
            this.lblschool.AutoSize = true;
            this.lblschool.BackColor = System.Drawing.Color.Transparent;
            this.lblschool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblschool.Location = new System.Drawing.Point(88, 175);
            this.lblschool.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblschool.Name = "lblschool";
            this.lblschool.Size = new System.Drawing.Size(145, 29);
            this.lblschool.TabIndex = 6;
            this.lblschool.Text = "Your School";
            // 
            // lblcourse
            // 
            this.lblcourse.AutoSize = true;
            this.lblcourse.BackColor = System.Drawing.Color.Transparent;
            this.lblcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcourse.Location = new System.Drawing.Point(88, 246);
            this.lblcourse.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblcourse.Name = "lblcourse";
            this.lblcourse.Size = new System.Drawing.Size(91, 29);
            this.lblcourse.TabIndex = 7;
            this.lblcourse.Text = "Course";
            // 
            // lblfirstname
            // 
            this.lblfirstname.AutoSize = true;
            this.lblfirstname.BackColor = System.Drawing.Color.Transparent;
            this.lblfirstname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfirstname.Location = new System.Drawing.Point(86, 310);
            this.lblfirstname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblfirstname.Name = "lblfirstname";
            this.lblfirstname.Size = new System.Drawing.Size(131, 29);
            this.lblfirstname.TabIndex = 8;
            this.lblfirstname.Text = "First Name";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.BackColor = System.Drawing.Color.Transparent;
            this.lblgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgender.Location = new System.Drawing.Point(90, 448);
            this.lblgender.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(94, 29);
            this.lblgender.TabIndex = 10;
            this.lblgender.Text = "Gender";
            // 
            // lbldateofbirth
            // 
            this.lbldateofbirth.AutoSize = true;
            this.lbldateofbirth.BackColor = System.Drawing.Color.Transparent;
            this.lbldateofbirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldateofbirth.Location = new System.Drawing.Point(86, 522);
            this.lbldateofbirth.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbldateofbirth.Name = "lbldateofbirth";
            this.lbldateofbirth.Size = new System.Drawing.Size(149, 29);
            this.lbldateofbirth.TabIndex = 11;
            this.lbldateofbirth.Text = "Date Of Birth";
            // 
            // lblsemester
            // 
            this.lblsemester.AutoSize = true;
            this.lblsemester.BackColor = System.Drawing.Color.Transparent;
            this.lblsemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsemester.Location = new System.Drawing.Point(729, 448);
            this.lblsemester.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(117, 29);
            this.lblsemester.TabIndex = 12;
            this.lblsemester.Text = "Semester";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.BackColor = System.Drawing.Color.Transparent;
            this.lbladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbladdress.Location = new System.Drawing.Point(717, 115);
            this.lbladdress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(102, 29);
            this.lbladdress.TabIndex = 13;
            this.lbladdress.Text = "Address";
            // 
            // lblemailaddress
            // 
            this.lblemailaddress.AutoSize = true;
            this.lblemailaddress.BackColor = System.Drawing.Color.Transparent;
            this.lblemailaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemailaddress.Location = new System.Drawing.Point(717, 175);
            this.lblemailaddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblemailaddress.Name = "lblemailaddress";
            this.lblemailaddress.Size = new System.Drawing.Size(169, 29);
            this.lblemailaddress.TabIndex = 14;
            this.lblemailaddress.Text = "Email Address";
           // this.lblemailaddress.Click += new System.EventHandler(this.lblemailaddress_Click);
            // 
            // lblphonenumber
            // 
            this.lblphonenumber.AutoSize = true;
            this.lblphonenumber.BackColor = System.Drawing.Color.Transparent;
            this.lblphonenumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphonenumber.Location = new System.Drawing.Point(717, 246);
            this.lblphonenumber.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblphonenumber.Name = "lblphonenumber";
            this.lblphonenumber.Size = new System.Drawing.Size(176, 29);
            this.lblphonenumber.TabIndex = 15;
            this.lblphonenumber.Text = "Phone Number";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.BackColor = System.Drawing.Color.Transparent;
            this.lblpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpassword.Location = new System.Drawing.Point(725, 310);
            this.lblpassword.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(120, 29);
            this.lblpassword.TabIndex = 16;
            this.lblpassword.Text = "Password";
            // 
            // lblgraduationyear
            // 
            this.lblgraduationyear.AutoSize = true;
            this.lblgraduationyear.BackColor = System.Drawing.Color.Transparent;
            this.lblgraduationyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgraduationyear.Location = new System.Drawing.Point(729, 522);
            this.lblgraduationyear.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblgraduationyear.Name = "lblgraduationyear";
            this.lblgraduationyear.Size = new System.Drawing.Size(188, 29);
            this.lblgraduationyear.TabIndex = 17;
            this.lblgraduationyear.Text = "Graduation Year";
            // 
            // lbllastname
            // 
            this.lbllastname.AutoSize = true;
            this.lbllastname.BackColor = System.Drawing.Color.Transparent;
            this.lbllastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllastname.Location = new System.Drawing.Point(87, 381);
            this.lbllastname.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbllastname.Name = "lbllastname";
            this.lbllastname.Size = new System.Drawing.Size(128, 29);
            this.lbllastname.TabIndex = 18;
            this.lbllastname.Text = "Last Name";
            // 
            // lblyearofstudy
            // 
            this.lblyearofstudy.AutoSize = true;
            this.lblyearofstudy.BackColor = System.Drawing.Color.Transparent;
            this.lblyearofstudy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyearofstudy.Location = new System.Drawing.Point(725, 381);
            this.lblyearofstudy.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblyearofstudy.Name = "lblyearofstudy";
            this.lblyearofstudy.Size = new System.Drawing.Size(161, 29);
            this.lblyearofstudy.TabIndex = 19;
            this.lblyearofstudy.Text = "Year Of Study";
            // 
            // txtschool
            // 
            this.txtschool.Location = new System.Drawing.Point(333, 175);
            this.txtschool.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtschool.Name = "txtschool";
            this.txtschool.Size = new System.Drawing.Size(305, 35);
            this.txtschool.TabIndex = 20;
            // 
            // txtcourse
            // 
            this.txtcourse.Location = new System.Drawing.Point(333, 240);
            this.txtcourse.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(305, 35);
            this.txtcourse.TabIndex = 21;
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(333, 304);
            this.txtfirstname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(305, 35);
            this.txtfirstname.TabIndex = 22;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(333, 375);
            this.txtlastname.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(305, 35);
            this.txtlastname.TabIndex = 23;
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(948, 109);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(310, 35);
            this.txtaddress.TabIndex = 25;
            // 
            // txtemailaddress
            // 
            this.txtemailaddress.Location = new System.Drawing.Point(948, 169);
            this.txtemailaddress.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtemailaddress.Name = "txtemailaddress";
            this.txtemailaddress.Size = new System.Drawing.Size(310, 35);
            this.txtemailaddress.TabIndex = 26;
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(948, 243);
            this.txtphonenumber.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(310, 35);
            this.txtphonenumber.TabIndex = 27;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(948, 310);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(310, 35);
            this.txtpassword.TabIndex = 28;
            // 
            // txtyearofstudy
            // 
            this.txtyearofstudy.Location = new System.Drawing.Point(948, 378);
            this.txtyearofstudy.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtyearofstudy.Name = "txtyearofstudy";
            this.txtyearofstudy.Size = new System.Drawing.Size(310, 35);
            this.txtyearofstudy.TabIndex = 29;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(948, 440);
            this.txtsemester.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(310, 35);
            this.txtsemester.TabIndex = 30;
            // 
            // txtgraduationyear
            // 
            this.txtgraduationyear.Location = new System.Drawing.Point(948, 519);
            this.txtgraduationyear.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtgraduationyear.Name = "txtgraduationyear";
            this.txtgraduationyear.Size = new System.Drawing.Size(315, 35);
            this.txtgraduationyear.TabIndex = 31;
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.Transparent;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Image = ((System.Drawing.Image)(resources.GetObject("btnlogout.Image")));
            this.btnlogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Location = new System.Drawing.Point(930, 19);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(241, 50);
            this.btnlogout.TabIndex = 32;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Transparent;
            this.btnexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnexit.BackgroundImage")));
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(1190, 30);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(31, 28);
            this.btnexit.TabIndex = 33;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnregisterandprocced
            // 
            this.btnregisterandprocced.BackColor = System.Drawing.Color.Transparent;
            this.btnregisterandprocced.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregisterandprocced.Location = new System.Drawing.Point(542, 585);
            this.btnregisterandprocced.Name = "btnregisterandprocced";
            this.btnregisterandprocced.Size = new System.Drawing.Size(445, 41);
            this.btnregisterandprocced.TabIndex = 34;
            this.btnregisterandprocced.Text = "Register and Proceed For Test";
            this.btnregisterandprocced.UseVisualStyleBackColor = false;
            this.btnregisterandprocced.Click += new System.EventHandler(this.btnregisterandprocced_Click);
            // 
            // dtpdateofbirth
            // 
            this.dtpdateofbirth.Location = new System.Drawing.Point(333, 517);
            this.dtpdateofbirth.Name = "dtpdateofbirth";
            this.dtpdateofbirth.Size = new System.Drawing.Size(305, 35);
            this.dtpdateofbirth.TabIndex = 35;
            // 
            // student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1272, 653);
            this.Controls.Add(this.dtpdateofbirth);
            this.Controls.Add(this.btnregisterandprocced);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.txtgraduationyear);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtyearofstudy);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.txtemailaddress);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.txtschool);
            this.Controls.Add(this.lblyearofstudy);
            this.Controls.Add(this.lbllastname);
            this.Controls.Add(this.lblgraduationyear);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lblphonenumber);
            this.Controls.Add(this.lblemailaddress);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldateofbirth);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lblfirstname);
            this.Controls.Add(this.lblcourse);
            this.Controls.Add(this.lblschool);
            this.Controls.Add(this.lblregistrationNo);
            this.Controls.Add(this.txtregistrationNo);
            this.Controls.Add(this.comboBoxgender);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "student";
            this.Text = "studentregisterform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxgender;
        private System.Windows.Forms.MaskedTextBox txtregistrationNo;
        private System.Windows.Forms.Label lblregistrationNo;
        private System.Windows.Forms.Label lblschool;
        private System.Windows.Forms.Label lblcourse;
        private System.Windows.Forms.Label lblfirstname;
        private System.Windows.Forms.Label lblgender;
        private System.Windows.Forms.Label lbldateofbirth;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.Label lbladdress;
        private System.Windows.Forms.Label lblemailaddress;
        private System.Windows.Forms.Label lblphonenumber;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblgraduationyear;
        private System.Windows.Forms.Label lbllastname;
        private System.Windows.Forms.Label lblyearofstudy;
        private System.Windows.Forms.MaskedTextBox txtschool;
        private System.Windows.Forms.MaskedTextBox txtcourse;
        private System.Windows.Forms.MaskedTextBox txtfirstname;
        private System.Windows.Forms.MaskedTextBox txtlastname;
        private System.Windows.Forms.MaskedTextBox txtaddress;
        private System.Windows.Forms.MaskedTextBox txtemailaddress;
        private System.Windows.Forms.MaskedTextBox txtphonenumber;
        private System.Windows.Forms.MaskedTextBox txtpassword;
        private System.Windows.Forms.MaskedTextBox txtyearofstudy;
        private System.Windows.Forms.MaskedTextBox txtsemester;
        private System.Windows.Forms.MaskedTextBox txtgraduationyear;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnregisterandprocced;
        private System.Windows.Forms.DateTimePicker dtpdateofbirth;
        private System.Windows.Forms.Timer timer1;
    }
}