using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_SignInSystem.Views
{
    public partial class frmInstructorDialogBox : Form
    {
        public frmInstructorDialogBox()
        {
            InitializeComponent();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            Controllers.frmRegisterController.ValidateInstructorToAdd(txtInstructorFName.Text, txtLName.Text);
        }
    }
}
