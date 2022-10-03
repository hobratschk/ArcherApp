import { IArcher } from './archer';

export interface IEventBScore {
    id: number;
    archer: IArcher;
    archerId: number;
    targetA: number;
    targetB: number;
    targetC: number;
    targetD: number;
    targetE: number;
    timePenalty: number;
}