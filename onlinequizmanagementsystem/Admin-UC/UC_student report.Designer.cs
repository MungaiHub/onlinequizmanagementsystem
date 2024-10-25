namespace onlinequizmanagementsystem.Admin_UC
{
    partial class UC_student_report
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbkstudentresult = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gunaElipse1 = new Guna.UI.WinForms.GunaElipse(this.components);
            this.txtquizset = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbkstudentresult
            // 
            this.lbkstudentresult.AutoSize = true;
            this.lbkstudentresult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbkstudentresult.Location = new System.Drawing.Point(94, 43);
            this.lbkstudentresult.Name = "lbkstudentresult";
            this.lbkstudentresult.Size = new System.Drawing.Size(230, 32);
            this.lbkstudentresult.TabIndex = 0;
            this.lbkstudentresult.Text = "Student Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(158, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(163, 175);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(309, 26);
            this.txtname.TabIndex = 2;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 266);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1028, 397);
            this.dataGridView1.TabIndex = 3;
            // 
            // gunaElipse1
            // 
            this.gunaElipse1.Radius = 6;
            this.gunaElipse1.TargetControl = this;
            // 
            // txtquizset
            // 
            this.txtquizset.Location = new System.Drawing.Point(593, 175);
            this.txtquizset.Name = "txtquizset";
            this.txtquizset.Size = new System.Drawing.Size(309, 26);
            this.txtquizset.TabIndex = 5;
            this.txtquizset.TextChanged += new System.EventHandler(this.txtquizset_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(588, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Quiz Set";
            // 
            // UC_student_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtquizset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbkstudentresult);
            this.Name = "UC_student_report";
            this.Size = new System.Drawing.Size(1095, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbkstudentresult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI.WinForms.GunaElipse gunaElipse1;
        private System.Windows.Forms.TextBox txtquizset;
        private System.Windows.Forms.Label label2;
    }
}
