using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Ürün Satıldı.");
        }
    }
}
