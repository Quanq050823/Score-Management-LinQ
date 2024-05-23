using PrjTest.Object;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Management;
using System.Windows.Forms;

namespace PrjTest.BL
{
    internal class BLSessions
    {
        DBMSProjectTestDataContext dbms;

        public BLSessions()
        {
            dbms = new DBMSProjectTestDataContext();
        }

        public DataTable GetSessions(int scholastic, int semester)
        {
            var sessionsQuery = (from r in dbms.Sessionsses
                                 where r.Scholastic == scholastic
                                 where r.Semester == semester
                                 select r);

            List<Sessions_Object> sessionsList = new List<Sessions_Object>();
            foreach (var session in sessionsQuery) 
            {
                Sessions_Object obj = new Sessions_Object(session.Sessionss_Name, session.Numberofcredits, session.Sessionss_ID, session.Semester, session.Scholastic);
                sessionsList.Add(obj);
            }
            DataTable data = ToDataTable(sessionsList);
            return data;
        }

        public bool UpdateSessions(string strID, string session_name, int NoC,int strScholastic, int strSemester)
        {

            var sessionquery = (from s in dbms.Sessionsses
                           where s.Sessionss_ID == strID
                           where s.Scholastic == Convert.ToDecimal(strScholastic)
                           where s.Semester == Convert.ToDecimal(strSemester)
                           select s).FirstOrDefault();
            try
            {
                if (sessionquery != null)
                {
                    sessionquery.Sessionss_Name = session_name;
                    sessionquery.Numberofcredits = Convert.ToDecimal(NoC);
                }
                dbms.SubmitChanges();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }
         public bool InsertSession(string strID, string session_name, int NoC,int strScholastic, int strSemester)
         {
            try
            {
                dbms.PROC_Add_Sessions(strID, session_name, Convert.ToDecimal(strSemester), Convert.ToDecimal(strScholastic), Convert.ToDecimal(NoC));
                dbms.SubmitChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        public bool DeleteSession(string strID, int strScholastic, int strSemester)
         {
            try
            {
                dbms.PROC_Delete_Sessions(strID, Convert.ToDecimal(strSemester), Convert.ToDecimal(strScholastic));
                dbms.SubmitChanges();
            }
            catch (SqlException ex)
            {
                MessageBox.Show( ex.ToString() , "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
            return true;
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
