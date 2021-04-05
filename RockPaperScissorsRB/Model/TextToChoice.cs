using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Model
{
    public class TextToChoice
    {

        private static readonly Random _random = new Random();


        public static IChoice GetTextChoice(string input)
        {
            List<IChoice> choice = new List<IChoice>() { new Rock(), new Paper(), new Scissors() , new Invalid()};
            return input switch
            {
                "Rock" => choice[0],
                "Paper" => choice[1],
                "Scissors" => choice[2],
                _ => choice[3]

            };


        }

    }
}
