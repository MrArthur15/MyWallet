using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using MyWallet.Domain.Base;

using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Repository.Context;
using MyWallet.Repository.Repository;
using MyWallet.Service.Service;
using MyWallet.Service.Validators;
using System.Text.Json;

namespace MyWallet.Test
{
    [TestClass]
    public sealed class ServiceTest
    {
        private ServiceCollection services;
        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MyWalletContext>();
            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddSingleton(
                new MapperConfiguration(
                    config => { config.CreateMap<User, User>(); },
                    NullLoggerFactory.Instance).CreateMapper()
                );
            return services.BuildServiceProvider();

        }
        [TestMethod]
        public void TestUserService()
        {
            var serviceProvider = ConfigureServices();
            var _userService = serviceProvider.GetService<IBaseService<User>>();

            var time = DateTime.Now;
            var u = new User
            {
                Name = "Arthur",
                IdentificationDocument = "411.303.268-88",
                Login = "mrarthur",
                Password = "Arthur@15",
                Email = "arthurpires374@gmail.com",
                BirthDate = time,
                RegistrationDate = time,
                LoginDate = time,
                Type = UserType.Individual


            };
            var result = _userService.Add<User, User, UserValidator>(u);
            Console.WriteLine(JsonSerializer.Serialize(result));
        }
    }
}
