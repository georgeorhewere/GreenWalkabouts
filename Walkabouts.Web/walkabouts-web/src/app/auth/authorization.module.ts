import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthorizationRoutingModule } from './authorization-routing.module';
import { SignupComponent } from './signup/signup.component';
import { RouterModule } from '@angular/router';
import { AuthorizationHomeComponent } from './authorization-home/authorization-home.component';


@NgModule({
  declarations: [
    SignupComponent,
    AuthorizationHomeComponent
  ],
  imports: [
    CommonModule,
    AuthorizationRoutingModule,
    RouterModule
  ]
})
export class AuthorizationModule { }
