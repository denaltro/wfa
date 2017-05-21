using System;

namespace Diplom.Models
{
    /// <summary>
    /// Исполнитель
    /// </summary>
    public class Implementer
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Имя контакта
        /// </summary>
        public string ContactName { get; set; }
        /// <summary>
        /// Контактный телефон
        /// </summary>
        public string Phone { get; set; }
    }
}
