using CalcDB.Models;

namespace CalcDB.Repositories
{
    public interface IOperationRepository : IRepository<Operation>
    {
        Operation GetOrCreate(string name);
    }
}
