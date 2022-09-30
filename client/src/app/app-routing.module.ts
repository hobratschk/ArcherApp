import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArcherDetailsComponent } from './archers/archer-details/archer-details.component';
import { ArchersListComponent } from './archers/archers-list/archers-list.component';
import { DistanceEventComponent } from './distance-event/distance-event.component';
import { SpeedEventComponent } from './speed-event/speed-event.component';

const routes: Routes = [
  {path: '', component: ArchersListComponent},
  {path: 'archers/:id', component: ArcherDetailsComponent},
  {path: 'distance', component: DistanceEventComponent},
  {path: 'speed', component: SpeedEventComponent},
  {path: '**', component: ArchersListComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
