using System;
using System.Data;
using System.ComponentModel.DataAnnotations.Schema;
using Infrastructure.Interfaces;

namespace Data.Models
{
    public class User : Entity<Guid>
    {
      // [Index("UserNameIndex", IsUnique = true)]
        public string UserName { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }
    }
}
