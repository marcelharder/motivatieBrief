import { Component, OnInit } from '@angular/core';
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
  showPhoto = 0;
  baseUrl= environment.apiUrl;
  mkrole = 0;
  br:Brief = {
    id:0,
    photoUrl: "",
    line_1: '', line_2: '', line_3: '', line_4: '', line_5: '', line_6: '', line_7: '', line_8: '', line_9: '', line_10: '',
    line_11: '', line_12: '', line_13: '', line_14: '', line_15: '', line_16: '', line_17: '', line_18: '', line_19: '', line_20: '',
    line_21: '', line_22: '', line_23: '', line_24: '', line_25: '', line_26: '', line_27: '', line_28: '', line_29: '', line_30: '',
    line_31: '', line_32: '', line_33: '', line_34: '', line_35: '', line_36: '', line_37: '', line_38: '', line_39: '', line_40: '',
    line_41: '', line_42: '', line_43: '', line_44: '', line_45: '', line_46: '', line_47: '', line_48: '', line_49: '', line_50: '',

  };

  constructor(private alertify: AlertifyService, 
    private auth: AuthService,
    private pdf: PdfService, 
    private route: ActivatedRoute,
    private router: Router, 
    private brief: BriefService) { }

  ngOnInit() {
    // get the suff from the resolver
    this.route.data.subscribe((data: {br: Brief})=>{
      this.br = data.br;
    })
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


