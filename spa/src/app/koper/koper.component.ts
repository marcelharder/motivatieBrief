import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-koper',
  templateUrl: './koper.component.html',
  styleUrls: ['./koper.component.css']
})
export class KoperComponent implements OnInit {
  motivatie = 0;
  personalia = 0;

  constructor() { }

  ngOnInit() {
  }

  showMotivatie(){if(this.motivatie === 1) return true}
  showPersonalia(){if(this.personalia === 1) return true}

  mot(){this.motivatie = 1; this.personalia = 0;}
  pers(){this.personalia = 1; this.motivatie = 0;}

}
