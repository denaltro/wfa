using System;
using System.Collections.Generic;

namespace Diplom.Models
{
    /// <summary>
    /// Контролеры
    /// </summary>
   public class Controller
    {
        /// <summary>
        /// Идентификатор контролера
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Фамилия, Имя и очество контролера
        /// </summary>
        public string FIO { get; set; }
        public List<Houses> Houses { get; set; }

    }

    public class Houses
    {
        public string Street { get; set; }
        public string House { get; set; }
    }
}