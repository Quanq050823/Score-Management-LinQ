using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Linq.Mapping;
using System.Windows.Forms;
using PrjTest.Hooman;
using System.Runtime.CompilerServices;
using System.Data.SqlClient;
using System.Diagnostics;

namespace PrjTest.BL
{
    internal class BLStudent
    {
        DBMSProjectTestDataContext dbms;

        public System.Data.Linq.Table<Student> GetStudents()
        {
            DBMSProjectTestDataContext dbms = new DBMSProjectTestDataContext();
            return dbms.Students;
        }

        public Student_Object GetInfo(int ID)
        {
            //Query to get student in4 with ID
            dbms = new DBMSProjectTestDataContext();
            Student_Object student_in4 = new Student_Object();
            
            try
            {
                var studentQuery = dbms.FN_FindStudent(ID);

            //Create a student store In4
            
                foreach (var student in studentQuery)
                {
                    //stresult +=($"ID: {student.Student_ID}, Name: {student.Dayofbirth}") + "/n";
                    student_in4 = new Student_Object(Convert.ToInt32(student.Student_ID), Convert.ToInt32(student.Student_IDC),
                        Convert.ToInt32(student.Admission), Convert.ToInt32(student.Major),
                        student.Student_Name, student.Email, student.PhoneNumber.ToString(), student.Dayofbirth.Date, student.Gender);
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.ToString()); }
            catch (Exception ex) { MessageBox.Show(ex.ToString());}

            return student_in4;
        }
        

        public bool UpdateStudent(string strID, string strIDC,  string strName,string strPhoneNum, DateTime DoB, 
            bool strGender, string strAdmission, string strMajor)
        {
            dbms = new DBMSProjectTestDataContext();
            try
            {
                if (strPhoneNum != "")
                {
                    dbms.PROC_UPDATE_STUDENT(Convert.ToDecimal(strID), strName, Convert.ToDecimal(strIDC), Convert.ToBoolean(strGender),
                        Convert.ToDateTime(DoB), Convert.ToDecimal(strPhoneNum), Convert.ToDecimal(strAdmission), Convert.ToDecimal(strMajor));
                }
                else
                {
                    dbms.PROC_UPDATE_STUDENT(Convert.ToDecimal(strID), strName, Convert.ToDecimal(strIDC), Convert.ToBoolean(strGender),
                       Convert.ToDateTime(DoB), null, Convert.ToDecimal(strAdmission), Convert.ToDecimal(strMajor));
                }   
            }
            catch (SqlException ex) 
            {
                MessageBox.Show(ex.Message +"\nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
        }

        public bool InsertStudent(string strID, string strIDC, string strName, string strPhoneNum, DateTime strDoB,
            bool strGender, string strAdmission, string strMajor)
        {
            string connString_Admin = @"Data Source=.;Initial Catalog=DBMSProjectTest;Persist Security Info=True;User Id=" + "PrjAdmin" + ";Password= " + "admin" + ";";
            dbms = new DBMSProjectTestDataContext(connString_Admin);
            
            try
            {
                //Call stored procedure
                if (strPhoneNum== "")
                {
                    dbms.PROC_Add_Student(Convert.ToDecimal(strID), strName, Convert.ToDateTime(strDoB), null, strGender, Convert.ToDecimal(strIDC), Convert.ToDecimal(strAdmission), Convert.ToDecimal(strMajor));

                }
                else
                dbms.PROC_Add_Student(Convert.ToDecimal(strID), strName, Convert.ToDateTime(strDoB), Convert.ToDecimal(strPhoneNum), strGender, Convert.ToDecimal(strIDC), Convert.ToDecimal(strAdmission), Convert.ToDecimal(strMajor));
                dbms.SubmitChanges();
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
        }

        public bool DeleteStudet(string strID)
        {
            dbms = new DBMSProjectTestDataContext();
            try
            {
                //Call stored procedure
                dbms.PROC_Delete_Student(Convert.ToDecimal(strID));
            }

            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return true;
        }
    }
}
