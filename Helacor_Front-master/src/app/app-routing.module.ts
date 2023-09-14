import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
//Components
import { ListRepartosComponent } from './components/list-repartos/list-repartos.component';
import { ViewRepartoComponent } from './components/view-reparto/view-reparto.component';

const routes: Routes = [
  { path: '', redirectTo: 'reparto', pathMatch: 'full' },
  { path : 'reparto', component: ListRepartosComponent },
  { path: 'view', component: ViewRepartoComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
