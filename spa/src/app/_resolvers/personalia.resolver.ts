import {Injectable} from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { personalia } from '../_models/personalia';
import { AlertifyService } from '../_services/alertify.service';
import { PersonaliaService } from '../_services/personalia.service';
@Injectable()

export class PersonaliaResolver implements Resolve<personalia> {
  
    
    constructor(private persservice: PersonaliaService,
        private router: Router, private alertify: AlertifyService) { }

    resolve(route: ActivatedRouteSnapshot): Observable<personalia> {
         return this.persservice.getPersonalia(route.params.id).pipe(catchError(error => {
            this.alertify.error('Problem retrieving data');
            this.router.navigate(['/']);
            return of(null);
        }));







    }
}