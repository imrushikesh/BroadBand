import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css']
})
export class AdminPanelComponent implements OnInit {
name:string="";
  constructor(public router:Router) { 
    const navigation = this.router.getCurrentNavigation(); 
    this.name = navigation?.extras.queryParams?.['name'];
  }

  ngOnInit(): void {
  }
  navbarOpen = false;

  toggleNavbar() {
    this.navbarOpen = !this.navbarOpen;
  }
}
