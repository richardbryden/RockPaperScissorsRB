import { HttpClient } from "@angular/common/http";

import { Observable } from "rxjs";


export interface GameResult {
  gameResult: GameData;
}

export interface GameData {
  p1Score: number;
  p2Score: number;
  tieScore: number;
  p1Input: string;
  p2Input: string;

}





export class Connections {

  private baseURL = '/api/Game/'

  constructor(private http: HttpClient) {

  }

  public getResult(pvc: boolean, playerChoice: string, scoreP1: number, scoreP2: number, scoreTie: number): Observable<GameResult> {
    return Observable.create(observer => {
      observer.next(null);
      let pvcString = String(pvc);
      const url = `${this.baseURL}Get/${pvcString}/${playerChoice}/${scoreP1}/${scoreP2}/${scoreTie}`
      this.http.get(url).subscribe((data: GameResult) => {
        observer.next(data);
        observer.complete();
      },
        error => {
          observer.error(error);
        }
      );
    })
  }
}
