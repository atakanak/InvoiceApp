import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { InvoiceListComponent } from './invoices/invoice-list/invoice-list.component';
import { InvoiceUploadComponent } from './invoices/invoice-upload/invoice-upload.component';
import { HttpClientModule } from '@angular/common/http';
import { NavComponent } from './layouts/nav/nav.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { InvoiceModalComponent } from './invoices/invoice-modal/invoice-modal.component';
import { MatDialogModule } from '@angular/material/dialog';

@NgModule({
  declarations: [
    AppComponent,
    InvoiceListComponent,
    InvoiceUploadComponent,
    NavComponent,
    InvoiceModalComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule, // required for input file change detection
    ReactiveFormsModule,
    HttpClientModule, // this is required for the actual http request
    MatDialogModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule {
  ngOnInit() { }
}

