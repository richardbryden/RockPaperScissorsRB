using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RockPaperScissorsRB.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockPaperScissorsRB.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class GameController : ControllerBase
    {

        private readonly Game game = new Game();


        [HttpGet("[action]/{pvc}/{playerChoice}/{scoreP1:int}/{scoreP2:int}/{tieScore:int}")]

        public async Task<ActionResult> Get(string pvc, string playerChoice, int scoreP1, int scoreP2, int tieScore)        {

            var myTask = Task.Run(() => this.game.RunGame(pvc, playerChoice, scoreP1, scoreP2, tieScore));

            var gameResult = await myTask;

            return this.Ok(new { gameResult });

        }


    }
}
