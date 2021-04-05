using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class RandomChoice
    {

        private static readonly Random _random = new Random();
            

        public static IChoice GetRandomChoice()
        {
List<IChoice> choice = new List<IChoice>() { new Rock(),new Paper(),new Scissors()};
            return choice[_random.Next(0, 2)];

        }

    }
}
