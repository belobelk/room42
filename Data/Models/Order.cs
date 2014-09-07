using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;

namespace Data.Models
{
    /// <summary>
    /// Заказанная игра
    /// </summary>
    public class Order : Entity<Guid>
    {
        /// <summary>
        /// Дата и время игры
        /// </summary>
        public DateTime GameStartDateTime { get; protected set; }

        /// <summary>
        /// Время игры в минутах
        /// </summary>
        public int GameDuration { get; set; }

        /// <summary>
        /// Почтовый ящик заказчика
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Телефон заказчика
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Имя заказчика
        /// </summary>
        public string FIO { get; set; }

        protected override string GenerateKey ()
        {
            return GameStartDateTime.ToString("yyMMddThhmm");
        }

        protected Order() { }

        public Order(DateTime gameStartDateTime)
        {
            GameStartDateTime = gameStartDateTime;
        }
    }
}
