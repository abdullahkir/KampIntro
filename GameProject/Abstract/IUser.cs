using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    public interface IUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public int BirthYear { get; set; }

    }
}
