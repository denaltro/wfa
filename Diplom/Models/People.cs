using System;

namespace Diplom.Models
{
    /// <summary>
    /// Житель
    /// </summary>
    public class People
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// Имя
        /// </summary>
        public string FirstName { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string SurName { get; set; }
        /// <summary>
        /// Телефон
        /// </summary>
        public string Phone { get; set; }
    }
}
