import { ToastrService } from 'ngx-toastr';
import { IEventBScore } from './../../_models/eventBScore';
import { IEventAScore } from './../../_models/eventAScore';
import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { IArcher } from 'src/app/_models/archer';
import { ArchersService } from 'src/app/_services/archers.service';
import { EventAService } from 'src/app/_services/eventA.service';
import { NgForm } from '@angular/forms';
import { IEventAForm } from 'src/app/_models/eventAForm';

@Component({
  selector: 'app-archer-details',
  templateUrl: './archer-details.component.html',
  styleUrls: ['./archer-details.component.css']
})
export class ArcherDetailsComponent implements OnInit {
  @ViewChild('editScoreAForm') editScoreAForm: NgForm;
  // @ViewChild('editScoreBForm') editScoreBForm: NgForm;
  archer: IArcher;
  scoreA: IEventAScore;
 // scoreB: IEventBScore;

  constructor(private archersService: ArchersService, private eventAService: EventAService, private route: ActivatedRoute, private toastr: ToastrService) { }

  ngOnInit(): void {
    this.loadArcher();
    this.loadScoreA();
  }

  loadArcher() {
    this.archersService.getArcher(this.route.snapshot.paramMap.get('id')).subscribe(archer => {
      this.archer = archer;
    })
  }

  loadScoreA() {
    this.loadArcher();
    this.archersService.getScoresA().subscribe(scoresA => (
      this.scoreA = this.archer !== undefined && scoresA.filter(score => score.archerId === this.archer.id)[0] || {
        archerName: `${this.archer.firstName} ${this.archer.lastName}`,
        archerId: this.archer.id,
        targetA: 0,
        targetB: 0,
        targetC: 0,
        targetD: 0,
        targetE: 0,
        targetF: 0
      }
    ))
  }

  addScoreA(score: IEventAForm, archer: IArcher) {
    this.eventAService.createEventAScore(score, archer).subscribe(() => {
      this.toastr.success('Distance score created successfully.')
    });
    this.editScoreAForm.reset(this.scoreA);
  }

  updateEventAScore(score: IEventAScore) {
    this.eventAService.updateEventAScore(score).subscribe(() => {
      this.toastr.success('Distance score updated successfully.')
    });
    this.editScoreAForm.reset(this.scoreA);
  }

  deleteArcher(archer: IArcher, score: IEventAScore) {
    this.archersService.deleteArcher(archer);
    this.eventAService.deleteEventAScore(score);
  }
}
