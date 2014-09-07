using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Interfaces
{
    public interface IEntity
    {
        /// <summary>
        /// Открыты идентификатор, который виден в вебе
        /// </summary>
        string Key { get;}
    }
}
