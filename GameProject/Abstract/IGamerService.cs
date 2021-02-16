using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

//2. Özellik class'ından hemen sonra bir interface açıldı
//bu sayede kodlarımızın daha kontrol edilebilir olması sağlandı.

namespace GameProject.Abstract
{
    public interface IGamerService
    {
        void Registration(Gamer gamer); //servisin yapılmasını istediği işlemleri burda tanımladık.
        void Update(Gamer gamer);       //Parametre olarak oyuncuyu belirtmeyi unutmamalıyız.
        void Deregistration(Gamer gamer);
    }
}
