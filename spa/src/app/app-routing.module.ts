import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegisterComponent } from './register/register.component';
import { AboutComponent } from './about/about.component';
import { AuthGuard } from './_guards/auth.guard';
import { LoginComponent } from './login/login.component';

const routes: Routes = [
  { path: 'home', component: HomeComponent },
  { path: 'register', component: RegisterComponent },
  { path: 'login', component: LoginComponent },
  { path: 'about', component: AboutComponent },
  {
      path: '',
      runGuardsAndResolvers: 'always',
      canActivate: [AuthGuard],
      children: [
         
      /*  { path: 'profile', component: ProfileComponent, resolve: { user: ProfileResolver }, canDeactivate: [PreventUnsavedChanges] },
          { path: 'surgeon', component: SurgeonComponent },
          { path: 'admin', component: AdminComponent },
          { path: 'companyadmin', component: CompanyadminComponent },
         
          { path: 'superuser', component: SuperuserComponent },
          { path: 'settings', component: SettingsComponent },
          { path: 'tutorials', component: TutorialsComponent },
          { path: 'statistics', component: StatisticsComponent },
          { path: 'companysettings/:id', component: SettingsCompanyComponent },
          { path: 'expiry/:id', component: ExpiryComponent },
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
