import { Component, OnInit } from '@angular/core';
import { IArcher } from '../../_models/archer';
import { ArchersService } from '../../_services/archers.service';

@Component({
  selector: 'app-archers-list',
  templateUrl: './archers-list.component.html',
  styleUrls: ['./archers-list.component.css']
})
export class ArchersListComponent implements OnInit {
  archers: IArcher[];

  constructor(private archersService: ArchersService) {}

  ngOnInit(): void {
    this.loadArchers();
  }

  loadArchers() {
    this.archersService.getArchers().subscribe(response => {
      this.archers = response;
    })
  }

}
