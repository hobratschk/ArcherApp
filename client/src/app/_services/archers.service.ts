import { IEventAScore } from './../_models/eventAScore';
import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IArcher } from '../_models/archer';
import { IEventBScore } from '../_models/eventBScore';
import { IArcherForm } from '../_models/archerForm';

@Injectable({
  providedIn: 'root'
})
export class ArchersService {
  baseUrl = 'https://localhost:5001/api/';

  constructor(private http: HttpClient) { }

  getArchers() {
    return this.http.get<IArcher[]>(this.baseUrl + 'archers');
  }

  getArcher(id: string) {
    return this.http.get<IArcher>(this.baseUrl + 'archers/' + id);
  }

  deleteEventAScore(id: number) {
    return this.http.delete(this.baseUrl + 'eventA/' + id)
  }

  createArcher(archer: IArcherForm) {
    const newArcher: IArcher = {
      firstName: archer.firstName,
      lastName: archer.lastName
    }
    return this.http.post<IArcher>(this.baseUrl + 'archers', newArcher);
  }

  getScoresA() {
    return this.http.get<IEventAScore[]>(this.baseUrl + 'eventA');
  }

  deleteArcher(archer: IArcher) {
    return this.http.delete<IArcher>(this.baseUrl + 'archers/' + archer.id)
  }
}