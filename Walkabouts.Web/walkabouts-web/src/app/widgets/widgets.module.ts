import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WalkaboutsHeaderComponent } from './walkabouts-header/walkabouts-header.component';
import { WalkaboutsFooterComponent } from './walkabouts-footer/walkabouts-footer.component';
import { WalkaboutsMenuComponent } from './walkabouts-menu/walkabouts-menu.component';
import { RouterModule } from '@angular/router';
import { RegisterFormComponent } from './register-form/register-form.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';



@NgModule({
  declarations: [
    WalkaboutsHeaderComponent,
    WalkaboutsMenuComponent,
    WalkaboutsFooterComponent,
    RegisterFormComponent,    
  ],
  imports: [
    CommonModule,
    RouterModule,
    FormsModule,
    ReactiveFormsModule
  ],
  exports:[
    WalkaboutsHeaderComponent,
    WalkaboutsMenuComponent,
    WalkaboutsFooterComponent, 
    RegisterFormComponent, 
  ]
})
export class WidgetsModule { }
