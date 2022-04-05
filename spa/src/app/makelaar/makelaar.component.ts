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

  constructor(private alertify: AlertifyService,
    private us: UserService,
    private router: Router) { }

  ngOnInit() {
  }

  Cancel(){this.alertify.message("Cancel")}
  FindEntry(){
    this.us.getUserByEmail(this.email).subscribe((next)=>{
      if(next){
        // go to the brief-details page met the correct userid
        this.router.navigate(['/brief_details/' + next.id]);
      }
      else {this.alertify.message(this.email + " niet gevonden");}
    }, error => this.alertify.error(error))
  
  
  
  
  }

}
