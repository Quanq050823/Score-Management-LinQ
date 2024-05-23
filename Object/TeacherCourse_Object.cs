using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Object
{
    internal class TeacherCourse_Object
    {
        private decimal teacher_ID, scholastic, semester;
        private string sessionss_ID, course_ID, sessionss_name;

        public TeacherCourse_Object() { }
        public TeacherCourse_Object(decimal teacher_ID,string sessionss_ID, string sessionss_name, string course_ID, decimal scholastic, decimal semester)
        {
            this.teacher_ID = teacher_ID;
            this.scholastic = scholastic;
            this.semester = semester;
            this.sessionss_ID = sessionss_ID;
            this.course_ID = course_ID;
            this.sessionss_name = sessionss_name;
        }

        public decimal Teacher_ID { get => teacher_ID; set => teacher_ID = value; }
        public decimal Scholastic { get => scholastic; set => scholastic = value; }
        public decimal Semester { get => semester; set => semester = value; }
        public string Sessionss_ID { get => sessionss_ID; set => sessionss_ID = value; }
        public string Course_ID { get => course_ID; set => course_ID = value; }
        public string Sessionss_name { get => sessionss_name; set => sessionss_name = value; }
    }
}
