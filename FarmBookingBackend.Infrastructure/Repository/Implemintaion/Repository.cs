using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using FarmBookingBackend.Infrastructure.Data;
using FarmBookingBackend.Infrastructure.Repository.Interface;

namespace FarmBookingBackend.Infrastructure.Repository.Implemintaion
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(ApplicationDbContext db)
        {
            _db = db;
            dbSet = _db.Set<T>();
        }

        public T Add(T entity)
        {
           return dbSet.Add(entity).Entity;
        }

        public bool Any(Expression<Func<T, bool>> filter)
        {
            return dbSet.Any(filter);
        }

        public T? Get(Expression<Func<T, bool>> filter, string? includeProperties = null, bool tracked = false)
        {
            IQueryable<T>? query = tracked ? dbSet.Where(filter) : dbSet.AsNoTracking().Where(filter);
            
            if (!string.IsNullOrEmpty(includeProperties) && query is not null)
            {
                //Farm,FarmNumber -- case sensitive
                foreach (var includeProp in includeProperties
                    .Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }
            return query?.FirstOrDefault();
        }

        public IEnumerable<T> GetAll(Expression<Func<T, bool>>? filter = null, string? includeProperties = null, bool tracked = false)
        {
            // Initialize the query
            IQueryable<T> query = tracked ? dbSet : dbSet.AsNoTracking();

            // Apply filtering if a filter is provided
            if (filter != null)
            {
                query = query.Where(filter);
            }

            // Apply include properties for navigation properties
            if (!string.IsNullOrEmpty(includeProperties))
            {
                foreach (var includeProp in includeProperties.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeProp.Trim());
                }
            }

            // Return the list of entities (query will not be null)
            return query.ToList();
        }


        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }
    }
}
