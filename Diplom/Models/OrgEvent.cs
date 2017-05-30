using System;
using System.Diagnostics;

namespace Diplom.Models
{
    public class Evnt
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }


        public CounterType CounterType { get; set; }

    }

    public class Data
    {
        public Guid Id { get; set; }
        public Guid AddressId { get; set; }
        public CounterType Type { get; set; }
        public decimal CounterData { get; set; }
        public DateTime Date { get; set; }
    }

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
        public long DateTime { get; set; }
        /// <summary>
        /// Идентификатор исполнителя
        /// </summary>
        public Guid ImplementerId { get; set; }
        /// <summary>
        /// Тип события
        /// </summary>
        public EventType EventType { get; set; }
        /// <summary>
        /// Показания
        /// </summary>
        public decimal Count { get; set; }
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
        VERIFICATION = 1,
        REVISION = 2,
        DISASSEMBLY = 3
    }
}
