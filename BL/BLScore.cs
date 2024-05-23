using PrjTest.Hooman;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;


namespace PrjTest.BL
{
    internal class BLScore
    {
        DBMSProjectTestDataContext dbms;

        public BLScore()
        {
            dbms = new DBMSProjectTestDataContext();
        }

        /// <summary>
        /// Get all score of the student
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Scholastic"></param>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public DataTable GetScore(int ID, int Scholastic, int Semester)
        {
            DataTable myDataTable = new DataTable();
            var scorequery = (from r in dbms.View_Scores
                           where r.Student_ID == ID
                           where r.Semester == Semester
                           where r.Scholastic == Scholastic
                           select r);

            List<Score_Object> scoreList = new List<Score_Object> ();

            foreach(var score in scorequery)
            {
                Score_Object scoreOb = new Score_Object(score.Student_ID, score.Scholastic, score.Semester, Convert.ToDecimal(score.Process_score), 
                    Convert.ToDecimal(score.Final_exam), Convert.ToDecimal(score.Average_score), Convert.ToDecimal(score.Numberofcredits), 
                    Convert.ToBoolean(score.Status), score.Sessionss_ID, score.Sessionss_Name, Convert.ToDecimal(score.FourPoitingScore), score.LetterScore);

                scoreList.Add(scoreOb);
            }
            
            DataTable data = ToDataTable(scoreList);

            // myDataTable = scorequery.CopyToDataTable();

            return data;
        }


        /// <summary>
        /// Get average score and total credits of that semester
        /// </summary>
        /// <param name="ID"></param>
        /// <param name="Scholastic"></param>
        /// <param name="Semester"></param>
        /// <returns></returns>
        public string[] GetAvg_NoC(int ID, int Scholastic, int Semester)
        {
            string[] getValue = new string[] { "","" };

            //query to sort for the student with ID
            var queryGetValue = from student in dbms.Average_Scores
                                where student.Student_ID == ID
                                where student.Semester == Semester
                                where student.Scholastic == Scholastic
                                select student;
                
            var result = queryGetValue.ToList();

            //Get value about total credit and average score of that scholastic by semester
            foreach (var value in result)
            {
                getValue[0] = value.TotalCredits.ToString();
                getValue[1] = value.SumAverage.ToString();
            }

            return getValue;
        }

        public int GetAccumulatedCredits(int ID)
        {
            int result = 0;
            try
            {
                result = Convert.ToInt32(dbms.FN_Count_TotalCredit(ID));
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return result;
        }

        public decimal GetAccumulatedAvg(int ID)
        {
            decimal result = 0;
            try
            {
                result = Decimal.Round(Convert.ToDecimal(dbms.FN_Caculate_AccAvgScore(ID)),2);
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.ToString(), "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            return result;
        }

        //Convert List to datatable
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
