using System;
using System.Collections.Generic;
using System.Text;

//4. olarak bu servisi açtık. Doğrulama için açılmış özel bir servistir.

namespace GameProject
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer); //Parametre unutulmamalıdır.
        //Daha sonra 5. de yapılacak olan return ifadesinden dolayı bool yaptık
    }
}
