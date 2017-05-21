using System;
using System.Diagnostics;

namespace Diplom.Models
{
    /// <summary>
    /// 
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
        public Guid Address { get; set; }
        /// <summary>
        /// Тип счетчика
        /// </summary>
        public CounterType Type { get; set; }
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
