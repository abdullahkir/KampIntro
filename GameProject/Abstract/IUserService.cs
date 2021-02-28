using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IUserService
    {
        void Add(IUser user);
        void Update(IUser user);
        void Delete(IUser user);
    }
}
