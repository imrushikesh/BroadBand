using broadbandAPI.DAL;
using broadbandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace broadbandAPI.BAL
{
    public class oppBAL
    {

        broadbandDAL dal = new broadbandDAL();

        public List<oppModel> GetOppData()
        {
            SqlDataReader reader = dal.GetOpp();
            List<oppModel> dlist = new List<oppModel>();
            while (reader.Read())
            {
                oppModel dm = new oppModel();
                dm.oppId = Convert.ToInt32(reader["oppId"].ToString());
                dm.leadId = reader["leadId"] == System.DBNull.Value ? default(int) : (int)reader["leadId"];
                //  dm.oppId = Convert.ToInt32(reader["oppId"].ToString());
                dm.oppName = reader["oppName"].ToString();
                dm.oppGender = reader["oppGender"].ToString();
                dm.oppAddress = reader["oppAddress"].ToString();
                dm.oppEmail = reader["oppEmail"].ToString();
                dm.oppPhone = reader["oppPhone"].ToString();

                dm.oppPlan = reader["oppPlan"].ToString();
                dm.oppPlanDetails = reader["oppPlanDetails"].ToString();
                dm.oppPlanPrice = reader["oppPlanPrice"].ToString();
                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCreatedOn"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();

                dlist.Add(dm);
            }
            return dlist;
        }

        // opp - Get single opp from DAL 

        public oppModel GetSingleOppData(int oppId)
        {
            SqlDataReader reader = dal.GetSingleOpp(oppId);
            oppModel dm = null;

            while (reader.Read())
            {
                dm = new oppModel();
                dm.oppId = Convert.ToInt32(reader["oppId"].ToString());
              
                object o = reader["leadId"];
                if (o == DBNull.Value)
                {
                    dm.leadId = 0;
                }
                else
                {
                    dm.leadId = Convert.ToInt32(reader["leadId"].ToString());
                }


                // dm.leadId = Convert.ToInt32(reader["leadId"].ToString());
             

                dm.oppName = reader["oppName"].ToString();
                dm.oppGender = reader["oppGender"].ToString();
                dm.oppAddress = reader["oppAddress"].ToString();
                dm.oppEmail = reader["oppEmail"].ToString();
                dm.oppPhone = reader["oppPhone"].ToString();

                dm.oppPlan = reader["oppPlan"].ToString();
                dm.oppPlanDetails = reader["oppPlanDetails"].ToString();
                dm.oppPlanPrice = reader["oppPlanPrice"].ToString();

                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCreatedOn"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();
                
            }
            return dm;
        }

        public List<oppModel> InsertOppData(oppModel lm)
        {
            SqlDataReader reader = dal.InsertOpp(lm.oppName, lm.oppGender, lm.oppAddress, lm.oppEmail, lm.oppPhone,lm.oppPlan,lm.oppPlanDetails,lm.oppPlanPrice, lm.oppCreatedBy, lm.oppCreatedOn);


            List<oppModel> dlist = new List<oppModel>();
            // reader.Read();

            oppModel dm = new oppModel();
            while (reader.Read())
            {
                dm.oppName = reader["oppName"].ToString();
                dm.oppGender = reader["oppGender"].ToString();
                dm.oppAddress = reader["oppAddress"].ToString();
                dm.oppEmail = reader["oppEmail"].ToString();
                dm.oppPhone = reader["oppPhone"].ToString();

                dm.oppPlan = reader["oppPlan"].ToString();
                dm.oppPlanDetails = reader["oppPlanDetails"].ToString();
                dm.oppPlanPrice = reader["oppPlanPrice"].ToString();

                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCratedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }


        public List<oppModel> UpdateOppData(oppModel lm)
        {
            SqlDataReader reader = dal.UpdateOpp(lm.oppId,lm.oppName, lm.oppGender, lm.oppAddress, lm.oppEmail, lm.oppPhone, lm.oppPlan, lm.oppPlanDetails, lm.oppPlanPrice, lm.oppCreatedBy, lm.oppCreatedOn);
            List<oppModel> dlist = new List<oppModel>();
            //reader.Read();

            oppModel dm = new oppModel();
            while (reader.Read())
            {
                dm.oppName = reader["oppName"].ToString();
                dm.oppGender = reader["oppGender"].ToString();
                dm.oppAddress = reader["oppAddress"].ToString();
                dm.oppEmail = reader["oppEmail"].ToString();
                dm.oppPhone = reader["oppPhone"].ToString();

                dm.oppPlan = reader["oppPlan"].ToString();
                dm.oppPlanDetails = reader["oppPlanDetails"].ToString();
                dm.oppPlanPrice = reader["oppPlanPrice"].ToString();

                dm.oppCreatedBy = reader["oppCreatedBy"].ToString();
                dm.oppCreatedOn = reader["oppCratedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }



        public int DeleteOppData(int oppId)
        {
            int result = dal.DeleteOpp(oppId);
            return result;

        }


        public int ConvertIntoAcc(int oppId)
        {
            int result = dal.ConvertIntAcc(oppId);
            return result;

        }






    }
}