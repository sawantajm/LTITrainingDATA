import { Component, ContentChild, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-reactive',
  templateUrl: './reactive.component.html',
  styleUrls: ['./reactive.component.css']
})
export class ReactiveComponent implements OnInit {

  showPassword?:false;


  
  constructor(private fb:FormBuilder) { }

  ngOnInit(): void {
  }

  regform=this.fb.group({
    username : ['',[Validators.required,Validators.pattern('[a-zA-Z \s]*'),Validators.minLength(4)]],
    password : ['',[Validators.required,Validators.pattern('^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$')]],
    mobileno :['',[Validators.required,Validators.pattern("^[0-9]*$"),Validators.minLength(10),Validators.maxLength(10)]]
   
   

  });


  get username()
  {
   return this.regform.get('username');
  }


  get password()
  {
    return this.regform.get('password');
  }



  get mobileno()
  {
    return this.regform.get('mobileno');
  }
  toggleShow() {
    this.showPassword != this.showPassword;
    /*this.input.type = this.showPassword ? 'text' : 'password';*/
  }
}
