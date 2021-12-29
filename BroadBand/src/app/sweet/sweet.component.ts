import { Component, OnInit } from '@angular/core';
import Swal from 'sweetalert2';

@Component({
  selector: 'app-sweet',
  templateUrl: './sweet.component.html',
  styleUrls: ['./sweet.component.css']
})
export class SweetComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  
  simpleAlert(){
    Swal.fire('Hi Welcome! This is Simple Alert');
  }
  successAlertNotification(){
    Swal.fire('Hi', 'Congrats! operation successfull', 'success')
  }
  
  alertConfirmation(){
    Swal.fire({
      title: 'Are you sure?',
      text: 'Your Action cannot be rollback.',
      icon: 'warning',
      showCancelButton: true,
      confirmButtonText: 'Yes, go ahead.',
      cancelButtonText: 'No, let me think again'
    }).then((result) => {
      if (result.value) {
        Swal.fire(
          'Done!',
          'Action performed successfully.',
          'success'
        )
      } else if (result.dismiss === Swal.DismissReason.cancel) {
        Swal.fire(
          'Cancelled',
          'Performed action record present in cloud and databstore.)',
          'error'
        )
      }
    })
  }  

}
