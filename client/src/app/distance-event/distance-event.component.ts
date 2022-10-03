import { IEventAScore } from './../_models/eventAScore';
import { EventAService } from 'src/app/_services/eventA.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-distance-event',
  templateUrl: './distance-event.component.html',
  styleUrls: ['./distance-event.component.css']
})
export class DistanceEventComponent implements OnInit {
  eventAScores: IEventAScore[];

  constructor(private eventAService: EventAService) { }

  ngOnInit(): void {
    this.loadEventAScores();
  }

  loadEventAScores() {
    this.eventAService.getScoresA().subscribe(response => {
      this.eventAScores = response.sort((a, b) => (b.targetA + b.targetB + b.targetC + b.targetD + b.targetE + b.targetF) - (a.targetA + a.targetB + a.targetC + a.targetD + a.targetE + a.targetF));
    })
  }

}
