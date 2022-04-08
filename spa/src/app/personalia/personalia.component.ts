import { Component, Input, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { personalia } from '../_models/personalia';
import { dropItem } from '../_models/dropItem';
import { DropdownService } from '../_services/dropdown.service';
import { PersonaliaService } from '../_services/personalia.service';

@Component({
  selector: 'app-personalia',
  templateUrl: './personalia.component.html',
  styleUrls: ['./personalia.component.css']
})
export class PersonaliaComponent implements OnInit {
  @Input() pe: personalia;
  optionsYN: Array<dropItem> = [];
  optionsBurgerlijkeStaat: Array<dropItem> = [];
  optionsHuwlijksgoederen: Array<dropItem> = [];

  constructor(
    private route: ActivatedRoute,
    private router:Router, 
    private persservice: PersonaliaService) { }

  ngOnInit() {
   
   this.loadDrops();
  }

  loadDrops(){
   this.optionsYN.push({value:1, description: 'kies'});
   this.optionsYN.push({value:2, description: 'ja'});
   this.optionsYN.push({value:2, description: 'nee'});
  }

  save(){this.persservice.savePersonalia(this.pe).subscribe(()=>{
    this.router.navigate(['/makelaar']);
  })}
  cancel(){ this.router.navigate(['/makelaar']);}

}
