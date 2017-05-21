using System;
using System.Collections.Generic;

namespace Diplom.Models
{
    /// <summary>
    /// Адреса
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Идентификатор адреса
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Улица
        /// </summary>
        public string Street { get; set; }
        /// <summary>
        /// Дом
        /// </summary>
        public string House { get; set; }
        /// <summary>
        /// Строение
        /// </summary>
        public string Building { get; set; }
        /// <summary>
        /// Квартира
        /// </summary>
        public string Apartment { get; set; }
        /// <summary>
        /// Список проживающих людей
        /// </summary>
        public List<People> People { get; set; }
    }
}
