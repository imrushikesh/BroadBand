import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ServiceAPIService } from '../service-api.service';
import { ToastrService } from 'ngx-toastr';
import { NavigationExtras, Router } from '@angular/router';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-leads',
  templateUrl: './leads.component.html',
  styleUrls: ['./leads.component.css']
})
export class LeadsComponent implements OnInit {

  constructor(private ServObj:ServiceAPIService, private ht:HttpClient,private toastr: ToastrService, private router:Router) { }
  leads:any;
  searchTerm:any;
  
    ngOnInit(): void {
    this.ServObj.getLeads().subscribe(Response => {
      console.log(Response)
      this.leads=Response;
    console.log(this.leads)
    }
    );

}
navbarOpen = false;

toggleNavbar() {
  this.navbarOpen = !this.navbarOpen;
}







// Edit Method
edit(id:number, name:string, gender:string,address:string,email:string,phone:string,created:string,date:string){
  console.log("----  "+id);

    let navigationExtras: NavigationExtras = {
      queryParams: {
        leadId:id,
        leadName:name,
        leadGender:gender,
        leadAddress:address,
        leadEmail:email,
        leadPhone:phone,
        leadCreatedBy:created,
       leadCreatedOn:date,
      }
    };


    Swal.fire({
      title: 'Are you sure want to edit record?',
      text: 'Record will be Updated !',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, go ahead.',
  
      cancelButtonText: 'No, let me think again'
    }).then((result) => {
      if (result.value) {
        Swal.fire(
          
          'Update Records ... ',
          '' +this.router.navigate(['/update'],navigationExtras),
          'info'
         
        )
      }
    })



    

    console.log("Edit-->");

}



// Delete methods 

delete(id:number){
  
  Swal.fire({
    title: 'Are you sure?',
    text: 'Record will be deleted Permanently !',
    icon: 'warning',
    showCancelButton: true,
    confirmButtonText: 'Yes, go ahead.',
    cancelButtonText: 'No, let me think again'
  }).then((result) => {
    if (result.value) {
      Swal.fire(
        'Done '
        +this.deleteLead(id),
        'success'
      )
    }
  })






    console.log("delete-->"+id);
  // this.toastr.info("Record Deleted")
 
}



deleteLead(leadId: any): Observable<any> 
{  

   this.ht.delete("https://localhost:44391/api/broadband/deleteLead?leadId="+leadId,  
   ).subscribe(
    response=> {
         console.log("Delete completed sucessfully. The response received "+response);
     })

    window.location.reload();
   
    return leadId;
  
  }


}


  
