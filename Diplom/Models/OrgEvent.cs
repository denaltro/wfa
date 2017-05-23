using System;
using System.Diagnostics;

namespace Diplom.Models
{
    /// <summary>
    /// Событие
    /// </summary>
    public class OrgEvent
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Адрес
        /// </summary>
        public Guid AddressId { get; set; }
        /// <summary>
        /// Тип счетчика
        /// </summary>
        public CounterType CounterType { get; set; }
        /// <summary>
        /// Место установки
        /// </summary>
        public string Place { get; set; }
        /// <summary>
        /// Дата установки
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Идентификатор исполнителя
        /// </summary>
        public Guid ImplementerId { get; set; }
        /// <summary>
        /// Тип события
        /// </summary>
        public EventType EventType { get; set; }
    }

    public enum CounterType
    {
        COLD = 0,
        HOT = 1,
        ELECTRO = 2
    }

    public enum EventType
    {
        INSTALL = 0,
        REINSTALL = 1,
        VERIFICATION = 2
    }
}
