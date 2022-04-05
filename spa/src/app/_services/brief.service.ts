import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { Brief } from '../_models/brief';

@Injectable({
  providedIn: 'root'
})
export class BriefService {
  
baseUrl = environment.apiUrl;


constructor(private http: HttpClient) { }

getBrief(koper:number){return this.http.get<Brief>(this.baseUrl + 'getBrief/' + koper)};
saveBrief(br: Brief){return this.http.post(this.baseUrl + 'updateBrief', br)}


}
