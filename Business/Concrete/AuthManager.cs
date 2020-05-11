using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.Hashing;
using Core.Utilities.Security.Jwt;
using Microsoft.AspNetCore.Http;
using Weekly.Entities.Dtos;
using Core.Extensions;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class AuthManager:IAuthService
    {
        private IUserService _userService;
        private IUserDal _userdal;
        private ITokenHelper _tokenHelper;

        public AuthManager(IUserService userService, IUserDal userdal, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _userdal = userdal;
            _tokenHelper = tokenHelper;
        }

     

        public IDataResult<User> Login(UserForLoginDto userForLoginDto)
        {
            var userToCheck = _userService.Login(userForLoginDto.Name,userForLoginDto.Password);
            if (userToCheck==null)
            {
                return new ErrorDataResult<User>(Messages.UserNotFound);
            }

            var claims = new List<Claim>();
            var claim1s = new List<OperationClaim>();
            claims.AddName(userForLoginDto.Name);
            
           
            var asdsad = _userService.GetClaims(userToCheck.OperationClaimId);
            claims.AddSubRoles(asdsad);
            var sadsadqwe = _tokenHelper.SetClaims(userToCheck,asdsad);
          
            
            return new SuccessDataResult<User>(userToCheck,Messages.SuccessfulLogin);
        }

        public IResult UserExists(string email)
        {
            if (_userService.GetByMail(email)!=null)
            {
                return new ErrorResult(Messages.UserAlreadyExists);
            }
            return new SuccessResult();
        }

       
    }
}
