using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;

namespace Data.Models
{
    public class Order : Entity<Guid>
    {
        public virtual DateTime GameStartDateTime { get; protected set; }

        public virtual int GameDurationInMinutes { get; set; }

        public virtual string Email { get; set; }

        public virtual string PhoneNumber { get; set; }

        public virtual string FIO { get; set; }

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
