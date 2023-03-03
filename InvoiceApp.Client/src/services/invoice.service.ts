import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { InvoiceHeader } from 'src/models/invoice-header.model';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class InvoiceService {

  apiBaseUrl = environment.apiBaseUrl;
  
  constructor(private _http: HttpClient) { }

  getInvoiceList(): Observable<InvoiceHeader[]> {
    return this._http.get<InvoiceHeader[]>(this.apiBaseUrl + 'api/Invoice/GetInvoices');
  }

  getInvoiceDetail() {

  }
}
