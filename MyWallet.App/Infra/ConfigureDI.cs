using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using Microsoft.VisualBasic.Logging;
using MyWallet.Domain.Base;
using MyWallet.Domain.Entities;
using MyWallet.Repository.Context;
using MyWallet.Repository.Repository;
using MyWallet.Service.Service;
using System;
using System.Collections.Generic;
using System.Net.ServerSentEvents;
using System.Text;

namespace MyWallet.App.Infra
{
    public class ConfigureDI
    {

        public static ServiceCollection services;
        public static IServiceProvider? serviceProvider;
        public static void ConfigureServices()
        {
            // data base config
            var dbConfigFile = "Config/DBCOnfig.txt";
            var strCon = File.ReadAllText(dbConfigFile);
            services = new ServiceCollection();
            services.AddDbContext<MyWalletContext>(
                options =>
                {
                    options.LogTo(Console.WriteLine);
                    options.UseMySQL(strCon);
                }
            );
            #region Repositories
            services.AddScoped<IBaseRepository<Account>, BaseRepository<Account>>();
            services.AddScoped<IBaseRepository<Bank>, BaseRepository<Bank>>();
            services.AddScoped<IBaseRepository<Category>, BaseRepository<Category>>();
            services.AddScoped<IBaseRepository<Subscription>, BaseRepository<Subscription>>();
            services.AddScoped<IBaseRepository<Transaction>, BaseRepository<Transaction>>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            #endregion

            #region Services
            services.AddScoped<IBaseService<Account>, BaseService<Account>>();
            services.AddScoped<IBaseService<Bank>, BaseService<Bank>>();
            services.AddScoped<IBaseService<Category>, BaseService<Category>>();
            services.AddScoped<IBaseService<Subscription>, BaseService<Subscription>>();
            services.AddScoped<IBaseService<Transaction>, BaseService<Transaction>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            #endregion

            #region Forms
            //services.AddTransient<Login, Login>();
            //services.AddTransient<CategoryForm, CategoryForm>();
            
            #endregion

            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        //config.CreateMap<User, UserViewModel>();
                        
                    },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            serviceProvider = services.BuildServiceProvider();

        }
    }
}
