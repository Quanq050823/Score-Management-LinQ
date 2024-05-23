using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Object
{
    internal class TeacherScore_Object
    {
        private decimal student_ID, teacher_ID, scholastic, semester, process_score, final_exam, average_score, numberofcredits;
        private string student_Name, sessionss_ID, sessionss_Name, course_ID;
        bool status;
        //private decimal semester1;
        //private decimal process_score1;
        //private decimal average_score1;
        //private decimal final_exam1;
        //private bool status1;

        public TeacherScore_Object()
        {

        }
        public TeacherScore_Object(decimal student_ID, string student_Name, string sessionss_ID, string sessionss_Name, string course_ID, decimal teacher_ID, decimal scholastic, decimal semester, decimal numberofcredits, decimal process_score, decimal final_exam, decimal average_score, bool status)
        {
            this.Student_ID = student_ID;
            this.Student_Name = student_Name;
            this.Sessionss_ID = sessionss_ID;
            this.Sessionss_Name = sessionss_Name;
            this.Course_ID = course_ID;
            this.Teacher_ID = teacher_ID;
            this.Scholastic = scholastic;
            this.Semester = semester;
            this.Numberofcredits = numberofcredits;
            this.Process_score = process_score;
            this.Average_score = average_score;
            this.Final_exam = final_exam;
            this.Average_score = average_score;
            this.Status = status;
        }

        public decimal Student_ID { get => student_ID; set => student_ID = value; }
        public string Student_Name { get => student_Name; set => student_Name = value; }
        public string Sessionss_ID { get => sessionss_ID; set => sessionss_ID = value; }
        public string Sessionss_Name { get => sessionss_Name; set => sessionss_Name = value; }
        public string Course_ID { get => course_ID; set => course_ID = value; }
        public decimal Teacher_ID { get => teacher_ID; set => teacher_ID = value; }
        public decimal Scholastic { get => scholastic; set => scholastic = value; }
        public decimal Semester { get => semester; set => semester = value; }
        public decimal Numberofcredits { get => numberofcredits; set => numberofcredits = value; }
        public decimal Process_score { get => process_score; set => process_score = value; }
        public decimal Average_score { get => average_score; set => average_score = value; }
        public decimal Final_exam { get => final_exam; set => final_exam = value; }
        public bool Status { get => status; set => status = value; }
    }
}
