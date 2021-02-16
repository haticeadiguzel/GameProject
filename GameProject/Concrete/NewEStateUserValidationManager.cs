using GameProject.Abstract;
using GameProject.Entity;
using System;
using System.Collections.Generic;
using System.Text;

//6. Eğer e dvlet değişirse yeni sistemi bu şekilde oluştururuz
namespace GameProject.Concrete
{
    public class NewEStateUserValidationManager : IUserValidationService //İnheritence eklenir
    {
        public bool Validate(Gamer gamer)
        {
            return true; //burdan program cs de yeni sistemi denedik.
        }
    }
}
