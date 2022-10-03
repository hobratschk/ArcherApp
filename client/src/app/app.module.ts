import { SharedModule } from './_modules/shared.module';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NavComponent } from './nav/nav.component';
import { FormsModule } from '@angular/forms';
import { ArchersListComponent } from './archers/archers-list/archers-list.component';
import { ArcherDetailsComponent } from './archers/archer-details/archer-details.component';
import { DistanceEventComponent } from './distance-event/distance-event.component';
import { SpeedEventComponent } from './speed-event/speed-event.component';
import { TestErrorsComponent } from './errors/test-errors/test-errors.component';
import { ErrorInterceptor } from './_interceptors/error.interceptor';
import { NotFoundComponent } from './errors/not-found/not-found.component';
import { ServerErrorComponent } from './errors/server-error/server-error.component';
import { AddArcherComponent } from './archers/add-archer/add-archer.component';

@NgModule({
  declarations: [
    AppComponent,
    NavComponent,
    DistanceEventComponent,
    SpeedEventComponent,
    ArcherDetailsComponent,
    ArchersListComponent,
    SpeedEventComponent,
    TestErrorsComponent,
    NotFoundComponent,
    ServerErrorComponent,
    AddArcherComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    SharedModule
  ],
  providers: [
    {provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true}
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
