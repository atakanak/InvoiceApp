import { Component, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-invoice-modal',
  templateUrl: './invoice-modal.component.html',
})

export class InvoiceModalComponent implements OnInit {
  showModal = false;

  constructor() { }

  ngOnInit(): void {
  }

  toggleModal() {
    this.showModal = !this.showModal;
  }

}
