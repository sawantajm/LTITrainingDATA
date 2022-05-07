import { NgModule } from '@angular/core';
import { FormBuilder, FormsModule, ReactiveFormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ReactiveComponent } from './reactive/reactive.component';
import { TempaltedformComponent } from './tempaltedform/tempaltedform.component';
import { CardComponent } from './card/card.component';
import { ImageuploadComponent } from './imageupload/imageupload.component';
import { HttpClientModule } from '@angular/common/http';
import { ImageService } from './Service/Imageservice.service';



@NgModule({
  declarations: [
    AppComponent,
    ReactiveComponent,
    TempaltedformComponent,
    CardComponent,
   
    ImageuploadComponent,
 

  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule

    
  ],
  providers: [ImageService],
  bootstrap: [AppComponent]
})
export class AppModule { }
