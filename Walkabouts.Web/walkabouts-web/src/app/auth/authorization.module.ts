import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorizationRoutingModule } from './authorization-routing.module';
import { SignupComponent } from './signup/signup.component';
import { RouterModule } from '@angular/router';
import { AuthorizationHomeComponent } from './authorization-home/authorization-home.component';
import { WidgetsModule } from '../widgets/widgets.module';
// mport { HttpClient, HttpClientModule } from '@angular/common/http';
/* import { FormsModule, ReactiveFormsModule } from '@angular/forms'; */


@NgModule({
  declarations: [
    SignupComponent,
    AuthorizationHomeComponent
  ],
  imports: [
    CommonModule,
    AuthorizationRoutingModule,
    RouterModule,
    WidgetsModule, 
   // HttpClientModule,   
  ],
  
})
export class AuthorizationModule { }
