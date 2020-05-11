
using Weekly.Business.Concrete;
using Weekly.Business.Abstract;
using Autofac;
using DataAccess.Concrete.EntityFramework;
using Weekly.DataAccess.Abstract;

namespace Weekly.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

        }
    }
}
