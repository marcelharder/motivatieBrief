import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Brief } from '../_models/brief';
import { personalia } from '../_models/personalia';
import { AlertifyService } from '../_services/alertify.service';
import { BriefService } from '../_services/brief.service';
import { PersonaliaService } from '../_services/personalia.service';
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
  mot: Brief;
  opgaaf: personalia;

  constructor(
    private alertify: AlertifyService,
    private briefservice: BriefService,
    private persservice: PersonaliaService,
    private us: UserService,
    private router: Router) { }

  ngOnInit() {
  }

  buyerFound(){if(this.koper === 1){return true;}}

 

  Cancel(){this.router.navigate(['/']);}

  FindEntry(){
    this.us.getUserByEmail(this.email).subscribe((next)=>{
      if(next){
       // this buyer was found, show buyerdetails page
       this.koper = 1;
       this.currentKoper = next.id;
       
       // get the motivateBrief
       this.briefservice.getBrief(this.currentKoper).subscribe((next)=>{
        this.mot = next;},(error)=>{this.alertify.error(error)})

       // get the personalia
       this.persservice.getPersonalia(this.currentKoper).subscribe((resp)=>{
        this.opgaaf = resp}, error => this.alertify.error(error))
       
       
      }
      else {this.alertify.message(this.email + " niet gevonden");}
    }, error => this.alertify.error(error))
  
  
  
  
  }

}
