import { Component, OnInit } from '@angular/core';
import { Brief } from '../_models/brief';
import { AlertifyService } from '../_services/alertify.service';
import { PdfService } from '../_services/pdf.service';

@Component({
  selector: 'app-brief_details',
  templateUrl: './brief_details.component.html',
  styleUrls: ['./brief_details.component.css']
})
export class Brief_detailsComponent implements OnInit {

  br:Brief = {
    UserId:0,
    Id:0,
    photoUrl: "",
    line_1: '', line_2: '', line_3: '', line_4: '', line_5: '', line_6: '', line_7: '', line_8: '', line_9: '', line_10: '',
    line_11: '', line_12: '', line_13: '', line_14: '', line_15: '', line_16: '', line_17: '', line_18: '', line_19: '', line_20: '',
    line_21: '', line_22: '', line_23: '', line_24: '', line_25: '', line_26: '', line_27: '', line_28: '', line_29: '', line_30: '',
    line_31: '', line_32: '', line_33: '', line_34: '', line_35: '', line_36: '', line_37: '', line_38: '', line_39: '', line_40: '',
    line_41: '', line_42: '', line_43: '', line_44: '', line_45: '', line_46: '', line_47: '', line_48: '', line_49: '', line_50: '',

  };

  constructor(private alertify: AlertifyService, private pdf: PdfService) { }

  ngOnInit() {
    // get the suff from the resolver
    this.br.line_1 = "hallo lijn 1";
    this.br.line_2 = "hallo lijn 2";
    this.br.line_3 = "hallo lijn 3";
    this.br.line_4 = "hallo lijn 4";
    this.br.line_5 = "hallo lijn 5";
    this.br.line_6 = "hallo lijn 6";
    this.br.photoUrl = "https://res.cloudinary.com/marcelcloud/image/upload/v1649145510/P1000100.jpg";
  }

  uploadPicture() {this.alertify.message("uploading picture comes here ....");}
  cancel(){this.alertify.message("cancel");}
  savePrint(){
    this.alertify.message("save en print");
    this.pdf.constructPdf(this.br.UserId).subscribe((next)=>{})
  
  }
}


