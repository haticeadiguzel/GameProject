using System;
using System.Collections.Generic;
using System.Text;

//5. interface açıldıktan ve ilgili kod yazıldıktan sonra
//birde manager class'ı açarız.
namespace GameProject
{
    class UserValidationManager : IUserValidationService //İnheritance yapılır
    {
        public bool Validate(Gamer gamer) //doğrulama kodları yazılır. Void Bool olarak değiştirildi
        {
            if (gamer.DateBirth == 1985 && gamer.FirstName == "Engin" &&   //bu koşullar sağlanırsa doğrulama gerçekleşmiş olur
                gamer.LastName == "Demiroğ" && gamer.NationalityNumber == "125635412")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
