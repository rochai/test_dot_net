import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LandingComponent } from './landing/landing.component'

const appRoutes: Routes = [
  {
    path: 'landing',
    component: LandingComponent,
    data: { title: 'Landing Page' }
  },
  {
    path: '',
    redirectTo: '/landing',
    pathMatch: 'full'
  }
  ]


@NgModule({
  imports: [RouterModule.forRoot(appRoutes)],
  exports: [RouterModule]
})
export class AppRoutingModule {

}
