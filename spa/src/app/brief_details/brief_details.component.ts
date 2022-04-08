import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router} from '@angular/router';
import { environment } from 'src/environments/environment';
import { Brief } from '../_models/brief';
import { AlertifyService } from '../_services/alertify.service';
import { AuthService } from '../_services/auth.service';
import { BriefService } from '../_services/brief.service';
import { PdfService } from '../_services/pdf.service';

@Component({
  selector: 'app-brief_details',
  templateUrl: './brief_details.component.html',
  styleUrls: ['./brief_details.component.css']
})
export class Brief_detailsComponent implements OnInit {
  @Input() br: Brief;
  showPhoto = 0;
  baseUrl= environment.apiUrl;
  mkrole = 0;
 

  constructor(private alertify: AlertifyService, 
    private auth: AuthService,
    private pdf: PdfService, 
    private route: ActivatedRoute,
    private router: Router, 
    private brief: BriefService) { }

  ngOnInit() {
  
    // check if the makelaar is loggedIn()
    this.auth.currentRole.subscribe((next)=>{
      if(next === 'makelaar'){this.mkrole = 1;}
    })
    
  }
  showIfRoleIsMakelaar(){if(this.mkrole === 1){return true;}}
  showPhotoEditor(){if(this.showPhoto === 1){return true;}}
  updatePhoto(photoUrl: string){this.br.photoUrl = photoUrl; this.showPhoto = 0;}

  uploadPicture() {
    this.showPhoto = 1;
    this.alertify.message("uploading picture comes here ....");}

  cancel(){this.router.navigate(['/makelaar'])}

  removeKoper(){this.alertify.message("remove koper now");}

  savePrint(){
   
    this.brief.saveBrief(this.br).subscribe((next)=>{ }, 
    (error) => this.alertify.error(error), 
    ()=>{
      if(this.br.line_1 !== null){
        window.location.href = this.baseUrl + 'getPDF/' + this.br.id;
        this.router.navigate(['/']);
      }
      else {
        this.alertify.error("Please fill at least something ...");
      }
    
    })
  }

  





}


