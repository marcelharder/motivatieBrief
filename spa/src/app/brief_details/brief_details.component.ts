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
  }

  uploadPicture() {
    this.alertify.message("uploading picture comes here ....");
  }
}


