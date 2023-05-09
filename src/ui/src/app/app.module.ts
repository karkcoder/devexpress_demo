import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { DevexpressDemoComponent } from './devexpress-demo/devexpress-demo.component';

@NgModule({
  declarations: [
    AppComponent
  , DevexpressDemoComponent],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
