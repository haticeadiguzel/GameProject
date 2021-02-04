using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager
    {
        public void KayıtOlma()
        {
            Console.WriteLine("Oyuncu kayıt edildi.");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu güncellendi");
        }

        public void Deregistation()
        {
            Console.WriteLine("Oyuncu silindi");
        }
    }
}
