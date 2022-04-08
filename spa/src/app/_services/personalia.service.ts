import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { personalia } from '../_models/personalia';

@Injectable({
  providedIn: 'root'
})
export class PersonaliaService {

baseUrl = environment.apiUrl;
constructor(private http: HttpClient) { }


getPersonalia(koper:number){return this.http.get<personalia>(this.baseUrl + 'getPersonalia/' + koper)};
savePersonalia(br: personalia){return this.http.post(this.baseUrl + 'updatePersonalia', br)};


}
