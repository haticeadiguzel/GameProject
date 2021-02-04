using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager()); //doğrulama sınıfının kim olduğunu söylemeliyiz.
            gamerManager.Registration(new Gamer //Yeni oyuncuyu böyle belirtmeliyiz.
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                DateBirth = 1985,
                NationalityNumber = "125635412"
            });

            GamerManager gamerManager2 = new GamerManager(new NewEStateUserValidationManager()); //doğrulama sınıfının kim olduğunu söylemeliyiz.
            gamerManager2.Registration(new Gamer
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                DateBirth = 1985,
                NationalityNumber = "125635412"
            }); //Bu şekilde yeni sistemi deneriz.

            GameSaleManager gameSaleManager = new GameSaleManager();
            gameSaleManager.Sale(new Gamer
            {
                FirstName = "Engin",
                LastName = "Demiroğ",
                DateBirth = 1985,
                NationalityNumber = "125635412"
            });

            CampaigneManager campaigneManager = new CampaigneManager();
            campaigneManager.CampaigneDelete();
            campaigneManager.CampaigneUpdete();
            campaigneManager.NewCampaigneEnter();
        
        }
    }
}
