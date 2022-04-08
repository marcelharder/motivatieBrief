import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AboutComponent } from './about/about.component';
import { AuthGuard } from './_guards/auth.guard';
import { LoginComponent } from './login/login.component';
import { Brief_detailsComponent } from './brief_details/brief_details.component';
import { MakelaarComponent } from './makelaar/makelaar.component';
import { BriefResolver } from './_resolvers/brief.resolver';
import { PersonaliaComponent } from './personalia/personalia.component';
import { PersonaliaResolver } from './_resolvers/personalia.resolver';
import { KoperComponent } from './koper/koper.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: 'about', component: AboutComponent },
  {
      path: '',
      runGuardsAndResolvers: 'always',
      canActivate: [AuthGuard],
      children: [
        { path: 'brief_details/:id', component: Brief_detailsComponent, resolve:{br: BriefResolver} },  
        { path: 'makelaar', component: MakelaarComponent },
        { path: 'koper/:id', component: KoperComponent },
        { path: 'personalia_details:/id', component: PersonaliaComponent, resolve:{per: PersonaliaResolver} }
      ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
