import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NotFoundComponent } from './not-found/not-found.component';
import { WalkaboutsHeaderComponent } from './widgets/walkabouts-header/walkabouts-header.component';
import { WalkaboutsMenuComponent } from './widgets/walkabouts-menu/walkabouts-menu.component';
import { WalkaboutsFooterComponent } from './widgets/walkabouts-footer/walkabouts-footer.component';

@NgModule({
  declarations: [
    AppComponent,
    NotFoundComponent,
    WalkaboutsHeaderComponent,
    WalkaboutsMenuComponent,
    WalkaboutsFooterComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
