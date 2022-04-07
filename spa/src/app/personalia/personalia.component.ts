import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { personalia } from '../_models/personalia';
import { dropItem } from '../_models/dropItem';
import { DropdownService } from '../_services/dropdown.service';

@Component({
  selector: 'app-personalia',
  templateUrl: './personalia.component.html',
  styleUrls: ['./personalia.component.css']
})
export class PersonaliaComponent implements OnInit {
  per:personalia;
  optionsYN: Array<dropItem> = [];

  constructor(private route: ActivatedRoute, private drops: DropdownService) { }

  ngOnInit() {
    this.route.data.subscribe((data: {per: personalia})=>{
      this.per = data.per;
    });
    this.loadDrops();
  }

  loadDrops(){
    let d = JSON.parse(localStorage.getItem('YN'));
    if (d == null || d.length === 0) {
        this.drops.getYNOptions().subscribe((response) => {
            this.optionsYN = response; localStorage.setItem('YN', JSON.stringify(response));
        });
    } else {
        this.optionsYN = JSON.parse(localStorage.getItem('YN'));
    }
  }

}
