using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class Rock : IChoice
    {



        public string Choice { get { return "Rock"; } }



        public string WhoWon(IChoice p2Choice)
        {



            return p2Choice.Choice switch
            {

                "Rock" => "Tie",

                "Paper" => "p2",

                "Scissors" => "p1",

                _ => throw new NotImplementedException(),

            };



        }

    }
}
