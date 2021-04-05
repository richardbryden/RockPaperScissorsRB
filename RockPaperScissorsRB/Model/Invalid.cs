using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class Invalid : IChoice
    {



        public string Choice { get { return "ERROR"; } }



        public string WhoWon(IChoice p2Choice)
        {



            return p2Choice.Choice switch
            {

                "Rock" => "Tie",

                "Paper" => "Tie",

                "Scissors" => "Tie",

                _ => throw new NotImplementedException(),

            };



        }

    }
}
