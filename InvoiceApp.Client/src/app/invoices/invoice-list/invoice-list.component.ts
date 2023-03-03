import { Component, OnInit } from '@angular/core';
import { InvoiceService } from 'src/services/invoice.service';

@Component({
  selector: 'app-invoice-list',
  templateUrl: './invoice-list.component.html',
  styleUrls: ['./invoice-list.component.css']
})
export class InvoiceListComponent implements OnInit {
  invoices: any;

  constructor(private _apiservie: InvoiceService) {

  }
  ngOnInit(): void {

    this._apiservie.getInvoiceList().subscribe(res => {
      this.invoices = res;
    });
  }
}
