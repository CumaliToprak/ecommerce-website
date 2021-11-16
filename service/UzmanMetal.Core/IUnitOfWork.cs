using System.Threading.Tasks;
using UzmanMetal.Core.Repositories;

namespace UzmanMetal.Core
{
    public interface IUnitOfWork
    {
         IUserRepository UserRepository{get;}
         Task<int> CommitAsync();
    }
}