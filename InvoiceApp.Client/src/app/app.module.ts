import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InvoiceListComponent } from './invoices/invoice-list/invoice-list.component';
import { InvoiceUploadComponent } from './invoices/invoice-upload/invoice-upload.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './layouts/nav/nav.component';

@NgModule({
  declarations: [
    AppComponent,
    InvoiceListComponent,
    InvoiceUploadComponent,
    NavComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {

  public show: boolean = false;

  ngOnInit() { }

  showFileUpload() {
    this.show = !this.show;

  }
}

