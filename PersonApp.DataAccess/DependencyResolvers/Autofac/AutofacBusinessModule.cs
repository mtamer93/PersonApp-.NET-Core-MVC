using Autofac;
using AutoMapper;
using PersonApp.DataAccess.AutoMapper;
using PersonApp.DataAccess.Services.Concrete;
using PersonApp.DataAccess.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.DataAccess.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PersonRepository>().As<IPersonRepository>().InstancePerLifetimeScope();

            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new Mapping());
            });

            var mapper = mapperConfig.CreateMapper();
            builder.RegisterInstance<IMapper>(mapper);
        }
    }
}
