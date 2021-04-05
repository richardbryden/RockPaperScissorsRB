using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class Paper : IChoice
    {



        public string Choice { get { return "Paper"; } }



        public string WhoWon(IChoice p2Choice)
        {



            return p2Choice.Choice switch
            {

                "Rock" => "p1",

                "Paper" => "tie",

                "Scissors" => "p2",

                _ => throw new NotImplementedException(),

            };



        }

    }
}
