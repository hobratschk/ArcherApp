import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArcherDetailsComponent } from './archers/archer-details/archer-details.component';
import { ArchersListComponent } from './archers/archers-list/archers-list.component';
import { DistanceEventComponent } from './distance-event/distance-event.component';
import { SpeedEventComponent } from './speed-event/speed-event.component';
import { AddArcherComponent } from './archers/add-archer/add-archer.component';

const routes: Routes = [
  {path: '', component: ArchersListComponent},
  {path: 'archers/:id', component: ArcherDetailsComponent},
  {path: 'addArcher', component: AddArcherComponent},
  {path: 'distance', component: DistanceEventComponent},
  {path: 'speed', component: SpeedEventComponent},
  {path: 'errors', component: TestErrorsComponent},
  {path: 'not-found', component: NotFoundComponent},
  {path: 'server-error', component: ServerErrorComponent},
  {path: '**', component: ArchersListComponent, pathMatch: 'full'}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
