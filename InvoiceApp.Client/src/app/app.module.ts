import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InvoiceListComponent } from './invoices/invoice-list/invoice-list.component';
import { InvoiceUploadComponent } from './invoices/invoice-upload/invoice-upload.component';

@NgModule({
  declarations: [
    AppComponent,
    InvoiceListComponent,
    InvoiceUploadComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
