using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

//3. olarak bu Fonksiyon class'ı açıldı ve interface
//ile inheritance yapıldı.

namespace GameProject.Concrete
{
    //Microservice GamerManager içinde bir başka servis kullanılcak demek

    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService; //Bir manager sınıfının içinde başka bir manager kısmı kullanılacak ise asla onu new'leme onun yerine böyle yap.
        public GamerManager(IUserValidationService userValidationService) //Ampülden generete constructer seçersek çıkar
        {
            _userValidationService = userValidationService;
        }

        public void Registration(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("Kayıt olundu.");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız.");
            }
            //Kullanıcı kayıt olurken doğrulama yapılmalı. Yukarıdaki constructer yapısından sonra bu yapılır
        }

        public void Deregistration(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi.");
        }
    }
}
