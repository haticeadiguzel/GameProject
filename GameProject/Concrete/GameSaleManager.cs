using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameSaleManager : IGameSaleService
    {
        public void Sale(Gamer gamer)
        {
            Console.WriteLine("Ürün Satıldı.");
        }
    }
}
