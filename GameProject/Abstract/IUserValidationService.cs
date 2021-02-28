using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IUserValidationService
    {
        bool Validate(IUser user);
    }
}
