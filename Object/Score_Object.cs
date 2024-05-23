using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Hooman
{
    internal class Score_Object
    {
        private decimal Student_ID, Scholastic, Semester, Process_Score, Final_Score, Avg_Score, NoCredit, four_pointScore;
        private bool status;
        private string Session_ID, Session_Name, letterScore;
        
        public Score_Object() { }

        public Score_Object(decimal student_ID, decimal scholastic, decimal semster, decimal process_Score, 
            decimal final_Score, decimal avg_Score, decimal noCredit, bool status, string session_ID, string session_Name, decimal four_pointScore, string letterScore)
        {
            Student_ID = student_ID;
            Scholastic = scholastic;
            Semester = semster;
            Process_Score = process_Score;
            Final_Score = final_Score;
            Avg_Score = avg_Score;
            NoCredit = noCredit;
            this.status = status;
            Session_ID = session_ID;
            Session_Name = session_Name;
            Four_pointScore = four_pointScore;
            LetterScore = letterScore;
        }


        public decimal Student_ID1 { get => Student_ID; set => Student_ID = value; }
        public decimal Scholastic1 { get => Scholastic; set => Scholastic = value; }
        public decimal Semester1 { get => Semester; set => Semester = value; }
        public decimal Process_Score1 { get => Process_Score; set => Process_Score = value; }
        public decimal Final_Score1 { get => Final_Score; set => Final_Score = value; }
        public decimal Avg_Score1 { get => Avg_Score; set => Avg_Score = value; }
        public decimal NoCredit1 { get => NoCredit; set => NoCredit = value; }
        public bool Status { get => status; set => status = value; }
        public string Session_ID1 { get => Session_ID; set => Session_ID = value; }
        public string Session_Name1 { get => Session_Name; set => Session_Name = value; }
        public decimal Four_pointScore { get => four_pointScore; set => four_pointScore = value; }
        public string LetterScore { get => letterScore; set => letterScore = value; }
    }
}
