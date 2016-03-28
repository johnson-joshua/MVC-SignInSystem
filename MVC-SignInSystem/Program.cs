using MVC_SignInSystem.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_SignInSystem
{
    public class Program
    {
        public static frmSignIn signInForm;
        public static frmRegister registerForm;
        public static frmInstructorDialogBox instructorDialogBox;
        public static ArrayList arrayWithEveryStudent;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            signInForm = new frmSignIn();
            registerForm = new frmRegister();
            arrayWithEveryStudent = Controllers.frmSignInController.GetAllStudentData();
            Application.Run(signInForm);
        }
    }
}
