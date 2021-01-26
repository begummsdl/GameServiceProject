using GameServiceProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceProject.Abstract
{
    public abstract class BaseGamerAndGameManager : IGamerService, IGameService
    {
        //Oyuncu işlemleri
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted : {0} {1}", gamer.FirstName, gamer.LastName);
        }

        public void Save(Gamer gamer)
        {
            Console.WriteLine("Gamer saved to database : {0} {1}", gamer.FirstName, gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer updated : {0} {1}", gamer.FirstName, gamer.LastName);
        }

        //Oyun işlemleri
        public void CampaignOfGameDelete(Gamer gamer)
        {
            Console.WriteLine("Game's campaign of {0} deleted!", gamer.FirstName);
        }

        public abstract void CampaignOfGameSave(Gamer gamer);
        public abstract void CampaignOfGameUpdate(Gamer gamer);
        public abstract void Buy(Gamer gamer);
    }
}
