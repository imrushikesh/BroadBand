import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ServiceAPIService } from '../service-api.service';

@Component({
  selector: 'app-update-lead',
  templateUrl: './update-lead.component.html',
  styleUrls: ['./update-lead.component.css']
})
export class UpdateLeadComponent implements OnInit {

  insertForm:FormGroup;
  constructor(public http:HttpClient,private ServObj:ServiceAPIService,private router: Router) {
    const navigation = this.router.getCurrentNavigation(); 
     const eleadId = navigation?.extras.queryParams?.['leadId'];
     const eleadName = navigation?.extras.queryParams?.['leadName'];
     const eleadGender = navigation?.extras.queryParams?.['leadGender'];
     const eleadAddress = navigation?.extras.queryParams?.['leadAddress'];
     const eleadEmail = navigation?.extras.queryParams?.['leadEmail'];
     const eleadPhone = navigation?.extras.queryParams?.['leadPhone'];
     const eleadCreatedBy = navigation?.extras.queryParams?.['leadCreatedBy'];
     const eleadCreatedOn = navigation?.extras.queryParams?.['leadCreatedOn'];

    this.insertForm=new FormGroup({
      id:new FormControl(eleadId,[Validators.required]),
      name:new FormControl(eleadName,[Validators.required, Validators.minLength(4)]),
      gender:new FormControl(eleadGender,[Validators.required]),
      address:new FormControl(eleadAddress,[Validators.required]),
      email:new FormControl(eleadEmail,[Validators.required, Validators.pattern("[a-zA-Z0-9]+@[a-z]+[.][a-z]+")]),
      phone:new FormControl(eleadPhone,[Validators.required]),
      createdby:new FormControl(eleadCreatedBy,[Validators.required]),
      date:new FormControl(eleadCreatedOn,[Validators.required]),
  

    })
  }
  ngOnInit(): void {
    
  }
  navbarOpen = false;

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
  onSubmit(){

    var leads:any=[{
      leadId:this.insertForm.value.id,
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

   this.http.put("https://localhost:44391/api/broadband/updateLead",  
  obj,{'headers':httpOptions , observe: 'response'}).subscribe(
    response=> {
         console.log("POST completed sucessfully. The response received "+response);
     })

return obj;
  
}




}