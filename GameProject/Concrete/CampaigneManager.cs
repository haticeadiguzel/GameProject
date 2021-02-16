using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampaigneManager : ICampaigneService
    {
        public void CampaigneDelete()
        {
            Console.WriteLine("Kampanya silindi.");
        }

        public void CampaigneUpdete()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }

        public void NewCampaigneEnter()
        {
            Console.WriteLine("Yeni kampanya girildi.");
        }
    }
}
