import { HttpHeaders } from '@angular/common/http';
import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { InvoiceService } from 'src/services/invoice.service';

@Component({
  selector: 'app-invoice-upload',
  templateUrl: './invoice-upload.component.html',
  styleUrls: ['./invoice-upload.component.css']
})
export class InvoiceUploadComponent implements OnInit {
  @Output() refreshList = new EventEmitter();
  file: any;

  constructor(private _apiservice: InvoiceService) {

  }

  ngOnInit(): void {
  }

  getFile(event: any) {
    this.file = event.target.files[0];
  }

  uploadFile() {
    if (this.file) {
      this._apiservice.uploadInvoice(this.file).subscribe(
        data => {
          this.refreshList.emit("refresh");
        },
        error => alert(error.error),
      );

    } else {
      alert("Please select a file first")
    }
  }
}
