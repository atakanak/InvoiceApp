import { Component, EventEmitter, OnInit, Output } from '@angular/core';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent implements OnInit {
  
  @Output() onShowUpload = new EventEmitter<boolean>();

  showUpload() {
    this.onShowUpload.emit(true);
  }

  ngOnInit(): void {
  }

}
