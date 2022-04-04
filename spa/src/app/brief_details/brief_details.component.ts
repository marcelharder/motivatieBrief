import { Component, OnInit } from '@angular/core';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-brief_details',
  templateUrl: './brief_details.component.html',
  styleUrls: ['./brief_details.component.css']
})
export class Brief_detailsComponent implements OnInit {

  constructor(private alertify: AlertifyService) { }

  ngOnInit() {
    // get the suff from the resolver
  }

  uploadPicture() {this.alertify.message("uploading picture comes here ....");}
  cancel(){this.alertify.message("cancel");}
  savePrint(){this.alertify.message("save en print");}
}


