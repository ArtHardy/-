using CalcDB.Repositories;
using System;
using System.Globalization;

namespace CalcDB.Models
{
    public class OperationResult : IEntity
    {
        public virtual long Id { get; set; }

        public virtual long OperationId { get; set; }

        public virtual string Args { get; set; }

        public virtual double? Result { get; set; }

        /// <summary>
        /// Продолжительность выполнения расчета, мс
        /// </summary>
        public virtual long ExecutionTime { get; set; }

        public virtual DateTime CreationDate { get; set; }

        public virtual string Error { get; set; }

        public virtual long AuthorId { get; set; }

        public virtual User Author { get; set; }
    }
}
