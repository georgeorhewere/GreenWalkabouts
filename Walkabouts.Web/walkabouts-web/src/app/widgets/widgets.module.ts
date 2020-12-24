import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WalkaboutsHeaderComponent } from './walkabouts-header/walkabouts-header.component';
import { WalkaboutsFooterComponent } from './walkabouts-footer/walkabouts-footer.component';
import { WalkaboutsMenuComponent } from './walkabouts-menu/walkabouts-menu.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    WalkaboutsHeaderComponent,
    WalkaboutsMenuComponent,
    WalkaboutsFooterComponent,    
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  exports:[
    WalkaboutsHeaderComponent,
    WalkaboutsMenuComponent,
    WalkaboutsFooterComponent, 
  ]
})
export class WidgetsModule { }
