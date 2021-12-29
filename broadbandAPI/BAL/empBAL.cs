using broadbandAPI.DAL;
using broadbandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace broadbandAPI.BAL
{
    public class empBAL
    {

        broadbandDAL dal = new broadbandDAL();
        public List<empModel> GetEmpData()
        { 
            SqlDataReader reader = dal.GetEmp();
            List<empModel> dlist = new List<empModel>();
            while (reader.Read())
            {
                empModel dm = new empModel();
                dm.empId = Convert.ToInt32(reader["empId"].ToString());
                dm.empName = reader["empName"].ToString();
                
                dm.empAddress = reader["empAddress"].ToString();
                dm.empEmail = reader["empEmail"].ToString();
                dm.empPhone = reader["empPhone"].ToString();
                dlist.Add(dm);
            }
            return dlist;
        }

        // emp - Get single emp from DAL 

        public empModel GetSingleEmpData(int empId)
        {
            SqlDataReader reader = dal.GetSingleEmp(empId);
            empModel lm = null;

            while (reader.Read())
            {
                lm = new empModel();
                lm.empId = Convert.ToInt32(reader["empId"].ToString());
                lm.empName = reader["empName"].ToString();
               
                lm.empAddress = reader["empAddress"].ToString();
                lm.empEmail = reader["empEmail"].ToString();
                lm.empPhone = reader["empPhone"].ToString();
            }
            return lm;
        }

        // emp - insert single emp in DAL
        public List<empModel> InsertEmpData(empModel lm)
        {
            SqlDataReader reader = dal.InsertEmp(lm.empName, lm.empAddress, lm.empEmail, lm.empPhone);


            List<empModel> dlist = new List<empModel>();
            // reader.Read();

            empModel dm = new empModel();
            while (reader.Read())
            {
                dm.empName = reader["empName"].ToString();
               
                dm.empAddress = reader["empAddress"].ToString();
                dm.empEmail = reader["empEmail"].ToString();
                dm.empPhone = reader["empPhone"].ToString();
          
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }


        public List<empModel> UpdatEmpData(empModel lm)
        {
            SqlDataReader reader = dal.UpdateEmp(lm.empId, lm.empName, lm.empAddress, lm.empEmail, lm.empPhone);
            List<empModel> dlist = new List<empModel>();
            //reader.Read();

            empModel dm = new empModel();
            while (reader.Read())
            {
                dm.empName = reader["empName"].ToString();
                dm.empAddress = reader["empAddress"].ToString();
                dm.empEmail = reader["empEmail"].ToString();
                dm.empPhone = reader["empPhone"].ToString();
              
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }



        public int DeleteEmpData(int empId)
        {
            int result = dal.DeleteEmp(empId);
            return result;

        }













    }
}