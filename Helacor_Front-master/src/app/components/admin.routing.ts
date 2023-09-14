import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { AdminComponent } from './admin/admin.component';
import { ListRepartosComponent } from './list-repartos/list-repartos.component';


const routes: Routes = [
  {
    path: '',
    component: AdminComponent,
    children: [
      { path: '', redirectTo: 'reparto', pathMatch: 'full' },
      { path: 'home', component: AdminComponent, pathMatch: 'full', },
      { path: 'reparto', component: ListRepartosComponent },
     
    ]
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class AdminRoutingModule { }
