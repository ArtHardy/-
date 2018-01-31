using System.Collections.Generic;
using CalcDB.Models;

namespace CalcDB.Repositories
{
    public class OperResultRepository : BaseRepository<OperationResult>, IOperResultRepository
    {
        public IEnumerable<OperationResult> GetByOperation(long Id)
        {
            return null;
        }
    }
}
