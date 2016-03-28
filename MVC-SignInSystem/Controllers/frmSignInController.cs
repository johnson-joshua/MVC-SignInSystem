using MVC_SignInSystem.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_SignInSystem.Controllers
{
    class frmSignInController
    {
        public static ArrayList GetAllStudentData()
        {
            ArrayList StudentData = new ArrayList();
            try
            {
                OleDbConnection connection = new OleDbConnection();
                connection.ConnectionString = @"Provider = Microsoft.ACE.OLEDB.12.0;
                                                Data Source = |DataDirectory|\SignInStudentInfo.accdb;
                                                Persist Security Info = false;";
                connection.Open();
                OleDbCommand command = new OleDbCommand() { Connection = connection,
                                                            CommandText = "SELECT * FROM SignInStudentInfo" };
                OleDbDataReader reader = command.ExecuteReader();

                int count = 0;
                while( reader.Read())
                {
                    Models.Student newStudent = new Models.Student()
                    {
                        StudentID = reader.GetValue(0).ToString(),
                        StudentFirstName = reader.GetValue(1).ToString(),
                        StudentLastName = reader.GetValue(2).ToString(),
                        CourseTitle = reader.GetValue(4).ToString(),
                        InstructorFullName = reader.GetValue(6).ToString()
                    };
                    StudentData.Add(newStudent);
                    count++;
                }
                Console.WriteLine("The array with every student is now loaded with " +count +" students.");
                connection.Dispose();
                connection.Close();
                return StudentData;
            }
            catch(Exception e)
            {
                MessageBox.Show("The Student Data file could not be read. See the console for more information about the error.");
                Console.WriteLine(e.Message);
                return StudentData;
            }
        }

        public static void getIndividualStudentInformation(string cNum)
        {
            var studentQuery = from Student x in Program.arrayWithEveryStudent
                               where x.StudentID == cNum
                               select new Student
                               {
                                   StudentID = x.StudentID,
                                   StudentFirstName = x.StudentFirstName,
                                   StudentLastName = x.StudentLastName,
                                   Section = x.Section,
                                   CourseTitle = x.CourseTitle,
                                   CRN = x.CRN,
                                   InstructorFullName = x.InstructorFullName,
                                   Term = x.Term
                               };
            var queryList = studentQuery.ToList();
            if (queryList.Count == 0)
                StudentMustRegister();
            else
            {
                SetupStudentData(queryList);
                Program.signInForm.txtCNum.Enabled = false;
            }
        }

        private static void SetupStudentData(List<Student> queryList)
        {
            SetName(queryList);
            SetupCbxSubject(queryList);
            SetTimeAndDate();
        }

        private static void SetName(List<Student> queryList)
        {
            Program.signInForm.txtName.Text = queryList.First().StudentFirstName + " " + queryList.First().StudentLastName;
        }

        private static void SetTimeAndDate()
        {
            string todaysDate = System.DateTime.Today.ToShortDateString();
            string currentTime = System.DateTime.Now.ToShortTimeString();
            Program.signInForm.txtDate.Text = todaysDate;
            Program.signInForm.txtTime.Text = currentTime;
        }

        private static void SetupCbxSubject(List<Student> queryList)
        {
            Program.signInForm.cbxSubject.Items.Clear();
            foreach(Student s in queryList)
            {
                Program.signInForm.cbxSubject.Items.Add(s.CourseTitle);
            }
            Program.signInForm.cbxSubject.Items.Add("Other");
            Program.signInForm.cbxSubject.Enabled = true;
        }

        private static void StudentMustRegister()
        {
            Program.signInForm.lblMessage.Visible = true;
            Program.signInForm.btnRegister.Visible = true;
            Program.signInForm.btnRegister.Enabled = true;
            Program.signInForm.btnSignIn.Visible = false;
            Program.signInForm.btnClear.Visible = false;
            Program.signInForm.lblMessage.Text = "Student C Number not recognized!\nPlease register your C Number.";
            ResetSignInForm();
        }

        public static bool ValidateCNumber(string CNum)
        {
            if(CNum != null && CNum.Count() == 9)
            {
                if(CNum.StartsWith("C00"))
                {
                    Program.signInForm.lblMessage.Visible = false;
                    SetupFieldsForSignIn();
                    Program.signInForm.lblMessage.Visible = false;
                    return true;
                }
                else   //CNum is not null and has 9 digits, but doesn't begin with C00
                {
                    Program.signInForm.txtCNum.Clear();
                    Program.signInForm.lblMessage.Text = "C Number must begin with C00!";
                    Program.signInForm.lblMessage.Visible = true;
                    return false;
                }
            }
            else     //CNum is equal to null or doesn't have 9 digits
            {
                Program.signInForm.txtCNum.Clear();
                Program.signInForm.lblMessage.Text = "C Number is not valid due to length.  All valid C Numbers have 9 digits including the 'C'.";
                Program.signInForm.lblMessage.Visible = true;
                return false;
            }
        }

        private static void SetupFieldsForSignIn()
        {
            Program.signInForm.btnSignIn.Visible = true;
            Program.signInForm.btnSignIn.Enabled = true;
            Program.signInForm.btnClear.Visible = true;
            Program.signInForm.btnClear.Enabled = true;
            Program.signInForm.btnRegister.Visible = false;
            Program.signInForm.btnRegister.Enabled = false;
        }

        public static void ResetSignInForm()
        {
            Program.signInForm.txtCNum.Clear();
            Program.signInForm.txtCNum.Enabled = true;
            Program.signInForm.btnSignIn.Enabled = false;
            Program.signInForm.btnClear.Enabled = false;
            Program.signInForm.txtDate.Clear();
            Program.signInForm.txtDate.Enabled = false;
            Program.signInForm.txtTime.Clear();
            Program.signInForm.txtTime.Enabled = false;
            Program.signInForm.txtName.Clear();
            Program.signInForm.txtName.Enabled = false;
            Program.signInForm.cbxSubject.Items.Clear();
            Program.signInForm.cbxSubject.Text = "Subject";
            Program.signInForm.cbxSubject.Enabled = false;
            Program.signInForm.lblExplination.Visible = false;
            Program.signInForm.txtExplination.Visible = false;
            Program.signInForm.txtExplination.Text = "";
            Program.signInForm.txtCNum.Focus();
        }

        public static void ResetButtonsForSignIn()
        {
            Program.signInForm.btnClear.Visible = true;
            Program.signInForm.btnClear.Enabled = true;
            Program.signInForm.btnRegister.Visible = false;
            Program.signInForm.btnRegister.Enabled = false;
            Program.signInForm.btnSignIn.Visible = true;
            Program.signInForm.btnSignIn.Enabled = true;
            Program.signInForm.lblMessage.Visible = false;
        }
    }
}
