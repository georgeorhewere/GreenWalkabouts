import { Component, OnInit } from '@angular/core';
import { IRegisterDTO } from 'src/app/shared/data/iregisterdto';
import { IServiceResponseDTO } from 'src/app/shared/data/iserviceresponsedto';
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
     this.authService.registerUser(userForm).subscribe((x:IServiceResponseDTO) =>{
     
      if(x.success){
        console.log('Form Saved', x.data)
        //notification service 
        //redirect to home or return url.

      }else{
          console.log('api error', x.error,x.message)/////()
      }
    });
    
  }

}
