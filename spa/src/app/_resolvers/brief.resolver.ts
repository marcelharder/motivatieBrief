import {Injectable} from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Brief } from '../_models/brief';
import { AlertifyService } from '../_services/alertify.service';
import { BriefService } from '../_services/brief.service';
@Injectable()

export class BriefResolver implements Resolve<Brief> {
    pageNumber = 1;
    pageSize = 12;
    
    constructor(private briefservice: BriefService,
        private router: Router, private alertify: AlertifyService) {

    }
    resolve(route: ActivatedRouteSnapshot): Observable<Brief> {
         return this.briefservice.getBrief(route.params.id).pipe(catchError(error => {
            this.alertify.error('Problem retrieving data');
            this.router.navigate(['/home']);
            return of(null);
        }));







    }
}