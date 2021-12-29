import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { observable, Observable } from 'rxjs';
import { ServiceAPIService } from '../service-api.service';

@Component({
  selector: 'app-insert-new-lead',
  templateUrl: './insert-new-lead.component.html',
  styleUrls: ['./insert-new-lead.component.css']
})
export class InsertNewLeadComponent implements OnInit {

  insertForm:FormGroup;
  linfo={};
  pid:any;

  constructor(public http:HttpClient,private ServObj:ServiceAPIService) { 
    this.insertForm=new FormGroup({
      name:new FormControl('',[Validators.required, Validators.minLength(4)]),
      gender:new FormControl('',[Validators.required]),
      address:new FormControl('',[Validators.required]),
      email:new FormControl('',[Validators.required, Validators.pattern("[a-zA-Z0-9]+@[a-z]+[.][a-z]+")]),
      phone:new FormControl('',[Validators.required]),
      createdby:new FormControl('',[Validators.required]),
      date:new FormControl('',[Validators.required]),
  

    })
  }
  navbarOpen = false;

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
  ngOnInit(): void {
    
  }






  onSubmit(){

    var leads:any=[{
      leadName:this.insertForm.value.name,
      leadGender:this.insertForm.value.gender,
      leadAddress:this.insertForm.value.address,
      leadEmail:this.insertForm.value.email,
      leadPhone:this.insertForm.value.phone,
      leadCreatedBy:this.insertForm.value.createdby,
     leadCreatedOn:this.insertForm.value.date,
    }]


console.log("from lead --"+leads[0]);

var jsonString = JSON.stringify(leads[0]);

console.log(jsonString);

this.createlead(jsonString);

}

createlead(obj: any): Observable<any> {  
  const httpOptions = { 'content-type': 'application/json'}  
console.log(obj+"////////////////////////////////////////////////////")

   this.http.post("https://localhost:44391/api/broadband/insertLead",  
  obj,{'headers':httpOptions , observe: 'response'}).subscribe(
    response=> {
         console.log("POST completed sucessfully. The response received "+response);
     }
 
     
     )

return obj;
  
}




}
