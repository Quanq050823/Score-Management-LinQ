using PrjTest.Hooman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjTest.BL
{
    internal class BLEnrolled
    {
        DBMSProjectTestDataContext dbms;

        public BLEnrolled()
        {
            dbms = new DBMSProjectTestDataContext();
        }

        public DataTable GetEnrolled(int ID, int Scholastic, int Semester)
        {
            DataTable myDataTable = new DataTable();
            var scorequery = (from r in dbms.View_EnrollLists
                              where r.Student_ID == ID
                              where r.Semester == Semester
                              where r.Scholastic == Scholastic
                              select r);

            List<Enrolled_Object> scoreList = new List<Enrolled_Object>();

            try
            {
                foreach (var score in scorequery)
                {
                    Enrolled_Object scoreOb = new Enrolled_Object(score.Student_ID, score.Scholastic, score.Semester, Convert.ToDecimal(score.Numberofcredits),
                         score.Sessionss_ID, score.Sessionss_Name);

                    scoreList.Add(scoreOb);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + "\nCannot retrieve data", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return null;
            }

            DataTable data = ToDataTable(scoreList);
            return data;
        }

        public int GetNoC(int strID, int strScholastic, int strSemester)
        {
            return Convert.ToInt32(dbms.FN_Count_Credits(Convert.ToDecimal(strID), Convert.ToDecimal(strScholastic), Convert.ToInt16(strSemester)));
        }

        static DataTable ToDataTable<T>(List<T> list)
        {
            DataTable dt = new DataTable();
            PropertyDescriptorCollection props = TypeDescriptor.GetProperties(typeof(T));
            foreach (PropertyDescriptor prop in props)
            {
                dt.Columns.Add(prop.Name, prop.PropertyType);
            }
            object[] values = new object[props.Count];
            foreach (T item in list)
            {
                for (int i = 0; i < values.Length; i++)
                {
                    values[i] = props[i].GetValue(item);
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

    }
}
