using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class CampainManager
    {
        public void NewCampaign()
        {
            Console.WriteLine("Yeni akmpanya oluşturuldu.");
        }

        public void DeleteCampaign()
        {
            Console.WriteLine("Kampanya silindi");
        }

        public void UpdateCampaign()
        {
            Console.WriteLine("Kampanya güncellendi.");
        }
    }
}
