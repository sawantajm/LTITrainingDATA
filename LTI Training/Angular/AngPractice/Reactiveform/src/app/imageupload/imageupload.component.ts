import { Component, OnInit } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ImageService } from '../Service/Imageservice.service';

@Component({
  selector: 'app-imageupload',
  templateUrl: './imageupload.component.html',
  styleUrls: ['./imageupload.component.css']
})
export class ImageuploadComponent implements OnInit {

  selectedfile?:File;




  constructor( private fb:FormBuilder,private imgservice:ImageService) { }

  ngOnInit(): void {
  }



  Imageupload=this.fb.group({

image:['']
  });


get image()
{
 return this.Imageupload.get('image');
}


  onfileSelected(event:any)
  {
    debugger;
    console.log(event);
  if(event.target.files.length>0)
  {
    const file =event.target.files[0];
    this.Imageupload.get('image')?.setValue(file);
  }
  }

img:any;
  Onupload()
  {
   debugger;
   console.log(this.Imageupload.value);
  this.imgservice.uploadImage(this.Imageupload.value).subscribe((data)=>{this.img = data});
    
  }
}
