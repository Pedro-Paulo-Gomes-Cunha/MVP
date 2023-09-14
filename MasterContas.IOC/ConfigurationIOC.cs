using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterContas.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC
            /*  

            builder.RegisterGeneric(typeof(BaseRepository<>))
               .As(typeof(IRepositoryBase<>))
               .InstancePerLifetimeScope();
            builder.RegisterType<RepositoryWrapper>().As<IRepositoryWrapper>();
            //User
            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();*/

           
            #endregion IOC


        }
    }
}
