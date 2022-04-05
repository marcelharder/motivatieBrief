import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AboutComponent } from './about/about.component';
import { AuthGuard } from './_guards/auth.guard';
import { LoginComponent } from './login/login.component';
import { Brief_detailsComponent } from './brief_details/brief_details.component';
import { MakelaarComponent } from './makelaar/makelaar.component';

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
        { path: 'brief_details/:id', component: Brief_detailsComponent },  
        { path: 'makelaar', component: MakelaarComponent }



      /*  { path: 'profile', component: ProfileComponent, resolve: { user: ProfileResolver }, canDeactivate: [PreventUnsavedChanges] },
          { path: 'surgeon', component: SurgeonComponent },
          { path: 'admin', component: AdminComponent },
          { path: 'companyadmin', component: CompanyadminComponent },
         
          { path: 'superuser', component: SuperuserComponent },
          { path: 'tutorials', component: TutorialsComponent },
          { path: 'companysettings/:id', component: SettingsCompanyComponent },
          { path: 'brief_details/:id', component: ExpiryComponent },
          { path: 'addProduct/:id', component: AddProductComponent, resolve: {valve: ValveResolver} },
 */

      ]
  },
  { path: '**', redirectTo: '', pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
