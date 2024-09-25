using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FarmBookingBackend.Infrastructure.Repository.Interface
{
    public interface IRepository<T> where T:class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false);
        T? Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false);
        T Add(T entity);
        bool Any(Expression<Func<T, bool>> filter);
        void Remove(T Entity);   
    }
}
