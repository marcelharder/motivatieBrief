import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AlertifyService } from '../_services/alertify.service';
import { UserService } from '../_services/user.service';

@Component({
  selector: 'app-makelaar',
  templateUrl: './makelaar.component.html',
  styleUrls: ['./makelaar.component.css']
})
export class MakelaarComponent implements OnInit {
  email = "";
  koper = 0;
  currentKoper = 0;

  constructor(private alertify: AlertifyService,
    private us: UserService,
    private router: Router) { }

  ngOnInit() {
  }

  buyerFound(){if(this.koper === 1){return true;}}

  showBrief(){     this.router.navigate(['/brief_details/'      + this.currentKoper]);}
  showPersonalia(){this.router.navigate(['/personalia_details/' + this.currentKoper]);}

  Cancel(){this.router.navigate(['/']);}

  FindEntry(){
    this.us.getUserByEmail(this.email).subscribe((next)=>{
      if(next){
       // this buyer was found, show buyerdetails page
       this.koper = 1;
       this.currentKoper = next.id;
      }
      else {this.alertify.message(this.email + " niet gevonden");}
    }, error => this.alertify.error(error))
  
  
  
  
  }

}
