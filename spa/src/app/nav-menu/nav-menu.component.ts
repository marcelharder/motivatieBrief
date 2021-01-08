import { Component, OnInit } from '@angular/core';
import { AuthService } from '../_services/auth.service';
import { AlertifyService } from '../_services/alertify.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {
    isExpanded = false;
    model: any = {};

    adminLogged: boolean;
    normalLogged: boolean;
    specialLogged: boolean;
    companyAdminLogged: boolean;

    loginFailed = false;

    constructor(public auth: AuthService,   private alertify: AlertifyService,  private router: Router) { }

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
    }
    ngOnInit() {
        this.adminLogged = false;
        this.normalLogged = false;
        this.specialLogged = false;
        this.companyAdminLogged = false;
    }

    login() {
        this.auth.login(this.model).subscribe(next => {
            this.alertify.success('Logged in successfully');
            this.loginFailed = false;
            switch (this.auth.decodedToken.role) {
                case 'admin':
                    this.adminLogged = true;
                    break;
                case 'surgeon':
                    this.normalLogged = true;
                    break;
                case 'superuser':
                    this.specialLogged = true;
                    break;
                case 'companyadmin':
                    this.companyAdminLogged = true;
                    break;
            }
            // go to the list of procedures
        },
            error => {
                // say log in failed, show register button
                this.alertify.error(error);
                this.loginFailed = true;
            }
        );
    }
    loggedIn() { return this.auth.loggedIn(); }

    logOut() {
        this.adminLogged = false;
        this.normalLogged = false;
        this.specialLogged = false;
        this.companyAdminLogged = false;
        this.router.navigate(['/home']);
        this.alertify.message('Logged out');
        localStorage.removeItem('token');
    }

    showRegister() {
        this.loginFailed = false;
        this.router.navigate(['/register']);
    }

  loginFail() {
        if (this.loginFailed === true) { return true; } else { return false; }
    }

}
