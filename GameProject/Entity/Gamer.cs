using System;
using System.Collections.Generic;
using System.Text;

//1. olarak bu özellik class'ı açıldı ve bu class'ta
//olması gereken özellikler yazıldı

namespace GameProject.Entity
{
    public class Gamer
    {
        public string NationalityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int DateBirth { get; set; }
    }
}
