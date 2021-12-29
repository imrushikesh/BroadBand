using broadbandAPI.DAL;
using broadbandAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace broadbandAPI.BAL
{
    public class taskBal
    {
        broadbandDAL dal = new broadbandDAL();

        public List<taskModel> GetTaskData()
        {
            SqlDataReader reader = dal.GetTask();
            List<taskModel> dlist = new List<taskModel>();
            while (reader.Read())
            {
                taskModel dm = new taskModel();
                dm.taskId = Convert.ToInt32(reader["taskId"].ToString());
                dm.empId = reader["empId"] == System.DBNull.Value ? default(int) : (int)reader["empId"];
                dm.taskName = reader["taskName"].ToString();
                dm.taskAssigned = reader["taskAssigned"].ToString();
                dm.taskDes = reader["taskDes"].ToString();
                dm.taskStatus = reader["taskStatus"].ToString();
                dm.startDate = reader["startDate"].ToString();
                dm.endDate = reader["endDate"].ToString();

                dlist.Add(dm);
            }
            return dlist;
        }

        // Task - Get single Task from DAL 

        public taskModel GetSingleTaskData(int taskId)
        {
            SqlDataReader reader = dal.GetSingleTask(taskId);
            taskModel lm = null;

            while (reader.Read())
            {
                lm = new taskModel();
                lm.taskId = Convert.ToInt32(reader["taskId"].ToString());
                lm.empId = reader["empId"] == System.DBNull.Value ? default(int) : (int)reader["empId"];
                lm.taskName = reader["taskName"].ToString();
                lm.taskAssigned = reader["taskAssigned"].ToString();
                lm.taskDes = reader["taskDes"].ToString();
                lm.taskStatus = reader["taskStatus"].ToString();
                lm.startDate = reader["startDate"].ToString();
                lm.endDate = reader["endDate"].ToString();
            }
            return lm;
        }

        // Task - insert single Task in DAL
        public List<taskModel> InsertTaskData(taskModel lm)
        {
            SqlDataReader reader = dal.InsertTask(lm.empId,lm.taskName, lm.taskAssigned, lm.taskDes, lm.taskStatus, lm.startDate,lm.endDate);


            List<taskModel> dlist = new List<taskModel>();
            // reader.Read();

            taskModel dm = new taskModel();
            while (reader.Read())
            {
                dm.empId = Convert.ToInt32(reader["empId"].ToString());
                dm.taskName = reader["taskName"].ToString();
                dm.taskAssigned = reader["taskAssigned"].ToString();
                dm.taskDes = reader["taskDes"].ToString();
                dm.taskStatus = reader["taskStatus"].ToString();
                dm.startDate = reader["startDate"].ToString();
                dm.endDate = reader["endDate"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }


        public List<taskModel> UpdateTaskData(taskModel lm)
        {
            SqlDataReader reader = dal.UpdatTask(lm.taskId,lm.empId, lm.taskName, lm.taskAssigned, lm.taskDes, lm.taskStatus, lm.startDate, lm.endDate);
            List<taskModel> dlist = new List<taskModel>();
            //reader.Read();

            taskModel dm = new taskModel();
            while (reader.Read())
            {
                dm.empId = Convert.ToInt32(reader["empId"].ToString());
                dm.taskName = reader["taskName"].ToString();
                dm.taskAssigned = reader["taskAssigned"].ToString();
                dm.taskDes = reader["taskDes"].ToString();
                dm.taskStatus = reader["taskStatus"].ToString();
                dm.startDate = reader["startDate"].ToString();
                dm.endDate = reader["endDate"].ToString();
                dlist.Add(dm);
            }
            return dlist;

            //  return result;

        }



        public int DeleteTaskData(int taskId)
        {
            int result = dal.DeleteTask(taskId);
            return result;

        }







    }
}