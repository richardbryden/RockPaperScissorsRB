import { HttpClient } from "@angular/common/http";

import { observable, Observable } from "rxjs";



export interface GameData {

  p1Score: number;

  p2Score: number;

  tieSocre: number;

  p1Input: string;

  p2Input: string;

}





export class Connections {

  private baseURL = '/api/'

  constructor(private http: HttpClient) {

  }



  public getResult(pvc: boolean, playerChoice: string, scoreP1: number, scoreP2: number, scoreTie: number): Observable<GameData> {

    return Observable.create(observer => {

      observer.next(null);

      let pvcString = String(pvc);

      const url = `${this.baseURL}Get/${pvcString}/${playerChoice}/${scoreP1}/${scoreP2}/${scoreTie}`

      this.http.get(url).subscribe((data: GameData) => {

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
