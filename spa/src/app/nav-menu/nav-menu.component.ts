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
    admin = false;
  
   

    constructor(public auth: AuthService, private alertify: AlertifyService, private router: Router) { }

    collapse() {
        this.isExpanded = false;
    }

    toggle() {
        this.isExpanded = !this.isExpanded;
    }
    ngOnInit() {
        this.auth.UserRole.subscribe((next)=>{ if(next === 'admin'){this.admin = true} else {this.admin = false;}; });
    }

    
    loggedIn() { return this.auth.loggedIn(); }

    adminLogged(){ if(this.admin)return true;{} }

    logIn(){this.router.navigate(['/login']);}

    logOut() {
        this.router.navigate(['/']);
        this.alertify.message('Logged out');
        localStorage.removeItem('token');
    }

   

   

}
