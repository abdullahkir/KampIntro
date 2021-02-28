using GameProject.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(IUser user)
        {
            if (user.FirstName == "Abdullah" && user.LastName == "KIR" && user.IdentityNumber == 11111111111 && user.BirthYear == 1998)
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
