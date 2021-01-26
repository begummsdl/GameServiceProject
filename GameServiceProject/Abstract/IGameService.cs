using GameServiceProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameServiceProject.Abstract
{
    public interface IGameService
    {
        void Buy(Gamer gamer);
        void CampaignOfGameSave(Gamer gamer);
        void CampaignOfGameDelete(Gamer gamer);
        void CampaignOfGameUpdate(Gamer gamer);
    }
}
