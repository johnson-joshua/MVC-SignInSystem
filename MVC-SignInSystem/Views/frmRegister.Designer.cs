namespace MVC_SignInSystem.Views
{
    partial class frmRegister
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
            this.lblCNumToRegister = new System.Windows.Forms.Label();
            this.lblFirstNameToRegister = new System.Windows.Forms.Label();
            this.lblLastNameToRegister = new System.Windows.Forms.Label();
            this.lblInstructor = new System.Windows.Forms.Label();
            this.txtFirstNameToRegister = new System.Windows.Forms.TextBox();
            this.txtCNumToRegister = new System.Windows.Forms.TextBox();
            this.txtLastNameToRegister = new System.Windows.Forms.TextBox();
            this.txtInstructor = new System.Windows.Forms.TextBox();
            this.lblDirectionsToRegister = new System.Windows.Forms.Label();
            this.lblDirectionsForRegister2 = new System.Windows.Forms.Label();
            this.lblCourseToRegister = new System.Windows.Forms.Label();
            this.txtCourseToRegister = new System.Windows.Forms.TextBox();
            this.btnRegisterOneCourse = new System.Windows.Forms.Button();
            this.btnCancelRegister = new System.Windows.Forms.Button();
            this.btnRegisterStudent = new System.Windows.Forms.Button();
            this.txtListOfCoursesToRegister = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCNumToRegister
            // 
            this.lblCNumToRegister.AutoSize = true;
            this.lblCNumToRegister.Location = new System.Drawing.Point(71, 16);
            this.lblCNumToRegister.Name = "lblCNumToRegister";
            this.lblCNumToRegister.Size = new System.Drawing.Size(135, 13);
            this.lblCNumToRegister.TabIndex = 0;
            this.lblCNumToRegister.Text = "Scan ID or Type C Number";
            // 
            // lblFirstNameToRegister
            // 
            this.lblFirstNameToRegister.AutoSize = true;
            this.lblFirstNameToRegister.Location = new System.Drawing.Point(13, 70);
            this.lblFirstNameToRegister.Name = "lblFirstNameToRegister";
            this.lblFirstNameToRegister.Size = new System.Drawing.Size(57, 13);
            this.lblFirstNameToRegister.TabIndex = 1;
            this.lblFirstNameToRegister.Text = "First Name";
            // 
            // lblLastNameToRegister
            // 
            this.lblLastNameToRegister.AutoSize = true;
            this.lblLastNameToRegister.Location = new System.Drawing.Point(209, 70);
            this.lblLastNameToRegister.Name = "lblLastNameToRegister";
            this.lblLastNameToRegister.Size = new System.Drawing.Size(58, 13);
            this.lblLastNameToRegister.TabIndex = 2;
            this.lblLastNameToRegister.Text = "Last Name";
            // 
            // lblInstructor
            // 
            this.lblInstructor.AutoSize = true;
            this.lblInstructor.Location = new System.Drawing.Point(12, 120);
            this.lblInstructor.Name = "lblInstructor";
            this.lblInstructor.Size = new System.Drawing.Size(82, 13);
            this.lblInstructor.TabIndex = 3;
            this.lblInstructor.Text = "Instructor Name";
            // 
            // txtFirstNameToRegister
            // 
            this.txtFirstNameToRegister.Location = new System.Drawing.Point(77, 62);
            this.txtFirstNameToRegister.Name = "txtFirstNameToRegister";
            this.txtFirstNameToRegister.Size = new System.Drawing.Size(100, 20);
            this.txtFirstNameToRegister.TabIndex = 4;
            // 
            // txtCNumToRegister
            // 
            this.txtCNumToRegister.Location = new System.Drawing.Point(212, 12);
            this.txtCNumToRegister.Name = "txtCNumToRegister";
            this.txtCNumToRegister.Size = new System.Drawing.Size(100, 20);
            this.txtCNumToRegister.TabIndex = 5;
            // 
            // txtLastNameToRegister
            // 
            this.txtLastNameToRegister.Location = new System.Drawing.Point(274, 62);
            this.txtLastNameToRegister.Name = "txtLastNameToRegister";
            this.txtLastNameToRegister.Size = new System.Drawing.Size(100, 20);
            this.txtLastNameToRegister.TabIndex = 6;
            // 
            // txtInstructor
            // 
            this.txtInstructor.Location = new System.Drawing.Point(100, 114);
            this.txtInstructor.Name = "txtInstructor";
            this.txtInstructor.Size = new System.Drawing.Size(100, 20);
            this.txtInstructor.TabIndex = 7;
            // 
            // lblDirectionsToRegister
            // 
            this.lblDirectionsToRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionsToRegister.Location = new System.Drawing.Point(432, 16);
            this.lblDirectionsToRegister.Name = "lblDirectionsToRegister";
            this.lblDirectionsToRegister.Size = new System.Drawing.Size(200, 108);
            this.lblDirectionsToRegister.TabIndex = 8;
            this.lblDirectionsToRegister.Text = "Directions: Enter your C number, first name and last name. ";
            // 
            // lblDirectionsForRegister2
            // 
            this.lblDirectionsForRegister2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDirectionsForRegister2.Location = new System.Drawing.Point(432, 114);
            this.lblDirectionsForRegister2.Name = "lblDirectionsForRegister2";
            this.lblDirectionsForRegister2.Size = new System.Drawing.Size(235, 209);
            this.lblDirectionsForRegister2.TabIndex = 9;
            this.lblDirectionsForRegister2.Text = "To set up courses:  Enter ONE course title in the box beside \"Course To Register\"" +
    " and enter the name of your instructor in the instructor name box. THEN, click t" +
    "he register for course button.";
            // 
            // lblCourseToRegister
            // 
            this.lblCourseToRegister.AutoSize = true;
            this.lblCourseToRegister.Location = new System.Drawing.Point(233, 150);
            this.lblCourseToRegister.Name = "lblCourseToRegister";
            this.lblCourseToRegister.Size = new System.Drawing.Size(173, 13);
            this.lblCourseToRegister.TabIndex = 10;
            this.lblCourseToRegister.Text = "Enter ONE course to register below\r\n";
            // 
            // txtCourseToRegister
            // 
            this.txtCourseToRegister.Location = new System.Drawing.Point(275, 169);
            this.txtCourseToRegister.Name = "txtCourseToRegister";
            this.txtCourseToRegister.Size = new System.Drawing.Size(100, 20);
            this.txtCourseToRegister.TabIndex = 11;
            // 
            // btnRegisterOneCourse
            // 
            this.btnRegisterOneCourse.Location = new System.Drawing.Point(236, 195);
            this.btnRegisterOneCourse.Name = "btnRegisterOneCourse";
            this.btnRegisterOneCourse.Size = new System.Drawing.Size(157, 23);
            this.btnRegisterOneCourse.TabIndex = 13;
            this.btnRegisterOneCourse.Text = "Add Course To Register List";
            this.btnRegisterOneCourse.UseVisualStyleBackColor = true;
            this.btnRegisterOneCourse.Click += new System.EventHandler(this.btnRegisterOneCourse_Click);
            // 
            // btnCancelRegister
            // 
            this.btnCancelRegister.Location = new System.Drawing.Point(15, 299);
            this.btnCancelRegister.Name = "btnCancelRegister";
            this.btnCancelRegister.Size = new System.Drawing.Size(109, 23);
            this.btnCancelRegister.TabIndex = 14;
            this.btnCancelRegister.Text = "Cancel";
            this.btnCancelRegister.UseVisualStyleBackColor = true;
            this.btnCancelRegister.Click += new System.EventHandler(this.btnCancelRegister_Click);
            // 
            // btnRegisterStudent
            // 
            this.btnRegisterStudent.Location = new System.Drawing.Point(191, 299);
            this.btnRegisterStudent.Name = "btnRegisterStudent";
            this.btnRegisterStudent.Size = new System.Drawing.Size(121, 23);
            this.btnRegisterStudent.TabIndex = 15;
            this.btnRegisterStudent.Text = "Register Student";
            this.btnRegisterStudent.UseVisualStyleBackColor = true;
            this.btnRegisterStudent.Click += new System.EventHandler(this.btnRegisterStudent_Click);
            // 
            // txtListOfCoursesToRegister
            // 
            this.txtListOfCoursesToRegister.Location = new System.Drawing.Point(60, 159);
            this.txtListOfCoursesToRegister.MaximumSize = new System.Drawing.Size(150, 200);
            this.txtListOfCoursesToRegister.Multiline = true;
            this.txtListOfCoursesToRegister.Name = "txtListOfCoursesToRegister";
            this.txtListOfCoursesToRegister.Size = new System.Drawing.Size(64, 108);
            this.txtListOfCoursesToRegister.TabIndex = 16;
            this.txtListOfCoursesToRegister.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtListOfCoursesToRegister.WordWrap = false;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 332);
            this.Controls.Add(this.txtListOfCoursesToRegister);
            this.Controls.Add(this.btnRegisterStudent);
            this.Controls.Add(this.btnCancelRegister);
            this.Controls.Add(this.btnRegisterOneCourse);
            this.Controls.Add(this.txtCourseToRegister);
            this.Controls.Add(this.lblCourseToRegister);
            this.Controls.Add(this.lblDirectionsForRegister2);
            this.Controls.Add(this.lblDirectionsToRegister);
            this.Controls.Add(this.txtInstructor);
            this.Controls.Add(this.txtLastNameToRegister);
            this.Controls.Add(this.txtCNumToRegister);
            this.Controls.Add(this.txtFirstNameToRegister);
            this.Controls.Add(this.lblInstructor);
            this.Controls.Add(this.lblLastNameToRegister);
            this.Controls.Add(this.lblFirstNameToRegister);
            this.Controls.Add(this.lblCNumToRegister);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCNumToRegister;
        public System.Windows.Forms.Label lblFirstNameToRegister;
        public System.Windows.Forms.Label lblLastNameToRegister;
        public System.Windows.Forms.Label lblInstructor;
        public System.Windows.Forms.TextBox txtFirstNameToRegister;
        public System.Windows.Forms.TextBox txtCNumToRegister;
        public System.Windows.Forms.TextBox txtLastNameToRegister;
        public System.Windows.Forms.TextBox txtInstructor;
        public System.Windows.Forms.Label lblDirectionsToRegister;
        public System.Windows.Forms.Label lblDirectionsForRegister2;
        public System.Windows.Forms.Label lblCourseToRegister;
        public System.Windows.Forms.TextBox txtCourseToRegister;
        public System.Windows.Forms.Button btnRegisterOneCourse;
        public System.Windows.Forms.Button btnCancelRegister;
        public System.Windows.Forms.Button btnRegisterStudent;
        public System.Windows.Forms.TextBox txtListOfCoursesToRegister;
    }
}