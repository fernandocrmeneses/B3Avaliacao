import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule,FormControl,FormControlDirective } from '@angular/forms';
import { Routes, RouterModule } from '@angular/router';


const routes: Routes = [];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    FormsModule, 
    ReactiveFormsModule,
    FormControlDirective,
    FormControl
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
