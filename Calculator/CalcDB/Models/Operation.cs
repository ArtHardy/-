using CalcDB.Repositories;
using System;

namespace CalcDB.Models
{
    public class Operation : IEntity
    {
        public virtual long Id { get; set; }

        public virtual string Name { get; set; }

        [Obsolete("Используйте свойство Owner", true)]
        public virtual long OwnerId { get; set; }

        public virtual User Owner { get; set; }
    }
}
