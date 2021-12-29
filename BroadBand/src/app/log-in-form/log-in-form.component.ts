import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { NavigationExtras, Router, RouterLink } from '@angular/router';
import { ToastrService } from 'ngx-toastr';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-log-in-form',
  templateUrl: './log-in-form.component.html',
  styleUrls: ['./log-in-form.component.css']
})
export class LogInFormComponent implements OnInit {


  loginForm:FormGroup;
  
  constructor(public router:Router,private toastr: ToastrService) { 
    this.loginForm=new FormGroup({
      userName:new FormControl('',[Validators.required, Validators.minLength(4)]),
      passWord:new FormControl('',[Validators.required, Validators.minLength(8)])

    })
  }
  navbarOpen = false;

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
  ngOnInit(): void {
  }


name:string="";
  onSubmit(){
    let navigationExtras: NavigationExtras = {
      queryParams: {
     name:this.loginForm.value.userName
      }
    }
    if ( (this.loginForm.value.userName=="admin" ||this.loginForm.value.userName=="rushikesh" || this.loginForm.value.userName=="ashvini" ||this.loginForm.value.userName=="jayant" )
     && this.loginForm.value.passWord==("pass@123")){
    this.name=this.loginForm.value.userName

    Swal.fire('Welcome  ' +this.name+' !!!' , 'Login successfull', 'success')
    this.router.navigate(['/admin'],navigationExtras)
    }
    else{
   this.toastr.info("check Username and Password !!");
    }

  }
}
