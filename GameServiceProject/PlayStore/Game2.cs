using GameServiceProject.Abstract;
using GameServiceProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceProject.PlayStore
{
    public class Game2 : BaseGamerAndGameManager
    {
        public override void Buy(Gamer gamer)
        {
            Console.WriteLine("{0} bought game2!", gamer.FirstName);
        }

        public override void CampaignOfGameSave(Gamer gamer)
        {
            Console.WriteLine("Game2's campaign of {0} saved!", gamer.FirstName);
        }
        public override void CampaignOfGameUpdate(Gamer gamer)
        {
            Console.WriteLine("Game2's campaign of {0} updated!", gamer.FirstName);
        }
    }
}
