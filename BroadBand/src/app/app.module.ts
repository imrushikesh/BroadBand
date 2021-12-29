import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule, routingcomp } from './app-routing.module';
import { AppComponent } from './app.component';
import { LogInFormComponent } from './log-in-form/log-in-form.component';
import { InsertNewLeadComponent } from './insert-new-lead/insert-new-lead.component';

import { UpdateLeadComponent } from './update-lead/update-lead.component';
import { LeadsComponent } from './leads/leads.component';
import { HttpClientModule } from '@angular/common/http';
import { ServiceAPIService } from './service-api.service';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ToastrModule } from 'ngx-toastr';
import { Ng2SearchPipeModule } from 'ng2-search-filter';
import { HomeComponent } from './home/home.component';
import { SweetComponent } from './sweet/sweet.component';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';



@NgModule({
  declarations: [
    AppComponent,
    LogInFormComponent,
    InsertNewLeadComponent,
routingcomp,
    UpdateLeadComponent,
     LeadsComponent,
     HomeComponent,
     SweetComponent,
     AdminPanelComponent,

  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AppRoutingModule,
   
    Ng2SearchPipeModule,
    BrowserAnimationsModule,
	ToastrModule.forRoot(),
  
  ],
  providers: [ServiceAPIService],
  bootstrap: [AppComponent]
})
export class AppModule { }
