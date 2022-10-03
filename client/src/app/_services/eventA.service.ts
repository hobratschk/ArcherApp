import { IEventAScore } from './../_models/eventAScore';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IEventBScore } from '../_models/eventBScore';
import { IArcher } from '../_models/archer';
import { IEventAForm } from '../_models/eventAForm';

@Injectable({
  providedIn: 'root'
})
export class EventAService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  createEventAScore(score: IEventAForm, archer: IArcher) {
    const newScore: IEventAScore = {
        archerId: archer.id,
        archerName: `${archer.firstName} ${archer.lastName}`,
        targetA: score.targetA,
        targetB: score.targetB,
        targetC: score.targetC,
        targetD: score.targetD,
        targetE: score.targetE,
        targetF: score.targetF
    }
    return this.http.post(this.baseUrl + 'eventA', newScore);
  }

  updateEventAScore(score: IEventAScore) {
    return this.http.put(this.baseUrl + 'eventA', score);
  }

  deleteEventAScore(score: IEventAScore) {
    // return this.http.delete(this.baseUrl + 'eventA/' + id)
    return this.http.delete(this.baseUrl + 'eventA/' + score.id)
  }

  getScoresA() {
    return this.http.get<IEventAScore[]>(this.baseUrl + 'eventA');
  }
  getScoresB() {
    return this.http.get<IEventBScore[]>(this.baseUrl + 'eventB');
  }
}