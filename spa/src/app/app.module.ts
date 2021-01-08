import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { SettingsComponent } from './settings/settings.component';
import { StatisticsComponent } from './statistics/statistics.component';
import { RegisterComponent } from './register/register.component';
import { AlertifyService } from './_services/alertify.service';
import { AuthService } from './_services/auth.service';

import { JwtModule } from '@auth0/angular-jwt';
import { AuthGuard } from './_guards/auth.guard';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';



export function tokenGetter() { return localStorage.getItem('token'); }

@NgModule({
   declarations: [
      AppComponent,
      HomeComponent,
      AboutComponent,
      NavMenuComponent,
      SettingsComponent,
      StatisticsComponent,
      RegisterComponent,
      LoginComponent
   ],
   imports: [
      HttpClientModule,
      BrowserModule,
      FormsModule,
      AppRoutingModule,
      BrowserAnimationsModule,
      JwtModule.forRoot({
         config: {
             tokenGetter: tokenGetter,
             whitelistedDomains: ['localhost:5000'],
             blacklistedRoutes: ['localhost:5000/api/auth']
         }
     }),
   ],
   providers: [AlertifyService, AuthService, AuthGuard],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
