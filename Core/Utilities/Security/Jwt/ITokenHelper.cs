using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Core.Entities.Concrete;

namespace Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
       //AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
        IEnumerable<Claim> SetClaims(User user, List<string> operationClaims);
    }
}
