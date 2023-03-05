import { Component } from '@angular/core';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'InvoiceApp.Client';
  refreshGrid : boolean = false;

  ngOnInit() { }

  refreshList($event: any) {
    this.refreshGrid = true;
  }
}
