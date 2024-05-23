using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Hooman
{
    internal class Enrolled_Object
    {
        private decimal student_ID, scholastic, semester, noCredit;
        private string session_ID, session_Name;
         
        public Enrolled_Object() { }
        public Enrolled_Object(decimal student_ID, decimal scholastic, decimal semester, decimal noCredit, string session, string session_Name)
        {
            this.student_ID = student_ID;
            this.scholastic = scholastic;
            this.semester = semester;
            this.noCredit = noCredit;
            this.session_ID = session;
            this.session_Name = session_Name;
        }

        public decimal Student_ID { get => student_ID; set => student_ID = value; }
        public decimal Scholastic { get => scholastic; set => scholastic = value; }
        public decimal Semester { get => semester; set => semester = value; }
        public decimal NoCredit { get => noCredit; set => noCredit = value; }
        public string Session { get => session_ID; set => session_ID = value; }
        public string Session_Name { get => session_Name; set => session_Name = value; }
    }
}
