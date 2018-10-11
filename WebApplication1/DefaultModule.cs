using Autofac;
using Repository;
using Service;

namespace WebApplication1
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserService>().As<IUserService>();
            #region Repository注册
            builder.RegisterGeneric(typeof(EFRepository<>)).Named("EFRepository", typeof(IRepository<>)).InstancePerLifetimeScope();

            #endregion
        }
    }
}