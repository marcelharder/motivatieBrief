import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PdfService {

baseUrl= environment.apiUrl;

constructor(private http: HttpClient) { }

constructPdf(id: number){ return this.http.get<any>(this.baseUrl + 'getPDF/' + id, {responseType: 'blob' as 'json'});}

}
