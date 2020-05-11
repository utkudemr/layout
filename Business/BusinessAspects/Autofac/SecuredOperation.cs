using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Business.Constants;
using Castle.DynamicProxy;
using Core.Extensions;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace Business.BusinessAspects.Autofac
{
    public class SecuredOperation:MethodInterception
    {
        private string[] _roles;
        private IHttpContextAccessor _httpContextAccessor;
        

        public SecuredOperation(string roles)
        {
            _roles = roles.Split(',');
            _httpContextAccessor =  ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }

        protected override void OnBefore(IInvocation invocation)
        {
            WeeklyContext context = new WeeklyContext();
            // Thread.CurrentPrincipal return claimsPrincipal?.Claims(ClaimTypes.Role);
            var roleClaim1212s = _httpContextAccessor.HttpContext.User.ClaimRoles();
            var roleClaims = _httpContextAccessor.HttpContext.User.Identities.FirstOrDefault(a=>a.Claims.Count()!=0).Claims;
            if (roleClaims.Count()==0)
            {
                throw new Exception(Messages.UserNotFound);
            }



            var strRoleList = new List<string>();
            foreach (var item in roleClaims)
            {
                strRoleList.Add(item.Value);
            }
            string[] getas = strRoleList.ToArray();
            //var result = context.ClaimArea.Where(a => a.OperationClaimId == opId).Select(a => a.Area.Name).ToList();

             foreach (var role in _roles)
              {
                  if (getas.Contains(role))
                  {
                      return;
                  }
              }
            throw new Exception(Messages.AuthorizationDenied);
        }
    }
}
