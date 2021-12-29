import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPanelComponent } from './admin-panel/admin-panel.component';
import { HomeComponent } from './home/home.component';
import { InsertNewLeadComponent } from './insert-new-lead/insert-new-lead.component';
import { LeadsComponent } from './leads/leads.component';
import { LogInFormComponent } from './log-in-form/log-in-form.component';
import { UpdateLeadComponent } from './update-lead/update-lead.component';

const routes: Routes = [
{path:'login',component: LogInFormComponent},
{path:'leads',component: LeadsComponent},
{path:'addLead',component: InsertNewLeadComponent},
{path:'updateLead',component: UpdateLeadComponent},
{ path: '',   redirectTo: '/home', pathMatch: 'full' }, 
{path: 'update', component: UpdateLeadComponent, data: {some_data: 'some value'}},
{path:'home',component:HomeComponent},
{path:'admin',component:AdminPanelComponent},




];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
export const routingcomp =[LogInFormComponent, LeadsComponent, InsertNewLeadComponent,UpdateLeadComponent]
