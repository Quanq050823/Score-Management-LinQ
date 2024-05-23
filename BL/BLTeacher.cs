using PrjTest.Hooman;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PrjTest.BL
{
    internal class BLTeacher
    {
        DBMSProjectTestDataContext dbms;

        public BLTeacher()
        {
            dbms = new DBMSProjectTestDataContext();
        }

        public System.Data.Linq.Table<Teacher> GetTeachers() 
        { 
            DBMSProjectTestDataContext dbms = new DBMSProjectTestDataContext();
            return dbms.Teachers;
        }

        public Teacher_Object GetInfo(int ID)
        {
            //Query to get student in4 with ID
            var queryGetTeacher = dbms.FN_FindTeacher(ID);

            //Create a student store In4
            Teacher_Object teacher_in4 = new Teacher_Object();
            foreach (var t in queryGetTeacher)
            {
                teacher_in4 = new Teacher_Object(Convert.ToInt32(t.Teacher_ID), Convert.ToInt32(t.Teacher_IDC),
                                        t.Teacher_Name, t.Email, t.PhoneNumber.ToString(), t.Dayofbirth.Date, t.Gender);
            }

            return teacher_in4;
        }

        public bool InsertTeacher(string strID, string strIDC, string strName, string strPhoneNum, DateTime strDoB,
            bool strGender)
        {
            DBMSProjectTestDataContext dbms = new DBMSProjectTestDataContext();

            try
            {
                //Call stored procedure
                if (strPhoneNum == "")
                {
                    dbms.PROC_Add_Teacher(Convert.ToDecimal(strID), strName, Convert.ToDateTime(strDoB), null, strGender, Convert.ToDecimal(strIDC));

                }
                else
                    dbms.PROC_Add_Teacher(Convert.ToDecimal(strID), strName, Convert.ToDateTime(strDoB), Convert.ToDecimal(strPhoneNum), strGender, Convert.ToDecimal(strIDC));
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

        public bool DeleteTeacher(string strID)
        {
            DBMSProjectTestDataContext dbms = new DBMSProjectTestDataContext();
            try
            {
                //Call stored procedure
                dbms.PROC_Delete_Teacher(Convert.ToDecimal(strID));
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

        public bool UpdateTeacher(string strID, string strIDC, string strName, string strPhoneNum, DateTime strDoB,
            bool strGender, bool acctype)
        {
            DBMSProjectTestDataContext dbms = new DBMSProjectTestDataContext();

            if (acctype)
            {
                try
                {
                    //Call stored procedure
                    if (strPhoneNum == "")
                    {
                        dbms.PROC_Update_Teacher(Convert.ToDecimal(strID), strName, Convert.ToDateTime(strDoB), null, strGender, Convert.ToDecimal(strIDC));

                    }
                    else
                        dbms.PROC_Update_Teacher(Convert.ToDecimal(strID), strName, Convert.ToDateTime(strDoB), Convert.ToDecimal(strPhoneNum), strGender, Convert.ToDecimal(strIDC));
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
            }

            return true;
        }
    }
}
