using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class SaleManager : ISaleService
    {
        Campaign _campaign;

        public SaleManager(Campaign campaign)
        {
            _campaign = campaign;
        }

        public void Sale(Game game, Gamer gamer)
        {

            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + "isimli kullanıcı" + " " +
            game.GameName + " " + "isimli oyunu" + " " + _campaign.CampaignName + " " + "Kampanyası ile satın aldı...");
        }
    }
}
