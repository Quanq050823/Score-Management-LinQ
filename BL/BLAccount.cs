using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PrjTest.BL
{
    internal class BLAccount
    {
        public bool CheckAcc(int ID, string password, int type)
        {
            DBMSProjectTestDataContext dbms = new DBMSProjectTestDataContext();
            bool exist = false;    // to check if the account is exist or not
            try
            {
                if (type == 1)
                {
                    if (Convert.ToBoolean(dbms.FN_CheckAcc_Student(Convert.ToDecimal(ID), Convert.ToDecimal(password)) ) )
                    {
                        exist= true;
                    }
                }

                else
                {
                    if (Convert.ToBoolean(dbms.FN_CheckAcc_Teacher(Convert.ToDecimal(ID), Convert.ToDecimal(password)) ) )
                    {
                        exist = true;
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message , "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message , "Notification", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                return false;
            }

            return exist;
        }
    }
}
