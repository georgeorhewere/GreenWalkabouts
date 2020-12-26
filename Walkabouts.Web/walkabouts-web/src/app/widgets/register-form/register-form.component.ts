import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

import { IRegisterDTO } from 'src/app/shared/data/iregisterdto';
import { MustMatch } from 'src/app/shared/validators/must-match';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss']
})
export class RegisterFormComponent implements OnInit {

  userForm: FormGroup;
  submitted = false;
  @Output()
  Save : EventEmitter<IRegisterDTO> = new EventEmitter<IRegisterDTO>();
  constructor(private formBuilder: FormBuilder) 
  {

   }

  ngOnInit(): void {
    this.formSetup()
    console.log('set-up', this.userForm)
  }

  private formSetup(){
    
    this.userForm = this.formBuilder.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      email: ['', [ 
                  Validators.email,
                  Validators.required,
                  
                  ]
                ],
      password: ['', [Validators.required, Validators.min(6)]],
      confirmPassword: ['', [Validators.required,Validators.min(6)]],
      }, {
        validator: MustMatch('password', 'confirmPassword')
    });
  }

  get form() { return this.userForm.controls; }

  saveUser(){
    if(this.userForm.valid){
         console.log('submitted form', this.userForm.value);
         var model = <IRegisterDTO>this.userForm.value;
         this.Save.emit(model);
    }else{
      console.log('error state', this.userForm)
    }
  }

}
