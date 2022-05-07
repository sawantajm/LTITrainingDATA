import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http';




@Injectable()



export class ImageService
{
    constructor( private http:HttpClient)
    {

    }

uploadImage(img:any)
{
return this.http.post('http://localhost:18045/api/Imageuploads',img,{responseType: 'text'});
}

}