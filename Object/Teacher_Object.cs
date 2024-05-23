using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Hooman
{
    internal class Teacher_Object
    {
        private decimal teacher_ID, teacher_IDC;
        private string teacher_Name, email, phone_no;
        DateTime dob;
        bool gender;

        public Teacher_Object()
        {
        }
        public Teacher_Object(decimal teacher_ID, decimal teacher_IDC, string teacher_Name, string email, string phone_no, DateTime dob, bool gender)
        {
            this.Teacher_ID = teacher_ID;
            this.Teacher_IDC = teacher_IDC;
            this.Teacher_Name = teacher_Name;
            this.Email = email;
            this.Phone_no = phone_no;
            this.Dob = dob;
            this.Gender = gender;
        }

        public decimal Teacher_ID { get => teacher_ID; set => teacher_ID = value; }
        public decimal Teacher_IDC { get => teacher_IDC; set => teacher_IDC = value; }
        public string Teacher_Name { get => teacher_Name; set => teacher_Name = value; }
        public string Email { get => email; set => email = value; }
        public string Phone_no { get => phone_no; set => phone_no = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public bool Gender { get => gender; set => gender = value; }
    }
}
