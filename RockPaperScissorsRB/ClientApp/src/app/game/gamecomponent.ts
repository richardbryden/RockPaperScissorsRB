import { HttpXhrBackend, HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Connections, GameResult } from '../common/connections';

@Component({
  selector: 'app-game',
  templateUrl: './game.html',
  styleUrls: ['./game.css']
})
export class GameComponent{
  public gameChoices = [{ name: 'Rock' }, { name: 'Paper' }, { name: 'Scissors' }];
  public gameOptions = [{ name: 'Player vs Computer' }, { name: 'Computer vs Computer' }];
  public gameOption: boolean = false;
  public p1Choice: string = "null";
  public p2Choice: string = "null";
  public p1Score: number = 0;
  public p2Score: number = 0;
  public tieScore: number = 0;
  public error: boolean = false;
  public gameScore;
  private connections: Connections;
  
  constructor(http: HttpClient) {
    this.connections = new Connections(http);
  }

  public getData() {
    this.connections.getResult(this.gameOption, this.p1Choice, this.p1Score, this.p2Score, this.tieScore).subscribe(data => {
      if (data) {
        this.p1Score = data.gameResult.p1Score;
        this.p2Score = data.gameResult.p2Score;
        this.tieScore = data.gameResult.tieScore;
        this.p1Choice = data.gameResult.p1Input;
        this.p2Choice = data.gameResult.p2Input;
      }
    });
  }

  public showGameOptions(show) {
    let _gameOption = (show == 'Computer vs Computer');
    if (this.gameOption != _gameOption) {
      this.resetGame();
      this.gameOption = _gameOption;
    }
  }

  public showGameChoices(show) {
    this.p1Choice = show;
    this.error = false;
  }

  public runGame() {
    if (this.p1Choice == "null" && !this.gameOption) {
      this.error = true;
    } else {
      this.getData();
    }
  }

  public resetGame() {
    this.p1Score = 0;
    this.p2Score = 0;
    this.tieScore = 0;
  }
}
