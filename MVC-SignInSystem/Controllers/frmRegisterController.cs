using MVC_SignInSystem.Models;
using MVC_SignInSystem.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_SignInSystem.Controllers
{
    class frmRegisterController
    {
        
        //public void setupCoursesForRegister()
        //{
        //    //Push the courses that were entered on the register form into an array
        //    string courses = txtCoursesToRegister.Text;
        //    string[] allCourses = courses.Split(',');
        //    string[] instructors = Instructor.Split(',');

        //    //Set up the connection to the database
        //    OleDbConnection connection = new OleDbConnection();
        //    connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=SignInStudentInfo.accdb;
        //                                        Persist Security Info=False;";
        //    connection.Open();
        //    OleDbCommand command = new OleDbCommand();
        //    command.Connection = connection;
        //    command.CommandText = "INSERT INTO [SignInStudentInfo] ([CID], [STUDENT_FIRSTNAME], [STUDENT_LASTNAME], [CRN], [COURSE_TITLE], [SECTION], [INSTRUCTOR_FULL_NAME], [TERM])" + "VALUES (?,?,?,?,?,?,?,?)";

        //    //Loop through adding in values so that each course is set up with the student data
        //    for (int i = 0; i < counter; i++)
        //    {
        //        command.Parameters.AddWithValue("@CID", txtCNumToRegister.Text);
        //        command.Parameters.AddWithValue("@STUDENT_FIRSTNAME", txtFNameToRegister.Text);
        //        command.Parameters.AddWithValue("@STUDENT_LASTNAME", txtLNameToRegister.Text);
        //        command.Parameters.AddWithValue("@CRN", 0);
        //        command.Parameters.AddWithValue("@COURSE_TITLE", allCourses[i].ToString());
        //        command.Parameters.AddWithValue("@SECTION", "Section");
        //        command.Parameters.AddWithValue("@INSTRUCTOR_FULL_NAME", instructors[i].ToString());
        //        command.Parameters.AddWithValue("@TERM", 0);
        //        command.ExecuteNonQuery();
        //        command.Parameters.Clear();
        //    }
        //    //Loop through creating new students and adding to the array of all students
        //    for (int i = 0; i < counter; i++)
        //    {
        //        Student newStudent = new Student();
        //        newStudent.StudentFirstName = txtFNameToRegister.Text;
        //        newStudent.StudentLastName = txtLNameToRegister.Text;
        //        newStudent.StudentID = txtCNumToRegister.Text;
        //        newStudent.InstructorFullName = txtInstructor.Text;
        //        newStudent.CourseTitle = allCourses[i];
        //        Program.arrayWithEveryStudent.Add(newStudent);
        //    }
        //    connection.Close();
        //}

        private static int counter = 0;
        private static string instructor;

        public static void ValidateCourseToAdd()
        {
            //Course should be in the form of 3 letters, followed by 3 numbers
            //Should call another method to ensure an instrucor name is in the instructor field
            //Should call another method that creates students in database from
            //student and instructor arrays

            List<string> coursesToAddToDatabase = new List<string>();


            //Validates course text and adds to course List<string>
            if (Program.registerForm.txtCourseToRegister.Text != "")
            {
                string courseToAdd = Program.registerForm.txtCourseToRegister.Text;
                courseToAdd = courseToAdd.Trim(' ').ToUpper();
                if (courseToAdd.Contains(" "))
                {
                    int locationOfSpace = courseToAdd.IndexOf(" ");
                    courseToAdd = courseToAdd.Remove(locationOfSpace, 1);
                }
            }
        }

    public static void ValidateInstructorToAdd()
    {
        //Validates instructor text and adds to instructor List<string>

        List<string> instructorsFNameToAddToDatabase = new List<string>();
        List<string> instructorsLNameToAddToDatabase = new List<string>();

        if (Program.registerForm.txtInstructor.Text != "")
        {
            string instructorToAddForCourse = Program.registerForm.txtInstructor.Text;

            //Check for a space. If there is one, add names to instructor array
            if (instructorToAddForCourse.Contains(" "))
            {
                //Add first name and last name to respective fields in instructor array
                int locationOfSpace = instructorToAddForCourse.IndexOf(" ");

                string firstName = instructorToAddForCourse.Remove(locationOfSpace);
                string lastName = instructorToAddForCourse.Remove(0, locationOfSpace);
                instructorsFNameToAddToDatabase.Add(firstName);
                instructorsLNameToAddToDatabase.Add(lastName);
            }
            else
            {
                //Show custom modal dialog box to accept user input for a complete instructor name
                frmInstructorDialogBox tempDialogBox = new frmInstructorDialogBox();
                tempDialogBox.ShowDialog(Program.signInForm);

            }
        }
    }

        //This method is called from the custom dialog box with instructor first and last name
        public static void ValidateInstructorToAdd(string fName, string lName)
        {

        }

        public static void AddCourseForRegister()
        {
            //Adds course to the textbox on the register form.
            //Program.registerForm.txtListOfCoursesToRegister.Text += courseToAdd + "\n";
            instructor += Program.registerForm.txtInstructor.Text + ',';
            Program.registerForm.txtCourseToRegister.Clear();
            Program.registerForm.txtInstructor.Clear();
            counter++;
        }


        public static void CloseRegisterForm()
        {
            if (Program.registerForm != null)
                Program.registerForm.Close();

            Controllers.frmSignInController.ResetButtonsForSignIn();
        }
    }
}


