
using DataAccess.Concrete.EntityFramework.Contexts;
using System;
using System.Collections.Generic;
using System.Text;
using Weekly.Business.Abstract;
using Weekly.DataAccess.Abstract;

namespace Weekly.Business.Concrete
{
    public class UserManager : IUserService
    {
        private static IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }
        
        public User GetUserById(int id)
        {
            return _userDal.Get(a=>a.Id==id);
        }

        public User GetUserRole(int id)
        {
            var user = GetUserById(id);
            var response=_userDal.GetClaims(user);
            return null;
        }

        public User GetByMail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
