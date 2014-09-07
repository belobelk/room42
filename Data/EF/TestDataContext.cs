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
                GameDuration = 60,
                PhoneNumber = "89109178031"
            });
            context.Orders.Add(new Order(DateTime.Now.AddHours(-1))
            {
                Email = "petrov@test.ru",
                FIO = "Петров Иван Иваныч",
                GameDuration = 60,
                PhoneNumber = "86667778899"
            });
            context.Users.Add(new User { UserName = "admin", PasswordSalt = "11223344", PasswordHash = "11223344AFCB20BA365EDF0370DF069C22A9B819C431C42F2587E3650FF59568195E51FC" });
        }
    }
}
