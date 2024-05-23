using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjTest.Object
{
    internal class Sessions_Object
    {
        public Sessions_Object() { }

        public Sessions_Object(string session_Name, decimal noC, string session_ID, decimal semester, decimal scholastic)
        {
            this.session_Name = session_Name;
            this.noC = noC;
            this.session_ID = session_ID;
            this.semester = semester;
            this.scholastic = scholastic;
        }

        private string session_Name;
        private decimal noC;
        private string session_ID;
        private decimal semester;
        private decimal scholastic;

        public string Session_ID { get => session_ID; set => session_ID = value; }
        public string Session_Name { get => session_Name; set => session_Name = value; }
        public decimal Semester { get => semester; set => semester = value; }
        public decimal Scholastic { get => scholastic; set => scholastic = value; }
        public decimal NoC { get => noC; set => noC = value; }
    }
}
