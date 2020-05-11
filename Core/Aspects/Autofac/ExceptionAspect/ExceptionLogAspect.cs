using Castle.DynamicProxy;
using Core.CrossCuttingConcern.Logging;
using Core.CrossCuttingConcerns.Logging;
using Core.CrossCuttingConcerns.Logging.Log4Net;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Microsoft.AspNetCore.Http;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Text;

namespace Core.Aspects.Autofac.ExceptionAspect
{
    public class ExceptionLogAspect:MethodInterception
    {
        private LoggerServiceBase _loggerServiceBase;
        private IHttpContextAccessor _httpContextAccessor;
        public ExceptionLogAspect(Type loggerService)
        {
            if(loggerService.BaseType!=typeof(LoggerServiceBase))
            {
                throw new System.Exception("Wrong Logger Type");
            }
            _loggerServiceBase = (LoggerServiceBase)Activator.CreateInstance(loggerService);
            _httpContextAccessor = ServiceTool.ServiceProvider.GetService<IHttpContextAccessor>();
        }
        protected override void OnException(IInvocation invocation,System.Exception e)
        {
            LogDetailWithException logDetail = GetLogDetail(invocation);
            logDetail.ExceptionMessage = e.Message;
            _loggerServiceBase.Error(logDetail);
        }

        private LogDetailWithException GetLogDetail(IInvocation invocation)
        {
            var logParameters = new List<LogParameter>();
            for (int i = 0; i < invocation.Arguments.Length; i++)
            {
                logParameters.Add(new LogParameter
                {

                    Name = invocation.GetConcreteMethod().GetParameters()[i].Name,
                    //Value = invocation.Arguments[i],
                    Target = invocation.TargetType.Name,
                    Type = invocation.Arguments[i].GetType().Name
                });
            }
            var logDetailException = new LogDetailWithException
            {
                UserName = _httpContextAccessor.HttpContext.User.Identity.Name,
                MethodName = invocation.Method.Name,
                LogParameters = logParameters
            };
            return logDetailException;
        }
    }
}
