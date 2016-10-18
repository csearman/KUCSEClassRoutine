namespace KUCSEClassRoutine
{
    partial class AddCourse
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CourseNumber = new System.Windows.Forms.ComboBox();
            this.Credit = new System.Windows.Forms.ComboBox();
            this.Submit = new System.Windows.Forms.Button();
            this.CourseName = new System.Windows.Forms.ComboBox();
            this.TeacherName = new System.Windows.Forms.ComboBox();
            this.Lab = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(166, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Course Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Credit Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(174, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Teacher Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(184, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Theory/ Lab";
            // 
            // CourseNumber
            // 
            this.CourseNumber.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNumber.FormattingEnabled = true;
            this.CourseNumber.Items.AddRange(new object[] {
            "CSE 2210",
            "CSE 2205"});
            this.CourseNumber.Location = new System.Drawing.Point(296, 69);
            this.CourseNumber.Name = "CourseNumber";
            this.CourseNumber.Size = new System.Drawing.Size(121, 25);
            this.CourseNumber.TabIndex = 0;
            this.CourseNumber.SelectedIndexChanged += new System.EventHandler(this.CourseNumber_SelectedIndexChanged);
            // 
            // Credit
            // 
            this.Credit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Credit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Credit.FormattingEnabled = true;
            this.Credit.Items.AddRange(new object[] {
            "0.75",
            "1.0",
            "1.5",
            "2",
            "3",
            "4"});
            this.Credit.Location = new System.Drawing.Point(296, 193);
            this.Credit.Name = "Credit";
            this.Credit.Size = new System.Drawing.Size(121, 25);
            this.Credit.TabIndex = 3;
            this.Credit.SelectedIndexChanged += new System.EventHandler(this.Credit_SelectedIndexChanged);
            // 
            // Submit
            // 
            this.Submit.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.Location = new System.Drawing.Point(229, 313);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(121, 32);
            this.Submit.TabIndex = 5;
            this.Submit.Text = "Add";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // CourseName
            // 
            this.CourseName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseName.FormattingEnabled = true;
            this.CourseName.Items.AddRange(new object[] {
            "Algorithm",
            "Data Mining"});
            this.CourseName.Location = new System.Drawing.Point(296, 111);
            this.CourseName.Name = "CourseName";
            this.CourseName.Size = new System.Drawing.Size(121, 25);
            this.CourseName.TabIndex = 1;
            this.CourseName.SelectedIndexChanged += new System.EventHandler(this.CourseName_SelectedIndexChanged);
            // 
            // TeacherName
            // 
            this.TeacherName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeacherName.FormattingEnabled = true;
            this.TeacherName.Items.AddRange(new object[] {
            "Zahidul Islam",
            "Mohidul Islam"});
            this.TeacherName.Location = new System.Drawing.Point(296, 153);
            this.TeacherName.Name = "TeacherName";
            this.TeacherName.Size = new System.Drawing.Size(121, 25);
            this.TeacherName.TabIndex = 2;
            this.TeacherName.SelectedIndexChanged += new System.EventHandler(this.TeacherName_SelectedIndexChanged);
            // 
            // Lab
            // 
            this.Lab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Lab.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lab.FormattingEnabled = true;
            this.Lab.Items.AddRange(new object[] {
            "Lab",
            "Theory"});
            this.Lab.Location = new System.Drawing.Point(296, 233);
            this.Lab.Name = "Lab";
            this.Lab.Size = new System.Drawing.Size(121, 25);
            this.Lab.TabIndex = 4;
            this.Lab.SelectedIndexChanged += new System.EventHandler(this.Lab_SelectedIndexChanged);
            // 
            // AddCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KUCSEClassRoutine.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(595, 400);
            this.Controls.Add(this.Lab);
            this.Controls.Add(this.TeacherName);
            this.Controls.Add(this.CourseName);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.Credit);
            this.Controls.Add(this.CourseNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(611, 439);
            this.MinimumSize = new System.Drawing.Size(611, 439);
            this.Name = "AddCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCourse";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CourseNumber;
        private System.Windows.Forms.ComboBox Credit;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.ComboBox CourseName;
        private System.Windows.Forms.ComboBox TeacherName;
        private System.Windows.Forms.ComboBox Lab;
    }
}