using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public interface IChoice
    {

        public string Choice { get; }

        public string? WhoWon(IChoice p2Choice);

    }
}
