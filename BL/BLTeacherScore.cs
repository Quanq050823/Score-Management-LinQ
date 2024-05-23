using PrjTest.Hooman;
using PrjTest.Object;
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
    internal class BLTeacherScore
    {
        DBMSProjectTestDataContext dbms;

        public BLTeacherScore()
        {
             dbms = new DBMSProjectTestDataContext();
        }

        public DataTable GetScore(int ID, int Scholastic, int Semester, string session_ID, string course_ID)
        {
            DataTable myDataTable = new DataTable();
            var scorequery = (from r in dbms.Teacher_Scores
                              where r.Teacher_ID == ID
                              where r.Scholastic == Scholastic
                              where r.Semester == Semester
                              where r.Sessionss_ID == session_ID
                              where r.Course_ID == course_ID
                              select r);

            List<TeacherScore_Object> scoreList = new List<TeacherScore_Object>();

            foreach (var score in scorequery)
            {
                TeacherScore_Object scoreOb = new TeacherScore_Object(score.Student_ID, score.Student_Name,score.Sessionss_ID,score.Sessionss_Name, 
                    score.Course_ID, score.Teacher_ID ,score.Scholastic, score.Semester,Convert.ToDecimal(score.Numberofcredits), 
                    Convert.ToDecimal(score.Process_score),Convert.ToDecimal(score.Final_exam), Convert.ToDecimal(score.Average_score), 
                    Convert.ToBoolean(score.Status)  );

                scoreList.Add(scoreOb);
            }

            DataTable data = ToDataTable(scoreList);

            // myDataTable = scorequery.CopyToDataTable();

            return data;
        }

        public List<string> GetCourse(int ID, int scholastic, int semester)
        {
            List<string> course = new List<string>();

            var courseQuery = (from r in dbms.Courses
                              where r.Teacher_ID == ID
                              where r.Scholastic == scholastic
                              where r.Semester == semester
                              select r);

            foreach(var c in courseQuery)
            {
                string courseTmp = c.Sessionss_ID.ToString() + " " + c.Course_ID.ToString();
                course.Add(courseTmp);
            }

            return course;
        }

        public DataTable GetCourse_dgv(int ID, int Scholastic, int Semester)
        {
            DataTable myDataTable = new DataTable();
            var courseQuery = (from r in dbms.Course_Sessionsses
                              where r.Teacher_ID == ID
                              where r.Scholastic == Scholastic
                              where r.Semester == Semester
                              select r);

            List<TeacherCourse_Object> scoreList = new List<TeacherCourse_Object>();

            foreach (var c in courseQuery)
            {
                TeacherCourse_Object scoreOb = new TeacherCourse_Object(c.Teacher_ID, c.Sessionss_ID, c.Sessionss_Name, c.Course_ID, c.Scholastic, c.Semester);

                scoreList.Add(scoreOb);
            }

            DataTable data = ToDataTable(scoreList);

            // myDataTable = scorequery.CopyToDataTable();

            return data;
        }

        public bool UpdateScore(string strID, string strSessionssID, string strSemester, string strScholastic, string ProScore, string FiScore)
        {
            var scquery = (from score in dbms.Scores
                           where score.Student_ID == Convert.ToDecimal(strID)
                           where score.Sessionss_ID == strSessionssID
                           where score.Scholastic == Convert.ToDecimal(strScholastic)
                           where score.Semester == Convert.ToDecimal(strSemester)
                           select score).FirstOrDefault();
            try
            {
                if (scquery != null)
                {
                    scquery.Process_score = Convert.ToDecimal(ProScore);
                    scquery.Final_exam = Convert.ToDecimal(FiScore);
                }
                dbms.SubmitChanges();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error on database connection \nData is not updated", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }
        }

        public DataTable GetScoreAdmin(int Scholastic, int Semester, string Session_ID)
        {
            DataTable myDataTable = new DataTable();
            var scorequeryAD = (from r in dbms.Teacher_Scores
                                where r.Scholastic == Scholastic
                                where r.Semester == Semester
                                where r.Sessionss_ID == Session_ID
                                select r);

            List<TeacherScore_Object> scoreADList = new List<TeacherScore_Object>();

            foreach (var score in scorequeryAD)
            {
                TeacherScore_Object scoreOb = new TeacherScore_Object(score.Student_ID, score.Student_Name, score.Sessionss_ID, score.Sessionss_Name,
                    score.Course_ID, score.Teacher_ID, score.Scholastic, score.Semester, Convert.ToDecimal(score.Numberofcredits),
                    Convert.ToDecimal(score.Process_score), Convert.ToDecimal(score.Final_exam), Convert.ToDecimal(score.Average_score),
                    Convert.ToBoolean(score.Status));


                scoreADList.Add(scoreOb);
            }

            DataTable data = ToDataTable(scoreADList);

            // myDataTable = scorequery.CopyToDataTable();

            return data;
        }

        public List<string> GetSession(int scholastic, int semester)
        {
            List<string> session = new List<string>();

            var sessionQuery = (from r in dbms.Teacher_Scores
                                where r.Scholastic == scholastic
                                where r.Semester == semester
                                select r);
            string query = "Select * FROM Teacher_Scores t WHERE t.Scholastic = @Scholastic" +
                "AND t.Semester = @Semester";
               
            foreach (var s in sessionQuery)
            {
                string sessionTmp = s.Sessionss_ID.ToString();
                session.Add(sessionTmp);
            }
            return session;
        }

        public DataTable ToDataTable<T>(List<T> list)
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
