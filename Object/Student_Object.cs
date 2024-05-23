using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Hooman
{
    internal class Student_Object
    {
        private decimal student_ID, student_IDC, admissiom, major;
        private string student_Name, email, phone_num;
        DateTime DoB;
        bool gender;
        

        public Student_Object()
        {
        }

        public Student_Object(decimal student_ID, decimal student_IDC, decimal admissiom, decimal major, string student_Name, string email, string phone_num, DateTime DoB, bool gender)
        {
            this.Student_ID = student_ID;
            this.Student_IDC = student_IDC;
            this.Admission = admissiom;
            this.Major = major;
            this.Student_Name = student_Name;
            this.Email = email;
            this.Phone_num = phone_num;
            this.DoB = DoB;
            this.Gender= gender;
        }

        public decimal Student_ID { get => student_ID; set => student_ID = value; }
        public decimal Student_IDC { get => student_IDC; set => student_IDC = value; }
        public decimal Admission { get => admissiom; set => admissiom = value; }
        public decimal Major { get => major; set => major = value; }
        public string Student_Name { get => student_Name; set => student_Name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_num { get => phone_num; set => phone_num = value; }
        public DateTime DoB1 { get => DoB; set => DoB = value; }
        public bool Gender { get => gender; set => gender = value; }

        public bool Print(string strID, string strIDC, string strAdmission, string strMajor, string strName, string strEmail, string strPhoneNum, string strDoB, string strGender)
        {
            strID += this.Student_ID.ToString();
            strIDC += this.Student_IDC.ToString();
            strAdmission += this.Admission.ToString();
            strMajor += this.Major.ToString();
            strName += this.Student_Name.ToString();
            strEmail += this.Email.ToString();
            strPhoneNum += this.Phone_num.ToString();
            strDoB += this.DoB.ToString();
            strGender += this.Gender.ToString();

            return true;
        }
    }
}
