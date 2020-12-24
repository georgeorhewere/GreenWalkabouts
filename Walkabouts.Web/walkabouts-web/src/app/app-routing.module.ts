import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { NotFoundComponent } from './not-found/not-found.component';


const routes: Routes = [ 
    {
     path: '',
     loadChildren: () => import('./pages/pages.module').then(m => m.PagesModule),
   },
   {
    path: 'auth',
    loadChildren: () => import('./auth/authorization.module').then(m => m.AuthorizationModule),
  },

   {
    path: '**',
    component: NotFoundComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
