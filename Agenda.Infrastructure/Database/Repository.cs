using Agenda.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Agenda.Infrastructure.Database
{
    public class Repository<T> : IRepository<T> where T : class
    {
        Task IRepository<T>.AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        Task<bool> IRepository<T>.AnyAsync(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task<ICollection<T>> IRepository<T>.GetAllAsync()
        {
            throw new NotImplementedException();
        }

        Task<T> IRepository<T>.GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        Task IRepository<T>.UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
