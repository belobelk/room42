using System;
using System.Data.Entity;
using Data.Models;

namespace Data.EF
{
    public class TestDataContext : DropCreateDatabaseIfModelChanges<DataContext>
    {
        readonly Random _rand = new Random();

        protected override void Seed(DataContext context)
        {
            context.Orders.Add(new Order (DateTime.Now)
            {
                Email = "ivanov@test.ru",
                FIO = "Иванов Иван Иваныч",
                GameDurationInMinutes = 60,
                PhoneNumber = "89109178031"
            });
            context.Orders.Add(new Order(DateTime.Now.AddHours(-1))
            {
                Email = "petrov@test.ru",
                FIO = "Петров Иван Иваныч",
                GameDurationInMinutes = 60,
                PhoneNumber = "86667778899"
            });

            context.Users.Add(new User {UserName = "admin", PasswordSalt = "qwer", PasswordHash = "qwer"});
        }
    }
}
