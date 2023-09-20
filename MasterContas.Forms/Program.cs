using Autofac;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using MasterContas.Data.Repositories;
using MasterContas.IOC;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MasterContas.Presentation
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        ///  
        /// </summary
        ///ModuleIOC iniciar_ = new ModuleIOC();
        
        public static Autofac.IContainer Container { get; private set; }
        [STAThread]
        static void Main()
        {
           
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();


           IUserService d = new UserService(new RepositoryWrapper());

             var All_=new ServiceCollection();
             All_.AddTransient<Form1>();
            //  All_.AddSingleton;
            SetupContainer();
            /* All_.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
              All_.AddScoped<IUserService,UserService>();*/


            using ServiceProvider servicePro=All_.BuildServiceProvider();
            ///var Tela= servicePro.GetRequiredService<Form1>();
            Application.Run( new Form1(d)) ;

            //factory  ou abtractFactory      Observer, interactor

        }

        public static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterModule(new ModuleIOC());
        }

        private static Autofac.IContainer SetupContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterModule(new ModuleIOC());
           // builder.RegisterModule(new ConfigurationSettingsReader("autofac"));

            return builder.Build();
        }



    }
}