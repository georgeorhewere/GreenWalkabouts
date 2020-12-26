import { Component, OnInit } from '@angular/core';
import { IRegisterDTO } from 'src/app/shared/data/iregisterdto';
import { AuthorizationService } from 'src/app/shared/services/authorization.service';

@Component({
  selector: 'app-signup',
  templateUrl: './signup.component.html',
  styleUrls: ['./signup.component.scss']
})
export class SignupComponent implements OnInit {

  constructor(private authService: AuthorizationService) { }

  ngOnInit(): void 
  {
  }


  SaveUser(userForm: IRegisterDTO){
     this.authService.registerUser(userForm).subscribe((x) =>{
      console.log('Form Saved', x)
    });
    
  }

}
