import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CardComponent } from './card/card.component';
import { ImageuploadComponent } from './imageupload/imageupload.component';
import { ReactiveComponent } from './reactive/reactive.component';
import { TempaltedformComponent } from './tempaltedform/tempaltedform.component';

const routes: Routes = [
  {
    path:"reactiveform",component:ReactiveComponent

  
  },
  {
    path:"template",component:TempaltedformComponent
  },
  {
    path:"card", component:CardComponent
  },
  {
    path:"image", component:ImageuploadComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
