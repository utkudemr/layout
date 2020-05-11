using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Core.Extensions;
using Core.Utilities.Results;
using Business.Constants;
using Business.BusinessAspects.Autofac;
using Weekly.Entities.Concrete;
using Core.CrossCuttingConcerns.Logging.Log4Net.Loggers;
using Core.Aspects.Autofac.Logging;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;


        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<string> GetClaims(int opId)
        {
            return _userDal.GetClaims(opId);
        }

        public bool IsExist(string userName)
        {
            var exist = _userDal.Get(a => a.SESANo == userName);
            if (exist == null)
            {
                return false;
            }
            else
            {
                return false;
            }
        }

        [LogAspect(typeof(DatabaseLogger), Priority = 1)]
        public IDataResult<User> Add(User user)
        {
            _userDal.Add(user);
            return new SuccessDataResult<User>(user, Messages.UserRegistered);
        }

        [LogAspect(typeof(DatabaseLogger), Priority = 1)]
        public IDataResult<User> Update(User user)
        {
            if(user.UserImage==null)
            {
                var userr = _userDal.Get(a => a.Id == user.Id);
                user.UserImage = userr.UserImage;
            }
            _userDal.Update(user);
            return new SuccessDataResult<User>(user, Messages.UserUpdated);
        }


        public User GetByMail(string email)
        {

            return _userDal.Get(u => u.SESANo == email && u.Status == true);
        }

        public User Login(string sesano, string password)
        {
            //_userDal.Login(sesano,password);
            return _userDal.Login(sesano, password);
        }

        public User GetById(int id)
        {
            return _userDal.GetUserWithClaims(id);
        }

        [SecuredOperation("User-Read")]
        public IList<User> GetAllUser()
        {
            var response = _userDal.GetAllUserWithClaims();
            return response;
        }

        public IList<User> GetAll()
        {
            var response = _userDal.GetList(a => a.Status == true);
            return response;
        }
        [LogAspect(typeof(DatabaseLogger), Priority = 1)]
        public void Remove(int userId)
        {
            var user = GetById(userId);
            user.Status = false;
            _userDal.Update(user);
        }
    }
}
