namespace Student_Data_project
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
            this.LB_Student = new System.Windows.Forms.ListBox();
            this.TB_Name = new System.Windows.Forms.TextBox();
            this.TB_Mobile = new System.Windows.Forms.TextBox();
            this.TB_Email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Course_Details = new System.Windows.Forms.ComboBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.TB_Course_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TB_Student_ID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LB_Student
            // 
            this.LB_Student.FormattingEnabled = true;
            this.LB_Student.ItemHeight = 16;
            this.LB_Student.Location = new System.Drawing.Point(535, 13);
            this.LB_Student.Name = "LB_Student";
            this.LB_Student.Size = new System.Drawing.Size(488, 420);
            this.LB_Student.TabIndex = 0;
            this.LB_Student.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LB_Student_MouseClick);
            // 
            // TB_Name
            // 
            this.TB_Name.Location = new System.Drawing.Point(208, 122);
            this.TB_Name.Name = "TB_Name";
            this.TB_Name.Size = new System.Drawing.Size(192, 22);
            this.TB_Name.TabIndex = 2;
            // 
            // TB_Mobile
            // 
            this.TB_Mobile.Location = new System.Drawing.Point(208, 175);
            this.TB_Mobile.Name = "TB_Mobile";
            this.TB_Mobile.Size = new System.Drawing.Size(192, 22);
            this.TB_Mobile.TabIndex = 3;
            // 
            // TB_Email
            // 
            this.TB_Email.Location = new System.Drawing.Point(208, 229);
            this.TB_Email.Name = "TB_Email";
            this.TB_Email.Size = new System.Drawing.Size(192, 22);
            this.TB_Email.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Student Mobile";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Student Email";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Name";
            // 
            // CB_Course_Details
            // 
            this.CB_Course_Details.FormattingEnabled = true;
            this.CB_Course_Details.Location = new System.Drawing.Point(208, 278);
            this.CB_Course_Details.Name = "CB_Course_Details";
            this.CB_Course_Details.Size = new System.Drawing.Size(213, 24);
            this.CB_Course_Details.TabIndex = 10;
            this.CB_Course_Details.Text = "Select From Drop Down";
            this.CB_Course_Details.SelectedValueChanged += new System.EventHandler(this.Course_ID_Function);
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Add.Location = new System.Drawing.Point(22, 372);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(101, 61);
            this.btn_Add.TabIndex = 11;
            this.btn_Add.Text = "Insert Data";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Update.Location = new System.Drawing.Point(150, 372);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(113, 61);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update Data";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Delete.Location = new System.Drawing.Point(292, 372);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(108, 61);
            this.btn_Delete.TabIndex = 13;
            this.btn_Delete.Text = "Delete Data";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(44, 331);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(70, 16);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "Course_ID";
            // 
            // TB_Course_ID
            // 
            this.TB_Course_ID.Enabled = false;
            this.TB_Course_ID.Location = new System.Drawing.Point(208, 328);
            this.TB_Course_ID.Name = "TB_Course_ID";
            this.TB_Course_ID.Size = new System.Drawing.Size(192, 22);
            this.TB_Course_ID.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 17;
            this.label5.Text = "Student ID";
            // 
            // TB_Student_ID
            // 
            this.TB_Student_ID.Enabled = false;
            this.TB_Student_ID.Location = new System.Drawing.Point(212, 70);
            this.TB_Student_ID.Name = "TB_Student_ID";
            this.TB_Student_ID.Size = new System.Drawing.Size(192, 22);
            this.TB_Student_ID.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_Student_ID);
            this.Controls.Add(this.TB_Course_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.CB_Course_Details);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_Email);
            this.Controls.Add(this.TB_Mobile);
            this.Controls.Add(this.TB_Name);
            this.Controls.Add(this.LB_Student);
            this.Name = "Form1";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Student;
        private System.Windows.Forms.TextBox TB_Name;
        private System.Windows.Forms.TextBox TB_Mobile;
        private System.Windows.Forms.TextBox TB_Email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Course_Details;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox TB_Course_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TB_Student_ID;
    }
}

