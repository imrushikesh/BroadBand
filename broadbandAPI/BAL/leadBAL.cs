using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using broadbandAPI.DAL;
using broadbandAPI.Models;

namespace broadbandAPI.BAL
{



    /*
 
    Authors - Rushikes Patil, Ashvini M., Jayant Gaikwad.
    Description -  Busineess Access Layer.
 */
    public class leadBAL
    {

        broadbandDAL dal = new broadbandDAL();

        // Admin login Procedure




        // Lead Procedures


        // lead - Get Lead from DAL 

        public List<leadModel> GetLeadData()
        {
            SqlDataReader reader = dal.GetLead();
            List<leadModel> dlist = new List<leadModel>();
            while (reader.Read())
            {
                leadModel dm = new leadModel();
                dm.leadId = Convert.ToInt32(reader["leadId"].ToString());
                dm.leadName = reader["leadName"].ToString();
                dm.leadGender = reader["leadGender"].ToString();
                dm.leadAddress = reader["leadAddress"].ToString();
                dm.leadEmail = reader["leadEmail"].ToString();
                dm.leadPhone = reader["leadPhone"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCreatedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;
        }

        // lead - Get single Lead from DAL 

        public leadModel GetSingleLeadData(int leadId)
        {
            SqlDataReader reader = dal.GetSingleLead(leadId);
            leadModel lm = null;

            while (reader.Read())
            {
                lm = new leadModel();
                lm.leadId = Convert.ToInt32(reader["leadId"].ToString());
                lm.leadName = reader["leadName"].ToString();
                lm.leadGender = reader["leadGender"].ToString();
                lm.leadAddress = reader["leadAddress"].ToString();
                lm.leadEmail = reader["leadEmail"].ToString();
                lm.leadPhone = reader["leadPhone"].ToString();
                lm.leadCreatedBy = reader["leadCreatedBy"].ToString();
              lm.leadCreatedOn = reader["leadCratedOn"].ToString();
            }
            return lm;
        }

        // lead - insert single Lead in DAL
        public List<leadModel> InsertLeadData(leadModel lm)
        {
            SqlDataReader reader = dal.InsertLead(lm.leadName, lm.leadGender, lm.leadAddress, lm.leadEmail, lm.leadPhone, lm.leadCreatedBy, lm.leadCreatedOn) ;


            List<leadModel> dlist = new List<leadModel>();
           // reader.Read();
          
                leadModel dm = new leadModel() ;
            while (reader.Read())
            {
                dm.leadName = reader["leadName"].ToString();
                dm.leadGender = reader["leadGender"].ToString();
                dm.leadAddress = reader["leadAddress"].ToString();
                dm.leadEmail = reader["leadEmail"].ToString();
                dm.leadPhone = reader["leadPhone"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCratedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;

          //  return result;

        }


        public List<leadModel> UpdateLeadData(leadModel lm)
        {
            SqlDataReader reader = dal.UpdateLead(lm.leadId, lm.leadName, lm.leadGender, lm.leadAddress, lm.leadEmail, lm.leadPhone,lm.leadCreatedBy, lm.leadCreatedOn);
            List<leadModel> dlist = new List<leadModel>();
            //reader.Read();

            leadModel dm = new leadModel();
            while (reader.Read())
            {
                dm.leadName = reader["leadName"].ToString();
                dm.leadGender = reader["leadGender"].ToString();
                dm.leadAddress = reader["leadAddress"].ToString();
                dm.leadEmail = reader["leadEmail"].ToString();
                dm.leadPhone = reader["leadPhone"].ToString();
                dm.leadCreatedBy = reader["leadCreatedBy"].ToString();
                dm.leadCreatedOn = reader["leadCratedOn"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }

    

        public int DeleteLeadData(int leadId)
        {
            int result = dal.DeleteLead(leadId);
            return result;

        }


        public int ConvertIntoOpp(int leadId)
        {
            int result = dal.ConvertIntoOpp(leadId);
            return result;

        }
    }
}
