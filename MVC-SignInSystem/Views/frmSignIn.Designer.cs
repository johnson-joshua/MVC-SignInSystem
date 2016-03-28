namespace MVC_SignInSystem
{
    public partial class frmSignIn
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
            this.lblCNum = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbxSubject = new System.Windows.Forms.ComboBox();
            this.txtExplination = new System.Windows.Forms.TextBox();
            this.lblExplination = new System.Windows.Forms.Label();
            this.txtCNum = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCNum
            // 
            this.lblCNum.AutoSize = true;
            this.lblCNum.Location = new System.Drawing.Point(34, 34);
            this.lblCNum.Name = "lblCNum";
            this.lblCNum.Size = new System.Drawing.Size(61, 13);
            this.lblCNum.TabIndex = 0;
            this.lblCNum.Text = "Student C#";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(37, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(75, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Student Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(418, 34);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(70, 13);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Today\'s Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(421, 96);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(66, 13);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "Sign In Time";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(109, 276);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.Location = new System.Drawing.Point(424, 276);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(75, 23);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = true;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(365, 225);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(131, 23);
            this.btnRegister.TabIndex = 6;
            this.btnRegister.Text = "Register Student";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Visible = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbxSubject
            // 
            this.cbxSubject.Enabled = false;
            this.cbxSubject.FormattingEnabled = true;
            this.cbxSubject.Location = new System.Drawing.Point(109, 160);
            this.cbxSubject.Name = "cbxSubject";
            this.cbxSubject.Size = new System.Drawing.Size(121, 21);
            this.cbxSubject.TabIndex = 8;
            this.cbxSubject.Text = "Subject";
            // 
            // txtExplination
            // 
            this.txtExplination.Location = new System.Drawing.Point(421, 160);
            this.txtExplination.Name = "txtExplination";
            this.txtExplination.Size = new System.Drawing.Size(183, 20);
            this.txtExplination.TabIndex = 9;
            this.txtExplination.Visible = false;
            // 
            // lblExplination
            // 
            this.lblExplination.AutoSize = true;
            this.lblExplination.Location = new System.Drawing.Point(421, 141);
            this.lblExplination.Name = "lblExplination";
            this.lblExplination.Size = new System.Drawing.Size(190, 13);
            this.lblExplination.TabIndex = 10;
            this.lblExplination.Text = "Please explain the purpose of your visit";
            this.lblExplination.Visible = false;
            // 
            // txtCNum
            // 
            this.txtCNum.Location = new System.Drawing.Point(102, 26);
            this.txtCNum.Name = "txtCNum";
            this.txtCNum.Size = new System.Drawing.Size(100, 20);
            this.txtCNum.TabIndex = 11;
            this.txtCNum.TextChanged += new System.EventHandler(this.txtCNum_TextChanged);
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(119, 88);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 12;
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(495, 26);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(100, 20);
            this.txtDate.TabIndex = 13;
            // 
            // txtTime
            // 
            this.txtTime.Enabled = false;
            this.txtTime.Location = new System.Drawing.Point(494, 87);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(100, 20);
            this.txtTime.TabIndex = 14;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.ForeColor = System.Drawing.Color.Red;
            this.lblMessage.Location = new System.Drawing.Point(109, 225);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(188, 13);
            this.lblMessage.TabIndex = 15;
            this.lblMessage.Text = "No input in one or more required fields!";
            this.lblMessage.Visible = false;
            // 
            // frmSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 362);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCNum);
            this.Controls.Add(this.lblExplination);
            this.Controls.Add(this.txtExplination);
            this.Controls.Add(this.cbxSubject);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnSignIn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCNum);
            this.Name = "frmSignIn";
            this.Text = "Sign In Sytem";
            this.Load += new System.EventHandler(this.frmSignIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblCNum;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblTime;
        public System.Windows.Forms.Button btnClear;
        public System.Windows.Forms.Button btnSignIn;
        public System.Windows.Forms.Button btnRegister;
        public System.Windows.Forms.ComboBox cbxSubject;
        public System.Windows.Forms.TextBox txtExplination;
        public System.Windows.Forms.Label lblExplination;
        public System.Windows.Forms.TextBox txtCNum;
        public System.Windows.Forms.TextBox txtName;
        public System.Windows.Forms.TextBox txtDate;
        public System.Windows.Forms.TextBox txtTime;
        public System.Windows.Forms.Label lblMessage;
    }
}

