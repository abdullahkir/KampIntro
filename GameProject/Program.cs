using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Counter-Strike";
            game1.GameType = "Savaş";


            Gamer gamer = new Gamer();
            gamer.Id = 1;
            gamer.FirstName = "Abdullah";
            gamer.LastName = "KIR";
            gamer.IdentityNumber = 11111111111;
            gamer.BirthYear = 1998;


            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(gamer);

            Campaign campaign1 = new Campaign();
            campaign1.CampaignId = 1;
            campaign1.CampaignName = "Sevgililer Günü Özel";
            campaign1.DiscountRate = 0.25;
            campaign1.StartDate = new DateTime(2021, 2, 14);
            campaign1.EndDate = new DateTime(2021, 2, 24);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Update(campaign1);
            campaignManager.Delete(campaign1);

            SaleManager saleManager = new SaleManager(campaign1);
            saleManager.Sale(game1, gamer);
        }
    }
}
