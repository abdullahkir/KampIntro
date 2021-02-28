using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GamerManager : IUserService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(IUser user)
        {
            if (_userValidationService.Validate(user))
            {
                Console.WriteLine("Kayıt olundu..");

            }
            else
            {
                Console.WriteLine("Doğrulama başarısız..Kayıt işlemi gerçekleştirilemedi..");
            }
        }

        public void Delete(IUser user)
        {
            Console.WriteLine("Kayıt silindi..");
        }

        public void Update(IUser user)
        {
            Console.WriteLine("Kayıt güncellendi..");
        }
    }
}
