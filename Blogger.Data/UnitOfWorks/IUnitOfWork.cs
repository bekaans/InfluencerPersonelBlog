using Blog.Entity.Entities;
using Blogger.Core.Entities;
using Blogger.Data.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogger.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T> () where T : class,IEntityBase,new();

        Task<int> SaveAsync();
        int Save();
    }
}
