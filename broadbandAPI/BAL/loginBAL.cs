using broadbandAPI.DAL;
using broadbandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace broadbandAPI.BAL
{
    public class loginBAL
    {

        broadbandDAL dal = new broadbandDAL();


        // Admin login procedure
        public List<adminModel> LoginPro(string userName, string PassWord)
        {
            SqlDataReader reader = dal.LoginProcedure(userName, PassWord);
            List<adminModel> dlist = new List<adminModel>();
            while (reader.Read())
            {
                adminModel dm = new adminModel();
                dm.userName = reader["userName"].ToString();
                dm.passWord = reader["passWord"].ToString();

                dlist.Add(dm);
            }
            return dlist;
        }


        // emp login procedure

        public List<adminModel> empLoginPro(string userName, string PassWord)
        {
            SqlDataReader reader = dal.empLoginProcedure(userName, PassWord);
            List<adminModel> dlist = new List<adminModel>();
            while (reader.Read())
            {
                adminModel dm = new adminModel();
                dm.userName = reader["userName"].ToString();
                dm.passWord = reader["passWord"].ToString();

                dlist.Add(dm);
            }
            return dlist;
        }

    }
}