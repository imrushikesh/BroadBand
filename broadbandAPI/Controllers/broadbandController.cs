using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using broadbandAPI.BAL;
using broadbandAPI.Models;


namespace broadbandAPI.Controllers
{
    public class broadbandController : ApiController
    {




        leadBAL leadBal = new leadBAL();

        oppBAL oppBal = new oppBAL();

        taskBal taskBal = new taskBal();

        empBAL empBal = new empBAL();

        accountBAL accBal = new accountBAL();

        loginBAL loginbal = new loginBAL();


        [HttpGet]
   
        // admin Login

        public HttpResponseMessage login(string userName, string passWord)
        {
            List<adminModel> dlist = loginbal.LoginPro(userName, passWord);

            if (dlist.Count == 1)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Login Successful");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Login Failed");
            }
        }

       

        [HttpGet]
        // emp Login

        public HttpResponseMessage empLogin(string userName, string passWord)
        {
            List<adminModel> dlist = loginbal.empLoginPro(userName, passWord);

            if (dlist.Count == 1)
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Employee Login Successful");
            }
            else
            {
                return Request.CreateErrorResponse(HttpStatusCode.Unauthorized, "Employee Login Failed");
            }
        }






        // emp module
        // emp  services

        [HttpGet]
        public List<empModel> GetEmp()
        {
            List<empModel> dlist = empBal.GetEmpData();
            return dlist;

        }


        [HttpGet]
        public empModel GetSingleEmp(int empId)
        {
            empModel lm = empBal.GetSingleEmpData(empId);
            return lm;

        }


        [HttpPost]
        public List<empModel> InsertEmp(empModel lm)
        {

            List<empModel> result = empBal.InsertEmpData(lm);
            //  HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, emp);
            // return response;

            List<empModel> empList = empBal.GetEmpData();


            return empList;
        }


        [HttpPut]
        public HttpResponseMessage UpdateEmp(empModel lm)
        {
            List<empModel> result = empBal.UpdatEmpData(lm);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, result);
            return response;


        }



        [HttpDelete]
        public HttpResponseMessage DeleteEmp(int empId)
        {
            int result = empBal.DeleteEmpData(empId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }



/*--------------------------------------------------------------------------------------------------------------------------------------------
 * ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////------------------------*//**/




        // Task Module 

        // task Services

        [HttpGet]
        public List<taskModel> GetTask()
        {
            List<taskModel> dlist = taskBal.GetTaskData();
            return dlist;

        }


        [HttpGet]
        public taskModel GetSingleTask(int taskId)
        {
            taskModel lm = taskBal.GetSingleTaskData(taskId);
            return lm;

        }


        [HttpPost]
        public List<taskModel> InsertTask(taskModel lm)
        {

            List<taskModel> result = taskBal.InsertTaskData(lm);
            //  HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lead);
            // return response;

            List<taskModel> leadList = taskBal.GetTaskData();


            return leadList;
        }


        [HttpPut]
        public HttpResponseMessage UpdateTask(taskModel lm)
        {
            List<taskModel> result = taskBal.UpdateTaskData(lm);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, result);
            return response;


        }



        [HttpDelete]
        public HttpResponseMessage DeleteTask(int taskId)
        {
            int result = taskBal.DeleteTaskData(taskId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }


 /*------------------------------------------------------------------------------------------------------------------------------------------------------------
 * ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////------------------------*//**/






        // lead module
        // lead Services

        [HttpGet]
        public List<leadModel> GetLead()
        {
            List<leadModel> dlist = leadBal.GetLeadData();
            return dlist;
          
        }


      [HttpGet]
        public leadModel GetSingleLead(int leadId)
        {
            leadModel lm = leadBal.GetSingleLeadData(leadId);
            return lm;

        }


        [HttpPost]
        public List<leadModel> InsertLead(leadModel lm)
        {
         
           List<leadModel> result = leadBal.InsertLeadData(lm);
           //  HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, lead);
            // return response;

            List<leadModel> leadList = leadBal.GetLeadData();


            return leadList;
        }
        

        [HttpPut]
        public HttpResponseMessage UpdateLead(leadModel lm)
        {
            List<leadModel> result = leadBal.UpdateLeadData(lm);
             HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, result);
             return response;


        }

        

        [HttpDelete]
        public HttpResponseMessage DeleteLead(int leadId)
        {
            int result = leadBal.DeleteLeadData(leadId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }


        // Convert lead

        [HttpPut]
        public HttpResponseMessage ConvertIntoOpp(int leadId)
        {
            int result = leadBal.ConvertIntoOpp(leadId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }


/*--------------------------------------------------------------------------------------------------------------------------------------------
 * * ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////------------------------*//**/



        // Opportunity module
        // opp services

        [HttpGet]
        public List<oppModel> GetOpp()
        {
            List<oppModel> dlist = oppBal.GetOppData();
            return dlist;

        }


        [HttpGet]
        public oppModel GetSingleOpp(int oppId)
        {
            oppModel lm = oppBal.GetSingleOppData(oppId);
            return lm;

        }

        [HttpPost]
        public List<oppModel> InsertOpp(oppModel lm)
        {

            List<oppModel> result = oppBal.InsertOppData(lm);
            //  HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, Opp);
            // return response;

            List<oppModel> OppList = oppBal.GetOppData();


            return OppList;
        }


        [HttpPut]
        public HttpResponseMessage UpdateOpp(oppModel lm)
        {
            List<oppModel> result = oppBal.UpdateOppData(lm);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, result);
            return response;


        }



        [HttpDelete]
        public HttpResponseMessage DeleteOpp(int oppId)
        {
            int result = oppBal.DeleteOppData(oppId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }


        // Convert into acc

        [HttpPut]
        public HttpResponseMessage ConvertIntoAcc(int oppId)
        {
            int result = oppBal.ConvertIntoAcc(oppId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }



        /*--------------------------------------------------------------------------------------------------------------------------------------------
        * ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////------------------------*//**/


        [HttpGet]
        public List<accModel> GetAcc()
        {
            List<accModel> dlist = accBal.GetAccData();
            return dlist;

        }


        [HttpGet]
        public accModel GetSingleAcc(int accId)
        {
            accModel lm = accBal.GetSingleAccData(accId);
            return lm;

        }


        [HttpPost]
        public List<accModel> InsertAcc(accModel lm)
        {

            List<accModel> result = accBal.InsertAccData(lm);
            //  HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, emp);
            // return response;

            List<accModel> empList = accBal.GetAccData();


            return empList;
        }


        [HttpPut]
        public HttpResponseMessage UpdateAcc(accModel lm)
        {
            List<accModel> result = accBal.UpdateAccData(lm);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.Created, result);
            return response;


        }



        [HttpDelete]
        public HttpResponseMessage DeleteAcc(int empId)
        {
            int result = accBal.DeleteAccData(empId);
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, result);
            return response;
        }













    }
}
