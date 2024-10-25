namespace onlinequizmanagementsystem
{
    partial class quizform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quizform));
            this.label1 = new System.Windows.Forms.Label();
            this.lblremainingtime = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnfinish = new System.Windows.Forms.Button();
            this.btnprevious = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblquestiontext = new System.Windows.Forms.Label();
            this.lblquestion = new System.Windows.Forms.Label();
            this.rboption4 = new System.Windows.Forms.RadioButton();
            this.rboption3 = new System.Windows.Forms.RadioButton();
            this.rboption2 = new System.Windows.Forms.RadioButton();
            this.rboption1 = new System.Windows.Forms.RadioButton();
            this.countdownTimer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome To Test";
            // 
            // lblremainingtime
            // 
            this.lblremainingtime.AutoSize = true;
            this.lblremainingtime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblremainingtime.Location = new System.Drawing.Point(516, 114);
            this.lblremainingtime.Name = "lblremainingtime";
            this.lblremainingtime.Size = new System.Drawing.Size(167, 25);
            this.lblremainingtime.TabIndex = 6;
            this.lblremainingtime.Text = "Remaining Time";
            // 
            // btnexit
            // 
            this.btnexit.Image = ((System.Drawing.Image)(resources.GetObject("btnexit.Image")));
            this.btnexit.Location = new System.Drawing.Point(1328, 2);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(67, 46);
            this.btnexit.TabIndex = 9;
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnfinish
            // 
            this.btnfinish.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnfinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfinish.Location = new System.Drawing.Point(1152, 739);
            this.btnfinish.Name = "btnfinish";
            this.btnfinish.Size = new System.Drawing.Size(141, 49);
            this.btnfinish.TabIndex = 5;
            this.btnfinish.Text = "Finish";
            this.btnfinish.UseVisualStyleBackColor = false;
            this.btnfinish.Click += new System.EventHandler(this.btnfinish_Click);
            // 
            // btnprevious
            // 
            this.btnprevious.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnprevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnprevious.Location = new System.Drawing.Point(174, 355);
            this.btnprevious.Name = "btnprevious";
            this.btnprevious.Size = new System.Drawing.Size(161, 38);
            this.btnprevious.TabIndex = 5;
            this.btnprevious.Text = "Previous";
            this.btnprevious.UseVisualStyleBackColor = false;
            this.btnprevious.Click += new System.EventHandler(this.btnprevious_Click);
            // 
            // btnnext
            // 
            this.btnnext.BackColor = System.Drawing.SystemColors.Desktop;
            this.btnnext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnext.Location = new System.Drawing.Point(928, 355);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(111, 38);
            this.btnnext.TabIndex = 4;
            this.btnnext.Text = "Next";
            this.btnnext.UseVisualStyleBackColor = false;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblquestiontext);
            this.panel1.Controls.Add(this.lblquestion);
            this.panel1.Controls.Add(this.btnnext);
            this.panel1.Controls.Add(this.btnprevious);
            this.panel1.Controls.Add(this.rboption4);
            this.panel1.Controls.Add(this.rboption3);
            this.panel1.Controls.Add(this.rboption2);
            this.panel1.Controls.Add(this.rboption1);
            this.panel1.Location = new System.Drawing.Point(12, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 484);
            this.panel1.TabIndex = 8;
            // 
            // lblquestiontext
            // 
            this.lblquestiontext.AutoSize = true;
            this.lblquestiontext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestiontext.Location = new System.Drawing.Point(97, 41);
            this.lblquestiontext.Name = "lblquestiontext";
            this.lblquestiontext.Size = new System.Drawing.Size(0, 25);
            this.lblquestiontext.TabIndex = 7;
            // 
            // lblquestion
            // 
            this.lblquestion.AutoSize = true;
            this.lblquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblquestion.Location = new System.Drawing.Point(118, 51);
            this.lblquestion.Name = "lblquestion";
            this.lblquestion.Size = new System.Drawing.Size(0, 25);
            this.lblquestion.TabIndex = 6;
            // 
            // rboption4
            // 
            this.rboption4.AutoSize = true;
            this.rboption4.Location = new System.Drawing.Point(102, 277);
            this.rboption4.Name = "rboption4";
            this.rboption4.Size = new System.Drawing.Size(21, 20);
            this.rboption4.TabIndex = 3;
            this.rboption4.TabStop = true;
            this.rboption4.UseVisualStyleBackColor = true;
            // 
            // rboption3
            // 
            this.rboption3.AutoSize = true;
            this.rboption3.Location = new System.Drawing.Point(102, 223);
            this.rboption3.Name = "rboption3";
            this.rboption3.Size = new System.Drawing.Size(21, 20);
            this.rboption3.TabIndex = 2;
            this.rboption3.TabStop = true;
            this.rboption3.UseVisualStyleBackColor = true;
            // 
            // rboption2
            // 
            this.rboption2.AutoSize = true;
            this.rboption2.Location = new System.Drawing.Point(100, 169);
            this.rboption2.Name = "rboption2";
            this.rboption2.Size = new System.Drawing.Size(21, 20);
            this.rboption2.TabIndex = 1;
            this.rboption2.TabStop = true;
            this.rboption2.UseVisualStyleBackColor = true;
            // 
            // rboption1
            // 
            this.rboption1.AutoSize = true;
            this.rboption1.Location = new System.Drawing.Point(100, 118);
            this.rboption1.Name = "rboption1";
            this.rboption1.Size = new System.Drawing.Size(21, 20);
            this.rboption1.TabIndex = 0;
            this.rboption1.TabStop = true;
            this.rboption1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-22, -22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // quizform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1409, 791);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnfinish);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblremainingtime);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quizform";
            this.Text = "quizform";
          //  this.Load += new System.EventHandler(this.quizform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblremainingtime;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnfinish;
        private System.Windows.Forms.Button btnprevious;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rboption4;
        private System.Windows.Forms.RadioButton rboption3;
        private System.Windows.Forms.RadioButton rboption2;
        private System.Windows.Forms.RadioButton rboption1;
        private System.Windows.Forms.Label lblquestion;
        private System.Windows.Forms.Label lblquestiontext;
        private System.Windows.Forms.Timer countdownTimer;
        private System.Windows.Forms.Button button1;
    }
}