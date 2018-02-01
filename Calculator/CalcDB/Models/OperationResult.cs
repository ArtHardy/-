using CalcDB.Repositories;
using System;
using System.Globalization;

namespace CalcDB.Models
{
    public class OperationResult : IEntity
    {
        public long Id { get; set; }

        public long OperationId { get; set; }

        public string Args { get; set; }

        public double? Result { get; set; }

        /// <summary>
        /// Продолжительность выполнения расчета, мс
        /// </summary>
        public long ExecutionTime { get; set; }

        public DateTime CreationDate { get; set; }

        public string Error { get; set; }

        public long AuthorId { get; set; }
    }
}
