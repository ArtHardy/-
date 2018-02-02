﻿using CalcDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcDB.Models
{
    public enum UserStatus
    {
        Active = 1,
        Blocked = 2,
        Deleted = 3,
        System = 4
    }

    public class User : IEntity
    {
        #region IEntity

        public virtual long Id { get; set; }

        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual string Email { get; set; }

        public virtual string Login { get; set; }

        public virtual string Password { get; set; }

        public virtual UserStatus Status { get; set; }

        public virtual Role Role { get; set; }

        #endregion
    }
}
