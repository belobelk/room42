using System;
using Infrastructure.Interfaces;

namespace Data.Models
{
    /// <summary>
    /// Промежутки времени
    /// </summary>
    public class TimeInterval : Entity<Guid>
    {
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public Decimal Cost { get; set; }
    }
}
