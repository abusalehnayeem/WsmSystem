import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SharedKernelsModule } from './shared-kernels/shared-kernels.module';

@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    SharedKernelsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
