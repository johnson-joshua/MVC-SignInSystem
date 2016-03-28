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
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnRegisterStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelRegister_Click(object sender, EventArgs e)
        {
            Controllers.frmRegisterController.CloseRegisterForm();
        }

        private void btnRegisterOneCourse_Click(object sender, EventArgs e)
        {
            Controllers.frmRegisterController.ValidateCourseToAdd();
        }
    }
}
