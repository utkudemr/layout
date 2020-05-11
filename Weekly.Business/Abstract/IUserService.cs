

using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Weekly.Business.Abstract
{
    public interface IUserService
    {
        User GetUserById(int id);
        User GetUserRole(int id);
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByMail(string email);
    }
}
