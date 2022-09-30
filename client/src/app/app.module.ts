import { SharedModule } from './_modules/shared.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
import { ArchersListComponent } from './archers/archers-list/archers-list.component';
import { ArcherDetailsComponent } from './archers/archer-details/archer-details.component';
import { DistanceEventComponent } from './distance-event/distance-event.component';
import { SpeedEventComponent } from './speed-event/speed-event.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    DistanceEventComponent,
    SpeedEventComponent,
    ArcherDetailsComponent,
    ArchersListComponent,
    SpeedEventComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
