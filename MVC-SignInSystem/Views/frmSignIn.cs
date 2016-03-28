using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_SignInSystem
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
            txtCNum.Focus();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Data has been validated.  Write the info from the textboxes into a .csv file and CLEAR FIELDS AFTER!
            using (StreamWriter writer = new StreamWriter("SignInResults.csv", true))
            {
                writer.Write(txtCNum.Text.ToUpper() + ','
                    + txtName.Text + ','
                    + txtDate.Text + ','
                    + txtTime.Text + ','
                    + cbxSubject.Text + ','
                    + txtExplination.Text + "\n");
            }
            Controllers.frmSignInController.ResetSignInForm();
            txtCNum.Focus();
        }

        private void txtCNum_TextChanged(object sender, EventArgs e)
        {
            if (txtCNum.Text.Count() == 9)
            {
                string enteredCNumber = txtCNum.Text.ToUpper();
                if (Controllers.frmSignInController.ValidateCNumber(enteredCNumber))
                {
                    //ValidateCNumber method returns true if the c number is valid
                    Controllers.frmSignInController.getIndividualStudentInformation(enteredCNumber);
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Add a method in controller for resetting the sign in form.
            Controllers.frmSignInController.ResetSignInForm();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Program.registerForm.ShowDialog();
        }

        private void frmSignIn_Load(object sender, EventArgs e)
        {
            Controllers.frmSignInController.ResetSignInForm();
            Controllers.frmSignInController.ResetButtonsForSignIn();
        }
    }
}
