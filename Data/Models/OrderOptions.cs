using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;

namespace Data.Models
{
    /// <summary>
    /// Опции распределения заказов
    /// </summary>
    public class OrderOptions : Entity<Guid>
    {
        /// <summary>
        /// Настройки действуют только на выбранную дату
        /// </summary>
        public DateTime? Date { get; set; }

        /// <summary>
        /// Самое раннее время заказа
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Самое позднее время заказа
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Время игры в минутах
        /// </summary>
        public int GameDuration { get; set; }

        /// <summary>
        /// Время пересментки между играми
        /// </summary>
        public int GameInterval { get; set; }

        /// <summary>
        /// Перерывы на обед, сон и т.д.
        /// </summary>
        public List<TimeInterval> GameBreaks { get; set; }

        /// <summary>
        /// Настройки являются действующими
        /// </summary>
        public bool IsActive { get; set; }
        
        /// <summary>
        /// Настройки выходного дня
        /// </summary>
        public bool IsHolidayDay { get; set; }
    }
}
