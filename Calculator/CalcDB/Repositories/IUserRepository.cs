using CalcDB.Models;

namespace CalcDB.Repositories
{
    public interface IUserRepository
    {
        User GetByLogin(string login);

        bool Check(string login, string password);
    }
}
