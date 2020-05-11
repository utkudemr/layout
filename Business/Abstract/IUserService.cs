using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<string> GetClaims(int opId);
        IDataResult<User> Add(User user);
        IDataResult<User> Update(User user);
        void Remove(int userId);
        User GetByMail(string email);
        User GetById(int id);
        IList<User> GetAll();
        IList<User> GetAllUser();
        User Login(string sesano, string password);
    }
}
