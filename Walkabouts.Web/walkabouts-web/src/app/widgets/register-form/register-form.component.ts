import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';

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
  }

  private formSetup(){
    
    this.userForm = this.formBuilder.group({
      firstName: '',
      lastName: '',
      email: '',
      password: '',
      confirmPassword: ''
      });
  }

}
