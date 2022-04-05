import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import {FormsModule} from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { AboutComponent } from './about/about.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { RegisterComponent } from './register/register.component';
import { AlertifyService } from './_services/alertify.service';
import { AuthService } from './_services/auth.service';

import { JwtModule } from '@auth0/angular-jwt';
import { AuthGuard } from './_guards/auth.guard';
import { HttpClientModule } from '@angular/common/http';
import { LoginComponent } from './login/login.component';
import { Brief_detailsComponent } from './brief_details/brief_details.component';
import { MakelaarComponent } from './makelaar/makelaar.component';
import { BriefResolver } from './_resolvers/brief.resolver';
import { PhotoeditorComponent } from './photoeditor/photoeditor.component';

import {FileUploadModule} from 'ng2-file-upload';



export function tokenGetter() { return localStorage.getItem('token'); }

@NgModule({
   declarations: [			
      AppComponent,
      HomeComponent,
      AboutComponent,
      NavMenuComponent,
      RegisterComponent,
      LoginComponent,
      Brief_detailsComponent,
      MakelaarComponent,
      PhotoeditorComponent
   ],
   imports: [
      HttpClientModule,
      FileUploadModule,
      FormsModule,
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
   providers: [AlertifyService, AuthService, AuthGuard, BriefResolver],
   bootstrap: [
      AppComponent
   ]
})
export class AppModule { }
