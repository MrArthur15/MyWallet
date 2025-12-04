using Microsoft.EntityFrameworkCore;
using MyWallet.Domain.Entities;
using MyWallet.Domain.Enum;
using MyWallet.Repository.Context;
using MyWallet.Repository.Repository;
using System.Text.Json;

namespace MyWallet.Test
{
    [TestClass]
    public sealed class RepositoryTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var op = new DbContextOptionsBuilder<MyWalletContext>();
            op.UseMySQL("server=localhost;database=MyWallet2025;user=root;password=");

            using (var context = new MyWalletContext(op.Options))
            {
                Console.WriteLine("Connected!");
                var time = DateTime.Now;
                var u = new User
                {
                    Name = "Arthur",
                    Login = "mrarthur",
                    Password = "12345",
                    Email = "arthurpires374@gmail.com",
                    BirthDate = time,
                    RegistrationDate = time,
                    LoginDate = time,
                    Type = UserType.Individual


                };
                
                context.Users.Add(u);

                context.SaveChanges();
                Console.WriteLine("Inser done!");
         
                foreach (var cat in context.Users)
                {
                    Console.WriteLine(JsonSerializer.Serialize(cat));

                }
                Console.WriteLine("List Done!");
            }
        }
    }
}
