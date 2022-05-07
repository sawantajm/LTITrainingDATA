import { Component, OnInit } from '@angular/core';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-tempaltedform',
  templateUrl: './tempaltedform.component.html',
  styleUrls: ['./tempaltedform.component.css']
})
export class TempaltedformComponent implements OnInit 
{

    username?:string;
    
    password?:string;
    mobileno?:string;
    DOB?:Date;
    email?:string;

  constructor() { }

  ngOnInit(): void {
  }

  Doregister(data:NgForm)
  {
   
    console.log(data.value);
    data.reset();
  }
}
