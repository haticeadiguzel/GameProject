using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaigneManager : ICampaigneService
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
