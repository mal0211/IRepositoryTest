using Autofac;
using Repository;
using Service;

namespace WebApplication1
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            #region Repository注册
            //builder.RegisterGeneric(typeof(EFRepository<>)).Named("EFRepository", typeof(IRepository<>)).InstancePerLifetimeScope(); 这种named方式不知道为什么会报错，改为下面这种
            builder.RegisterGeneric(typeof(EFRepository<>)).As(typeof(IRepository<>)).InstancePerLifetimeScope();

            #endregion

            //批量注入Service层的类

            builder.RegisterAssemblyTypes(typeof(UserService).Assembly)

                .Where(t => t.Name.EndsWith("Service"))

                .AsImplementedInterfaces();
        }
    }
}