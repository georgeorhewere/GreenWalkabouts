import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AuthorizationHomeComponent } from './authorization-home/authorization-home.component';
import { SignupComponent } from './signup/signup.component';


const routes: Routes = [
  /* { path: '', redirectTo: '/home', pathMatch: 'full' },  */
  { path: '', 
    component: AuthorizationHomeComponent,
    children:[
      { path: 'signup', component: SignupComponent }

    ]
  
  },

  ,
  /* { path: 'verify-user', component: SignupComponent }, */
  /* { path: 'login', component: SignupComponent }, */  
  /* { path: 'forgot-password', component: SignupComponent }, */
  

];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AuthorizationRoutingModule { }
