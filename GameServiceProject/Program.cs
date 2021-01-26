using GameServiceProject.Abstract;
using GameServiceProject.PlayStore;
using GameServiceProject.Entities;
using System;

namespace GameServiceProject
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseGamerAndGameManager gamerAndGameManager = new Game1();
            Gamer gamer = new Gamer { DateOfBirth = new DateTime(2001, 10, 27), FirstName = "Begüm", LastName = "Muşdal", NationalityId = "11111111111" };
            Gamer gamer2 = new Gamer { DateOfBirth = new DateTime(2001, 10, 25), FirstName = "Nisa", LastName = "Has", NationalityId = "22222222222" };
            gamerAndGameManager.Save(gamer);
            gamerAndGameManager.Buy(gamer);
            gamerAndGameManager.CampaignOfGameSave(gamer);
            gamerAndGameManager.Delete(gamer);
            gamerAndGameManager.Save(gamer2);
            gamerAndGameManager.Buy(gamer2);
            gamerAndGameManager.CampaignOfGameUpdate(gamer2);
            gamerAndGameManager.Delete(gamer2);

            BaseGamerAndGameManager gamerAndGameManager2 = new Game2();
            Gamer gamer3 = new Gamer { DateOfBirth = new DateTime(2001, 10, 8), FirstName = "Begüm", LastName = "Ünal", NationalityId = "33333333333" };
            gamerAndGameManager2.Save(gamer3);
            gamerAndGameManager2.Buy(gamer3);

            Console.ReadLine();
        }
    }
}
