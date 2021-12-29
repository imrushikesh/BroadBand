using broadbandAPI.DAL;
using broadbandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace broadbandAPI.BAL
{
    public class accountBAL
    {

        broadbandDAL dal = new broadbandDAL();

        public List<accModel> GetAccData()
        {
            SqlDataReader reader = dal.GetAcc();
            List<accModel> dlist = new List<accModel>();
            while (reader.Read())
            {
                accModel dm = new accModel();
                dm.accId = Convert.ToInt32(reader["accId"].ToString());
                dm.oppId = reader["oppId"] == System.DBNull.Value ? default(int) : (int)reader["oppId"];
                dm.leadId = reader["leadId"] == System.DBNull.Value ? default(int) : (int)reader["leadId"];
                //  dm.AccId = Convert.ToInt32(reader["AccId"].ToString());
                dm.accName = reader["AccName"].ToString();
                dm.accGender = reader["AccGender"].ToString();
                dm.accAddress = reader["AccAddress"].ToString();
                dm.accEmail = reader["AccEmail"].ToString();
                dm.accPhone = reader["AccPhone"].ToString();

                dm.accPlan = reader["accPlan"].ToString();
                dm.accPlanDetails = reader["accPlanDetails"].ToString();
                dm.accPlanPrice = reader["accPlanPrice"].ToString();
                dm.accCreatedBy = reader["accCreatedBy"].ToString();
                dm.accCreatedOn = reader["accCreatedOn"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();
                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCreatedOn"].ToString();

                dlist.Add(dm);
            }
            return dlist;
        }

        // Acc - Get single Acc from DAL 

        public accModel GetSingleAccData(int accId)
        {
            SqlDataReader reader = dal.GetSingleAcc(accId);
            accModel dm = null;

            while (reader.Read())
            {
                dm = new accModel();
                dm.accId = Convert.ToInt32(reader["accId"].ToString());
                dm.oppId = reader["oppId"] == System.DBNull.Value ? default(int) : (int)reader["oppId"];
                dm.leadId = reader["leadId"] == System.DBNull.Value ? default(int) : (int)reader["leadId"];
                //  dm.AccId = Convert.ToInt32(reader["AccId"].ToString());
                dm.accName = reader["AccName"].ToString();
                dm.accGender = reader["AccGender"].ToString();
                dm.accAddress = reader["AccAddress"].ToString();
                dm.accEmail = reader["AccEmail"].ToString();
                dm.accPhone = reader["AccPhone"].ToString();

                dm.accPlan = reader["accPlan"].ToString();
                dm.accPlanDetails = reader["accPlanDetails"].ToString();
                dm.accPlanPrice = reader["accPlanPrice"].ToString();

                dm.accCreatedBy = reader["accCreatedBy"].ToString();
                dm.accCreatedOn = reader["accCreatedOn"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();
                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCreatedOn"].ToString();

            }
            return dm;
        }

        public List<accModel> InsertAccData(accModel lm)
        {
            SqlDataReader reader = dal.InsertAcc(lm.accName, lm.accGender, lm.accAddress, lm.accEmail, lm.accPhone, lm.accPlan, lm.accPlanDetails, lm.accPlanPrice,lm.accBilling, lm.accShipping, lm.accCreatedBy, lm.accCreatedOn);


            List<accModel> dlist = new List<accModel>();
            // reader.Read();

            accModel dm = new accModel();
            while (reader.Read())
            {
                dm.accName = reader["AccName"].ToString();
                dm.accGender = reader["AccGender"].ToString();
                dm.accAddress = reader["AccAddress"].ToString();
                dm.accEmail = reader["AccEmail"].ToString();
                dm.accPhone = reader["AccPhone"].ToString();

                dm.accPlan = reader["accPlan"].ToString();
                dm.accPlanDetails = reader["accPlanDetails"].ToString();
                dm.accPlanPrice = reader["accPlanPrice"].ToString();
                dm.accCreatedBy = reader["accBilling"].ToString();
                dm.accCreatedOn = reader["accShipping"].ToString();
                dm.accCreatedBy = reader["accCreatedBy"].ToString();
                dm.accCreatedOn = reader["accCreatedOn"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();
                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCreatedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }


        public List<accModel> UpdateAccData(accModel lm)
        {
            SqlDataReader reader = dal.UpdateAcc(lm.accId, lm.accName, lm.accGender, lm.accAddress, lm.accEmail, lm.accPhone, lm.accPlan, lm.accPlanDetails, lm.accPlanPrice, lm.accBilling, lm.accShipping, lm.accCreatedBy, lm.accCreatedOn);
            List<accModel> dlist = new List<accModel>();
            //reader.Read();

            accModel dm = new accModel();
            while (reader.Read())
            {
                dm.accName = reader["AccName"].ToString();
                dm.accGender = reader["AccGender"].ToString();
                dm.accAddress = reader["AccAddress"].ToString();
                dm.accEmail = reader["AccEmail"].ToString();
                dm.accPhone = reader["AccPhone"].ToString();

                dm.accPlan = reader["accPlan"].ToString();
                dm.accPlanDetails = reader["accPlanDetails"].ToString();
                dm.accPlanPrice = reader["accPlanPrice"].ToString();
                dm.accCreatedBy = reader["accBilling"].ToString();
                dm.accCreatedOn = reader["accShipping"].ToString();
                dm.accCreatedBy = reader["accCreatedBy"].ToString();
                dm.accCreatedOn = reader["accCreatedOn"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();
                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCreatedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }



        public int DeleteAccData(int accId)
        {
            int result = dal.DeleteAcc(accId);
            return result;

        }























    }
}