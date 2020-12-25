import { Injectable } from '@angular/core';
import { from, Observable } from 'rxjs';
import { IRegisterDTO } from '../data/iregisterdto';

@Injectable({
  providedIn: 'root'
})
export class AuthorizationService {

  // handles only authorization features
  // register, login, verify user, forgot password
  constructor() 
  {

  }


  registerUser(model: IRegisterDTO):Observable<any>{

      return from([{ test:model }])
  }

}
