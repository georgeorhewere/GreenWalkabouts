import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { from, Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { IRegisterDTO } from '../data/iregisterdto';
import { IServiceResponseDTO } from '../data/iserviceresponsedto';
import { HttpService } from './http.service';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  // handles only authorization features
  // register, login, verify user, forgot password
  constructor(private httpClient: HttpService) 
  {

  }


  registerUser(model: IRegisterDTO):Observable<any>{
      var url = environment.authorization.register
      console.log('Api Post',model);
      return this.httpClient.post<IServiceResponseDTO>(url, model,
        {
          headers: new HttpHeaders()
            .set('Content-Type', 'application/json')
            .set('Cache-Control', 'no-cache')
            .set('Pragma', 'no-cache')
        }); /* */
        // return from([{test:model}]);

      
  }

}
