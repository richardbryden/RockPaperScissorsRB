using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class Game
    {

        
        public Score RunGame(string playerOrComputer, string playerChoice, int scoreP1, int scoreP2, int tieScore)
        {

            Score score = new Score() { p1Score = scoreP1, p2Score = scoreP2, tieScore = tieScore, p1Input = playerChoice, p2Input = "" };

            IChoice p1Choice = RandomChoice.GetRandomChoice();

            if (playerOrComputer == "True")  {

                p1Choice = TextToChoice.GetTextChoice(playerChoice);

            }
            score.p1Input = p1Choice.Choice;


            IChoice p2Choice = RandomChoice.GetRandomChoice();

            score.p2Input = p2Choice.Choice;

            if (p1Choice.WhoWon(p2Choice) == "p1") { score.p1Score++; }

            if (p1Choice.WhoWon(p2Choice) == "p2") { score.p2Score++; }

            if (p1Choice.WhoWon(p2Choice) == "tie") { score.tieScore++; }

            return score;

        }

    }


}
