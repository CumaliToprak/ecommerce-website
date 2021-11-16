using System.Threading.Tasks;
using UzmanMetal.Core;
using UzmanMetal.Core.Repositories;

namespace UzmanMetal.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public UnitOfWork(DataContext context)
        {
            this._context = context;
        }
        public Task<int> CommitAsync()
        {
            throw new System.NotImplementedException();
        }


        public void Dispose()
        {
            _context.Dispose();
        }

    }
}