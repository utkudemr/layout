using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess;
using Core.Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        List<string> GetClaims(int opId);
        List<User> GetAllUserWithClaims();
        User GetUserWithClaims(int id);
        User Login(string username, string password);
    }
}
