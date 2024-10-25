namespace onlinequizmanagementsystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtselectuser = new System.Windows.Forms.ComboBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxshowhide = new System.Windows.Forms.CheckBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.wronglabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnstudentlogin = new System.Windows.Forms.Button();
            this.btnstudentregister = new System.Windows.Forms.Button();
            this.txtstudentregNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpassword2 = new System.Windows.Forms.TextBox();
            this.checkBoxshowhide2 = new System.Windows.Forms.CheckBox();
            this.wronglabel2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(710, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "online quiz management system";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.White;
            this.label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(515, 176);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(212, 32);
            this.label.TabIndex = 1;
            this.label.Text = "select user type";
            // 
            // txtselectuser
            // 
            this.txtselectuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtselectuser.ForeColor = System.Drawing.Color.Black;
            this.txtselectuser.FormattingEnabled = true;
            this.txtselectuser.Items.AddRange(new object[] {
            "Student",
            "Admin"});
            this.txtselectuser.Location = new System.Drawing.Point(430, 226);
            this.txtselectuser.Name = "txtselectuser";
            this.txtselectuser.Size = new System.Drawing.Size(391, 37);
            this.txtselectuser.TabIndex = 2;
            this.txtselectuser.SelectedIndexChanged += new System.EventHandler(this.txtselectuser_SelectedIndexChanged);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Red;
            this.btnexit.Location = new System.Drawing.Point(1279, 12);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 40);
            this.btnexit.TabIndex = 3;
            this.btnexit.Text = "EXIT";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBoxshowhide);
            this.panel1.Controls.Add(this.btnlogin);
            this.panel1.Controls.Add(this.txtpassword);
            this.panel1.Controls.Add(this.txtusername);
            this.panel1.Controls.Add(this.wronglabel);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(411, 293);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(391, 442);
            this.panel1.TabIndex = 4;
            // 
            // checkBoxshowhide
            // 
            this.checkBoxshowhide.AutoSize = true;
            this.checkBoxshowhide.Location = new System.Drawing.Point(121, 260);
            this.checkBoxshowhide.Name = "checkBoxshowhide";
            this.checkBoxshowhide.Size = new System.Drawing.Size(144, 24);
            this.checkBoxshowhide.TabIndex = 7;
            this.checkBoxshowhide.Text = "show password";
            this.checkBoxshowhide.UseVisualStyleBackColor = true;
            this.checkBoxshowhide.CheckedChanged += new System.EventHandler(this.checkBoxshowhide_CheckedChanged);
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(94, 290);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(183, 39);
            this.btnlogin.TabIndex = 6;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(19, 209);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(341, 35);
            this.txtpassword.TabIndex = 5;
            this.txtpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(19, 131);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(341, 35);
            this.txtusername.TabIndex = 4;
            this.txtusername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wronglabel
            // 
            this.wronglabel.AutoSize = true;
            this.wronglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wronglabel.ForeColor = System.Drawing.Color.Red;
            this.wronglabel.Location = new System.Drawing.Point(51, 389);
            this.wronglabel.Name = "wronglabel";
            this.wronglabel.Size = new System.Drawing.Size(294, 25);
            this.wronglabel.TabIndex = 3;
            this.wronglabel.Text = "wrong username \"OR\" password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 1;
            this.label4.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Admin Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.wronglabel2);
            this.panel2.Controls.Add(this.checkBoxshowhide2);
            this.panel2.Controls.Add(this.txtpassword2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnstudentlogin);
            this.panel2.Controls.Add(this.btnstudentregister);
            this.panel2.Controls.Add(this.txtstudentregNo);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(408, 290);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(391, 442);
            this.panel2.TabIndex = 5;
            // 
            // btnstudentlogin
            // 
            this.btnstudentlogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnstudentlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentlogin.ForeColor = System.Drawing.Color.White;
            this.btnstudentlogin.Location = new System.Drawing.Point(85, 302);
            this.btnstudentlogin.Name = "btnstudentlogin";
            this.btnstudentlogin.Size = new System.Drawing.Size(183, 39);
            this.btnstudentlogin.TabIndex = 7;
            this.btnstudentlogin.Text = "Login";
            this.btnstudentlogin.UseVisualStyleBackColor = false;
            this.btnstudentlogin.Click += new System.EventHandler(this.btnstudentlogin_Click);
            // 
            // btnstudentregister
            // 
            this.btnstudentregister.BackColor = System.Drawing.Color.LimeGreen;
            this.btnstudentregister.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstudentregister.ForeColor = System.Drawing.Color.White;
            this.btnstudentregister.Location = new System.Drawing.Point(85, 364);
            this.btnstudentregister.Name = "btnstudentregister";
            this.btnstudentregister.Size = new System.Drawing.Size(183, 39);
            this.btnstudentregister.TabIndex = 6;
            this.btnstudentregister.Text = "Register";
            this.btnstudentregister.UseVisualStyleBackColor = false;
            this.btnstudentregister.Click += new System.EventHandler(this.btnstudentregister_Click);
            // 
            // txtstudentregNo
            // 
            this.txtstudentregNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentregNo.ForeColor = System.Drawing.Color.Black;
            this.txtstudentregNo.Location = new System.Drawing.Point(19, 131);
            this.txtstudentregNo.Name = "txtstudentregNo";
            this.txtstudentregNo.Size = new System.Drawing.Size(341, 35);
            this.txtstudentregNo.TabIndex = 4;
            this.txtstudentregNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(116, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Student Reg No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(105, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(174, 29);
            this.label8.TabIndex = 0;
            this.label8.Text = "Student Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // txtpassword2
            // 
            this.txtpassword2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword2.ForeColor = System.Drawing.Color.Black;
            this.txtpassword2.Location = new System.Drawing.Point(22, 212);
            this.txtpassword2.Name = "txtpassword2";
            this.txtpassword2.PasswordChar = '*';
            this.txtpassword2.Size = new System.Drawing.Size(341, 35);
            this.txtpassword2.TabIndex = 9;
            this.txtpassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // checkBoxshowhide2
            // 
            this.checkBoxshowhide2.AutoSize = true;
            this.checkBoxshowhide2.Location = new System.Drawing.Point(113, 253);
            this.checkBoxshowhide2.Name = "checkBoxshowhide2";
            this.checkBoxshowhide2.Size = new System.Drawing.Size(144, 24);
            this.checkBoxshowhide2.TabIndex = 10;
            this.checkBoxshowhide2.Text = "show password";
            this.checkBoxshowhide2.UseVisualStyleBackColor = true;
            this.checkBoxshowhide2.CheckedChanged += new System.EventHandler(this.checkBoxshowhide2_CheckedChanged);
            // 
            // wronglabel2
            // 
            this.wronglabel2.AutoSize = true;
            this.wronglabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wronglabel2.ForeColor = System.Drawing.Color.Red;
            this.wronglabel2.Location = new System.Drawing.Point(63, 406);
            this.wronglabel2.Name = "wronglabel2";
            this.wronglabel2.Size = new System.Drawing.Size(285, 22);
            this.wronglabel2.TabIndex = 11;
            this.wronglabel2.Text = "\"Please register before logging in.\"";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.txtselectuser);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ComboBox txtselectuser;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label wronglabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.CheckBox checkBoxshowhide;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnstudentregister;
        private System.Windows.Forms.TextBox txtstudentregNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnstudentlogin;
        private System.Windows.Forms.CheckBox checkBoxshowhide2;
        private System.Windows.Forms.TextBox txtpassword2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label wronglabel2;
    }
}

