import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  archers: any;
  model: any;

  constructor(private http: HttpClient) {}

  ngOnInit() {
    this.getArchers();
  }

  getArchers() {
    this.http.get('https://localhost:5001/api/archers').subscribe(response => {
      this.archers = response
    }, error => {
      console.log(error);
    })
  }

  addArcher() {
    console.log(this.model);
  }
}
