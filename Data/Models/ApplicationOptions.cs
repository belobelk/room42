using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Interfaces;

namespace Data.Models
{
    /// <summary>
    /// Глобальные настройки игр
    /// </summary>
    public class ApplicationOptions : Entity<Guid>
    {
        /// <summary>
        /// На какой промежуток вперед можно оформить заказ (в днях)
        /// </summary>
        public int DurationInDays { get; set; }

        /// <summary>
        /// Ценовые диапазоны заказа в будни
        /// </summary>
        public List<TimeInterval> WeekdayCostIntervals { get; set; }

        /// <summary>
        /// Ценовые диапазоны заказа в выходные
        /// </summary>
        public List<TimeInterval> WeekendCostIntervals { get; set; } 
    }
}
