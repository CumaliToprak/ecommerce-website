using System.Threading.Tasks;
using UzmanMetal.Core.Repositories;

namespace UzmanMetal.Core
{
    public interface IUnitOfWork
    {
         Task<int> CommitAsync();
    }
}