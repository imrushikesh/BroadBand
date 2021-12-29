import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';


@Injectable({
  providedIn: 'root'
})
export class ServiceAPIService {

  leadUri ="https://localhost:44391/api/broadband/GetLead";
  singleLeadUri ="https://localhost:44391/api/broadband/GetSingleLead";
 insertUri ="https://localhost:44391/api/broadband/insertLead";
  updateUri ="https://localhost:44391/api/broadband/updateLead";
  deleteUri ="https://localhost:44391/api/broadband/deleteLead";
 // apiUrl1 ="https://reqres.in/api/users?page=2";


  constructor(private _http:HttpClient) {   }



  getLeads(){
    return this._http.get(this.leadUri);
    // this.apiUrl;

  }

  insertLeads(){
    return this._http.get(this.insertUri);
    // this.apiUrl;

  }

 


}