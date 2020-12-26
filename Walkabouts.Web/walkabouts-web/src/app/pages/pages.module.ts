import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PagesRoutingModule } from './pages-routing.module';
import { HomeComponent } from './home/home.component';
import { WidgetsModule } from '../widgets/widgets.module';
import { RouterModule } from '@angular/router';


@NgModule({
  declarations: [HomeComponent],
  imports: [
    WidgetsModule,
    CommonModule,
    RouterModule,
    PagesRoutingModule
  ]
})
export class PagesModule { }
