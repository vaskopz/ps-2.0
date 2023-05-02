using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace StudentInfoSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> StudStatusChoices { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            FillStudStatusChoices();
        }

        private void FillStudStatusChoices()
        {
            StudStatusChoices = new List<string>();
            using (IDbConnection connection = new
            SqlConnection(Properties.Settings.Default.DbConnect))
            {
                string sqlquery =
                @"SELECT StatusDescr FROM StudStatus";
                IDbCommand command = new SqlCommand();
                command.Connection = connection;
                connection.Open();
                command.CommandText = sqlquery;
                IDataReader reader = command.ExecuteReader();
                bool notEndOfResult;
                notEndOfResult = reader.Read();
                while (notEndOfResult)

                {
                    string s = reader.GetString(0);
                    StudStatusChoices.Add(s);
                    notEndOfResult = reader.Read();
                }
            }
        }

        private static List<Student> GetStudentsFromDB()
        {
            StudentInfoContext context = new StudentInfoContext();
            List<Student> students = context.Students.ToList();
            return students;
        }
        private void DeleteStudents(int fnum)
        {
            StudentInfoContext context = new StudentInfoContext();
            Student delObj = context.Students.Where(x => x.FacultyNumber == fnum).FirstOrDefault();
            context.Students.Remove(delObj);
            context.SaveChanges();
        }
        private bool TestStudentsIfEmpty()
        {
            StudentInfoContext context = new StudentInfoContext();
            int countStudents = context.Students.Count();
            if (context.Students.Count() == 0) return true;
            else return false;
        }
        private void CopyTestStudents()
        {
            StudentInfoContext context = new StudentInfoContext();
            foreach (Student st in StudentData.TestStudents)
            {
                context.Students.Add(st);
            }
            context.SaveChanges();
        }

        private void logButton_Click(object sender, RoutedEventArgs e)
        {
            if (logButton.Content.ToString().Equals("Login"))
            {
                if (TestStudentsIfEmpty())
                {
                    CopyTestStudents();
                }
                foreach (var item in MainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).IsEnabled = true;
                    }
                }
                Student student = StudentData.TestStudents.OrderBy(st => st.FacultyNumber).FirstOrDefault();
                firstNameText.Text = student.FirstName;
                secondNameText.Text = student.SecondName;
                lastNameText.Text = student.LastName;
                facultyText.Text = student.Faculty;
                majorText.Text = student.Major;
                degreeText.Text = student.Degree;
                statusText.Text = student.Status;
                facultyNumberText.Text = student.FacultyNumber.ToString();
                courseText.Text = student.Course.ToString();
                streamText.Text = student.Stream.ToString();
                groupText.Text = student.Group.ToString();
                logButton.Content = "Logout";
            }
            else if (logButton.Content.ToString().Equals("Logout"))
            {
                foreach (var item in MainGrid.Children)
                {
                    if (item is TextBox)
                    {
                        ((TextBox)item).Text = "";
                        ((TextBox)item).IsEnabled = false;
                    }
                }
                logButton.Content = "Login";
            }
        }

    }
}
