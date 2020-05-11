
using Core.Utilities.Results;
using Core.Utilities.Security.Jwt;
using Weekly.Core.Entities.Concrete;
using Weekly.Entities.Dtos;

namespace Weekly.Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto,string password);
        IDataResult<User> Login(UserForLoginDto userForLoginDto);
        IResult UserExists(string email);
        IDataResult<AccessToken> CreateAccessToken(User user);
    }
}
