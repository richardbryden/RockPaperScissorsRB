import { HttpXhrBackend,HttpClient } from '@angular/common/http';
import { Component, OnInit} from '@angular/core';
import { Connections, GameData } from '../common/connections';

@Component({
  selector: 'app-game',
  templateUrl: './game.html',
})
export class GameComponent implements OnInit{
  public gameChoices = [{ name: 'Rock' }, { name: 'Paper' }, { name: 'Scissors' }];
  public gameOptions = [{ name: 'Player vs Computer' }, { name: 'Computer vs Computer' }];
  public gameOption: boolean = false;
  public p1Choice: string = "";
  public p2Choice: string = "";
  public p1Score: number = 0;
  public p2Score: number = 0;
  public tieScore: number = 0;
  public gameScore: GameData;
  private connections: Connections;
  
  constructor() {   
  }

  ngOnInit(): void{
    const httpClient = new HttpClient(new HttpXhrBackend({ build: () => new XMLHttpRequest() }));
    this.connections = new Connections(httpClient);
  }

  public getData() {

    this.connections.getResult(this.gameOption, this.p1Choice, this.p1Score, this.p2Score, this.tieScore).subscribe(data => {
      this.p1Score = data.p1Score;
      this.p2Score = data.p2Score;
      this.tieScore = data.tieSocre;
      this.p1Choice = data.p1Input;
      this.p2Choice = data.p2Input;
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
    this.p1Choice = show.name;
  }

  public runGame() {
    this.getData();
  }

  public resetGame() {
    this.p1Score = 0;
    this.p2Score = 0;
    this.tieScore = 0;
  }
}
