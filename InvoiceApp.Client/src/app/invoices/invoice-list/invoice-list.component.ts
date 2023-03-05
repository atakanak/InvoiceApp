import { Component, Input, OnInit } from '@angular/core';
import { InvoiceService } from 'src/services/invoice.service';

@Component({
  selector: 'app-invoice-list',
  templateUrl: './invoice-list.component.html',
  styleUrls: ['./invoice-list.component.css']
})
export class InvoiceListComponent implements OnInit {
  @Input() refreshGrid: boolean = false;
  invoices: any;
  showModal = false;
  details: any;


  constructor(private _apiservice: InvoiceService) { }

  ngOnInit(): void {
    this.getInvoicesList();
  }

  getInvoicesList() {
    this._apiservice.getInvoiceList().subscribe(res => {
      console.log(31);
      this.invoices = res;
    });
  }

  getDetails(id: any) {
    this.showModal = !this.showModal;

    this._apiservice.getInvoiceDetail(id).subscribe(res => {
      this.details = res;
    });
  }

  toggleModal() {
    this.showModal = !this.showModal;
  }


  ngOnChanges() {
    if (this.refreshGrid) {
      console.log(123123123);
      this.getInvoicesList();
    }
  }
}

