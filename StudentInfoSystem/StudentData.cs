using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoSystem
{
    public class StudentData
    {
        private static List<Student> testStudents = new List<Student>();
        public static void ResetTestStudentData()
        {
            testStudents.Add(new Student("Vasil", "Dimitrov", "Konsulov", "FKST", "KSI",
                "Bachelor", new MainWindow().StudStatusChoices.ElementAt(0), 121220151, 3, 9, 46));
        }
        public static List<Student> TestStudents
        {
            get
            {
                ResetTestStudentData();
                return testStudents;
            }
            set { testStudents = value; }
        }

        private Student IsThereStudent(int facNum)
        {
            StudentInfoContext context = new StudentInfoContext();

            Student result =
            (from st in context.Students
             where st.FacultyNumber == facNum
             select st).First();
            return result;
        }
    }
}
