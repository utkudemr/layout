using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.Jwt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Autofac.Extras.DynamicProxy;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();
            builder.RegisterType<OpportunityManager>().As<IOpportunityService>();
            builder.RegisterType<EfOpportunityDal>().As<IOpportunityDal>();
            builder.RegisterType<EfOpportuniyDetailsDal>().As<IOpportunityDetailDal>();
            builder.RegisterType<EfOpportunityDal>().As<IOpportunityDal>();
            builder.RegisterType<CountryManager>().As<ICountryService>();
            builder.RegisterType<EfCountryDal>().As<ICountryDal>();
            builder.RegisterType<StatusManager>().As<IStatusService>();
            builder.RegisterType<EfStatusDal>().As<IStatusDal>();
            builder.RegisterType<EndUserSegmentService>().As<IEndUserSegmentService>();
            builder.RegisterType<EfEndUserSegmentDal>().As<IEndUserSegmentDal>();
            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();
            builder.RegisterType<ProductTypeManager>().As<IProductTypeService>();
            builder.RegisterType<EfProductTypeDal>().As<IProductTypeDal>();
            builder.RegisterType<OperationClaimManager>().As<IOperationClaimService>();
            builder.RegisterType<EfOperationClaimDal>().As<IOperationClaimDal>();
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();
            builder.RegisterType<EfYesNoDal>().As<IYesNoDal>();
            builder.RegisterType<YesNoManager>().As<IYesNoService>();
            builder.RegisterType<EfGoalsDal>().As<IGoalsDal>();
            builder.RegisterType<GoalsManager>().As<IGoalsService>();
            builder.RegisterType<TaskManager>().As<ITaskService>();
            builder.RegisterType<EfTaskDal>().As<ITaskDal>();
            builder.RegisterType<EfPriorityDal>().As<IPriorityDal>();
            builder.RegisterType<PriorityManager>().As<IPriorityService>();
            builder.RegisterType<EfUserTask>().As<IUserTaskDal>();
            builder.RegisterType<UserTaskManager>().As<IUserTaskService>();
            builder.RegisterType<EfOpportunityLogDal>().As<IOpportunityLogDal>();
            builder.RegisterType<OpportunityLogManager>().As<IOpportunityLogService>();
            builder.RegisterType<EfTaskStatusDal>().As<ITaskStatusDal>();
            builder.RegisterType<TaskStatusManager>().As<ITaskStatusService>();
            builder.RegisterType<EfMailDal>().As<IMailDal>();
            builder.RegisterType<MailManager>().As<IMailService>();
            builder.RegisterType<EfCapacityDall>().As<ICapacityDal>();
            builder.RegisterType<CapacityManager>().As<ICapacityService>();
            builder.RegisterType<EfSlotDal>().As<ISlotDal>();
            builder.RegisterType<SlotManager>().As<ISlotService>();
            builder.RegisterType<EfBookedNumberDal>().As<IBookedNumberDal>();
            builder.RegisterType<BookedNumberManager>().As<IBookedService>();
            builder.RegisterType<EfOrderChangeDal>().As<IOrderChangeDal>();
            builder.RegisterType<OrderChangeManager>().As<IOrderChangeService>();
            builder.RegisterType<EfFrameworkForecastDal>().As<IFrameworkForecastDal>();
            builder.RegisterType<FrameworkForecastManager>().As<IFrameworkForecastService>();
            builder.RegisterType<EfFrameworkForecastSubDal>().As<IFrameworkForecastSubDal>();
            builder.RegisterType<FrameworkForecastSubManager>().As<IFrameworkForecastSubService>();
            builder.RegisterType<EfLostStatusDal>().As<ILostStatusDal>();
            builder.RegisterType<LostStatusManager>().As<ILostStatusService>();
            builder.RegisterType<EfErpDataDal>().As<IErpDataDal>();
            builder.RegisterType<ErpDataManager>().As<IErpDataService>();
            builder.RegisterType<EfLogDal>().As<ILogDal>();
            builder.RegisterType<LogManager>().As<ILogService>();
            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
