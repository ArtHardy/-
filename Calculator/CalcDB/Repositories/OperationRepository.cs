using System.Linq;
using CalcDB.Models;

namespace CalcDB.Repositories
{
    public class OperationRepository : BaseRepository<Operation>, IOperationRepository
    {
        public Operation GetOrCreate(string name)
        {
            var oper = ExecQuery($"[Name] = N'{name}'").FirstOrDefault();
            if(oper == null)
            {
                oper = new Operation()
                {
                    Name = name,
                    OwnerId = 1
                };
                Save(oper);
            }
            return oper;
        }
    }
}
