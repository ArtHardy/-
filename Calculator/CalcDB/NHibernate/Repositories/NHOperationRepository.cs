using CalcDB.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcDB.Models;
using NHibernate.Criterion;

namespace CalcDB.NHibernate.Repositories
{
    public class NHOperationRepository : NHBaseRepository<Operation>, IOperationRepository
    {
        public Operation GetOrCreate(string name)
        {
            using (var session = Helper.OpenSession())
            {
                var operation = session.QueryOver<Operation>()
                    .And(it => it.Name == name)
                    .SingleOrDefault();

                if (operation != null)
                    return operation;

                operation = new Operation()
                {
                    Name = name,
                    Owner = NHUserRepository.AdminUser()
                };
                Save(operation);

                return operation;
            }
        }
    }
}
