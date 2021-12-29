using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace broadbandAPI.DAL
{
    /*

        Authors - Rushikes Patil, Ashvini M., Jayant Gaikwad.
        Description -  Data Access Layer.
     */


    public class broadbandDAL
    {


        // Login Procedure - Admin.

        public SqlDataReader LoginProcedure(string userName, String PassWord)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("loginProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter user = new SqlParameter("userName", userName);
                cmd.Parameters.Add(user);
                SqlParameter pass = new SqlParameter("passWord", PassWord);
                cmd.Parameters.Add(pass);
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }


        public SqlDataReader empLoginProcedure(string userName, String PassWord)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("empLoginProcedure", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter user = new SqlParameter("userName", userName);
                cmd.Parameters.Add(user);
                SqlParameter pass = new SqlParameter("passWord", PassWord);
                cmd.Parameters.Add(pass);
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }


        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>


        // Emp table procedure
        // emp connections

        public SqlDataReader GetEmp()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }

        // Emp - Get a single Emp  record from Database 

        public SqlDataReader GetSingleEmp(int empId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getSingleEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("empId", empId);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        //emp - Insert emp Data into database 

        public SqlDataReader InsertEmp(string empName, string empAddress,
            string empEmail, string empPhone)
        {
            //int temp =0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("insertEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empName", empName);
                cmd.Parameters.AddWithValue("empAddress", empAddress);
                cmd.Parameters.AddWithValue("empEmail", empEmail);
                cmd.Parameters.AddWithValue("empPhone", empPhone);



                //    temp = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return temp;
            return reader;
        }

        public SqlDataReader UpdateEmp(int empId, string empName, string empAddress,
            string empEmail, string empPhone)
        {
            //  int no = 0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("empId", empId);
                cmd.Parameters.AddWithValue("empName", empName);

                cmd.Parameters.AddWithValue("empAddress", empAddress);
                cmd.Parameters.AddWithValue("empEmail", empEmail);
                cmd.Parameters.AddWithValue("empPhone", empPhone);


                // no = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                //  con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return no;
            return reader;
        }

        public int DeleteEmp(int empId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deleteEmp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empId", empId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }


        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>


        // Task Table Procedure
        // tasl connections


        public SqlDataReader GetTask()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getTask", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }

        // Task - Get a task   record from Databas


        public SqlDataReader GetSingleTask(int taskId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getSingleTask", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("taskId", taskId);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        // task - Insert task Data into database 

        public SqlDataReader InsertTask(int empId, string taskName, string taskAssigned, string taskDes, string taskStatus, string startDate,
            string endDate)
        {
            //int temp =0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("insertTask", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("empId", empId);
                cmd.Parameters.AddWithValue("taskName", taskName);

                cmd.Parameters.AddWithValue("taskAssigned", taskAssigned);
                cmd.Parameters.AddWithValue("taskDes", taskDes);
                cmd.Parameters.AddWithValue("taskStatus", taskStatus);
                cmd.Parameters.AddWithValue("startDate", startDate);
                cmd.Parameters.AddWithValue("endDate", endDate);


                //    temp = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return temp;
            return reader;
        }

        public SqlDataReader UpdatTask(int taskId, int empId, string taskName, string taskAssigned, string taskDes, string taskStatus,
            string startDate, string endDate)
        {
            //  int no = 0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateTask", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("taskId", taskId);
                cmd.Parameters.AddWithValue("empId", empId);
                cmd.Parameters.AddWithValue("taskName", taskName);
                cmd.Parameters.AddWithValue("taskAssigned", taskAssigned);
                cmd.Parameters.AddWithValue("taskDes", taskDes);
                cmd.Parameters.AddWithValue("taskStatus", taskStatus);
                cmd.Parameters.AddWithValue("startDate", startDate);
                cmd.Parameters.AddWithValue("endDate", endDate);


                // no = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                //    temp = cmd.ExecuteNonQuery();

                //  con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return no;
            return reader;
        }


        public int DeleteTask(int taskId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deleteTask", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("taskId", taskId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }



        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>


        // Lead Table Procedures 
        // Get, insert, Update, Delete, convert into Opportunity.


        // lead - Get Lead all records from Database  
        public SqlDataReader GetLead()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getLead", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }

        // lead - Get a single Lead  record from Database 

        public SqlDataReader GetSingleLead(int leadId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getSingleLead", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("leadId", leadId);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }

        // lead - Insert lead Data into database 

        public SqlDataReader InsertLead(string leadName, string leadGender, string leadAddress,
            string leadEmail, string leadPhone, string leadCreatedBy, string leadCreatedOn)
        {
            //int temp =0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("insertLead", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("leadName", leadName);
                cmd.Parameters.AddWithValue("leadGender", leadGender);
                cmd.Parameters.AddWithValue("leadAddress", leadAddress);
                cmd.Parameters.AddWithValue("leadEmail", leadEmail);
                cmd.Parameters.AddWithValue("leadPhone", leadPhone);
                cmd.Parameters.AddWithValue("leadCreatedBy", leadCreatedBy);
                cmd.Parameters.AddWithValue("leadCreatedOn", leadCreatedOn);


                //    temp = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return temp;
            return reader;
        }

        public SqlDataReader UpdateLead(int leadId, string leadName, string leadGender, string leadAddress,
            string leadEmail, string leadPhone, string leadCreatedBy, string leadCreatedOn)
        {
            //  int no = 0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateLead", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("leadId", leadId);
                cmd.Parameters.AddWithValue("leadName", leadName);
                cmd.Parameters.AddWithValue("leadGender", leadGender);
                cmd.Parameters.AddWithValue("leadAddress", leadAddress);
                cmd.Parameters.AddWithValue("leadEmail", leadEmail);
                cmd.Parameters.AddWithValue("leadPhone", leadPhone);
                cmd.Parameters.AddWithValue("leadCreatedBy", leadCreatedBy);
                cmd.Parameters.AddWithValue("leadCreatedOn", leadCreatedOn);

                // no = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                //  con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return no;
            return reader;
        }

        public int DeleteLead(int leadId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deleteLead", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("leadId", leadId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
        public int ConvertIntoOpp(int leadId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("convertIntoOpp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("leadId", leadId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>


        // Opportunity  table procedure Connection
        //opp table

        public SqlDataReader GetOpp()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getOpp", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }

        // opp - Get a single opp  record from Database 

        public SqlDataReader GetSingleOpp(int oppId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getSingleOpp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("oppId", oppId);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }


        // opp - Insert opp Data into database 

        public SqlDataReader InsertOpp(string oppName, string oppGender, string oppAddress,
            string oppEmail, string oppPhone, string oppPlan, string oppPlanDetails, string oppPlanPrice, string oppCreatedBy, string oppCreatedOn)
        {
            //int temp =0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("insertOpp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("oppName", oppName);
                cmd.Parameters.AddWithValue("oppGender", oppGender);
                cmd.Parameters.AddWithValue("oppAddress", oppAddress);
                cmd.Parameters.AddWithValue("oppEmail", oppEmail);
                cmd.Parameters.AddWithValue("oppPhone", oppPhone);

                cmd.Parameters.AddWithValue("oppPlan", oppPlan);
                cmd.Parameters.AddWithValue("oppPlanDetails", oppPlanDetails);
                cmd.Parameters.AddWithValue("oppPlanPrice", oppPlanPrice);

                cmd.Parameters.AddWithValue("oppCreatedBy", oppCreatedBy);
                cmd.Parameters.AddWithValue("oppCreatedOn", oppCreatedOn);


                //    temp = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return temp;
            return reader;
        }

        public SqlDataReader UpdateOpp(int oppId, string oppName, string oppGender, string oppAddress,
            string oppEmail, string oppPhone, string oppPlan, string oppPlanDetails, string oppPlanPrice, string oppCreatedBy, string oppCreatedOn)
        {
            //  int no = 0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateOpp", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("oppId", oppId);
                cmd.Parameters.AddWithValue("oppName", oppName);
                cmd.Parameters.AddWithValue("oppGender", oppGender);
                cmd.Parameters.AddWithValue("oppAddress", oppAddress);
                cmd.Parameters.AddWithValue("oppEmail", oppEmail);
                cmd.Parameters.AddWithValue("oppPhone", oppPhone);


                cmd.Parameters.AddWithValue("oppPlan", oppPlan);
                cmd.Parameters.AddWithValue("oppPlanDetails", oppPlanDetails);
                cmd.Parameters.AddWithValue("oppPlanPrice", oppPlanPrice);

                cmd.Parameters.AddWithValue("oppCreatedBy", oppCreatedBy);
                cmd.Parameters.AddWithValue("oppCreatedOn", oppCreatedOn);

                // no = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                //  con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return no;
            return reader;
        }

        public int DeleteOpp(int oppId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deleteOpp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("oppId", oppId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
        public int ConvertIntAcc(int oppId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("convertIntoAcc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("oppId", oppId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        // Account Table 
        // account procedures


        public SqlDataReader GetAcc()
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getAcc", con);
                cmd.CommandType = CommandType.StoredProcedure;
                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;

            }
            return reader;
        }

        // acc - Get a single acc  record from Database 

        public SqlDataReader GetSingleAcc(int accId)
        {
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("getSingleAcc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter param = new SqlParameter("accId", accId);
                cmd.Parameters.Add(param);

                reader = cmd.ExecuteReader();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return reader;
        }


        // acc - Insert acc Data into database 

        public SqlDataReader InsertAcc(string accName, string accGender, string accAddress, 
            string accEmail, string accPhone, string accPlan,string accPlanDetails,string accPlanPrice, string accBilling, string accShipping, string accCreatedBy , string accCreatedOn)
        {
            //int temp =0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("insertAcc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("accName", accName);
                cmd.Parameters.AddWithValue("accGender", accGender);
                cmd.Parameters.AddWithValue("accAddress", accAddress);
                cmd.Parameters.AddWithValue("accEmail", accEmail);
                cmd.Parameters.AddWithValue("accPhone", accPhone);

                cmd.Parameters.AddWithValue("accPlan", accPlan);
                cmd.Parameters.AddWithValue("accPlanDetails", accPlanDetails);
                cmd.Parameters.AddWithValue("accPlanPrice", accPlanPrice);
                cmd.Parameters.AddWithValue("accBilling", accBilling);

                cmd.Parameters.AddWithValue("accShipping", accShipping);
                cmd.Parameters.AddWithValue("accCreatedBy", accCreatedBy);
                cmd.Parameters.AddWithValue("accCreatedOn", accCreatedOn);

                //    temp = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();


            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return temp;
            return reader;
        }

        public SqlDataReader UpdateAcc(int accId, string accName, string accGender, string accAddress,
            string accEmail, string accPhone, string accPlan, string accPlanDetails, string accPlanPrice, string accBilling, string accShipping, string accCreatedBy, string accCreatedOn)
        {
            //  int no = 0;
            SqlDataReader reader = null;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("updateAcc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("accId", accId);

                cmd.Parameters.AddWithValue("accName", accName);
                cmd.Parameters.AddWithValue("accGender", accGender);
                cmd.Parameters.AddWithValue("accAddress", accAddress);
                cmd.Parameters.AddWithValue("accEmail", accEmail);
                cmd.Parameters.AddWithValue("accPhone", accPhone);


                cmd.Parameters.AddWithValue("accPlan", accPlan);
                cmd.Parameters.AddWithValue("accPlanDetails", accPlanDetails);
                cmd.Parameters.AddWithValue("accPlanPrice", accPlanPrice);
                cmd.Parameters.AddWithValue("accBilling", accBilling);
                cmd.Parameters.AddWithValue("accShipping", accShipping);
                cmd.Parameters.AddWithValue("accCreatedBy", accCreatedBy);
                cmd.Parameters.AddWithValue("accCreatedOn", accCreatedOn);

                // no = cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();

                //  con.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            //  return no;
            return reader;
        }

        public int DeleteAcc(int accId)
        {
            int no = 0;
            try
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "Server=.;Database=broadbandDB;trusted_connection=true";
                con.Open();

                SqlCommand cmd = new SqlCommand("deleteAcc", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("accId", accId);
                no = cmd.ExecuteNonQuery();
                //con.Close();

            }
            catch (SqlException ex)
            {
                Console.WriteLine("Exception " + ex.Message);
                throw;
            }
            return no;
        }
      

































    }
}