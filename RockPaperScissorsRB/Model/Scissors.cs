using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class Scissors : IChoice
    {



        public string Choice { get { return "Scissors"; } }



        public string WhoWon(IChoice p2Choice)
        {



            return p2Choice.Choice switch
            {

                "Rock" => "p2",

                "Paper" => "p1",

                "Scissors" => "tie",

                _ => throw new NotImplementedException(),

            };



        }

    }
}
