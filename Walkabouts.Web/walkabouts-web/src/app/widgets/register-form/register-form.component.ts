import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { MustMatch } from 'src/app/shared/validators/must-match';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss']
})
export class RegisterFormComponent implements OnInit {

  userForm: FormGroup;
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
      password: ['', [  Validators.required, Validators.min(6)]],
      confirmPassword: ['', [Validators.required,Validators.min(6)]],
      }, {
        validator: MustMatch('password', 'confirmPassword')
    });
  }

  get form() { return this.userForm.controls; }

  saveUser(){
    if(this.userForm.valid){
         console.log('submitted form', this.userForm.value);
    }else{
      console.log('error state', this.userForm)
    }
  }

}
