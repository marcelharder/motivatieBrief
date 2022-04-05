import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FileUploader } from 'ng2-file-upload';
import { environment } from 'src/environments/environment';
import { AlertifyService } from '../_services/alertify.service';

@Component({
  selector: 'app-photoeditor',
  templateUrl: './photoeditor.component.html',
  styleUrls: ['./photoeditor.component.css']
})
export class PhotoeditorComponent implements OnInit {
  @Input() userId: number;
  @Output() getMemberPhotoChange = new EventEmitter<string>();
  uploader: FileUploader;
  hasBaseDropZoneOver = false;
  baseUrl = environment.apiUrl;

  constructor(private alertify: AlertifyService) { }

  ngOnInit() {
    this.initializeUploader();
}

initializeUploader() {
    let test = '';

    if (this.userId !== 0) {
        test = this.baseUrl + 'addPhoto/' + this.userId
    }
    

    this.uploader = new FileUploader({
        url: test,
        authToken: 'Bearer ' + localStorage.getItem('token'),
        isHTML5: true,
        allowedFileType: ['image'],
        removeAfterUpload: true,
        autoUpload: true,
        maxFileSize: 10 * 1024 * 1024
    });

    this.uploader.onAfterAddingFile = file => {
        file.withCredentials = false;
        console.log(file);
        this.alertify.success('Photo uploaded ...');
    };

    this.uploader.onSuccessItem = (item, response, status, headers) => {
        if (response) {
            debugger;
            const res: any = JSON.parse(response);
           if (this.userId !== 0) { this.getMemberPhotoChange.emit(res.photoUrl); }
        }
    };
}

}
