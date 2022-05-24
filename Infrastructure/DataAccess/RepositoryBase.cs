using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Infrastructure.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.WebRequestMethods;

namespace Infrastructure.DataAccess
{

    public class RepositoryBase<TEntity, TContext>
        where TEntity : BaseEntity, new()
        where TContext : DbContext, new()
    {
        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null,
            params string[] includeList)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
                if (includeList.Length > 0)
                {
                    foreach (string item in includeList)
                    {
                        dbSet = dbSet.Include(item);
                    }

                }

                if (filter != null)
                    return dbSet.Where(filter).ToList();
                else
                    return dbSet.ToList();
            }

        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter,
            params string[] includeList)
        {
            using (TContext ctx = new TContext())
            {
                IQueryable<TEntity> dbSet = ctx.Set<TEntity>();
                if (includeList.Length > 0)
                {
                    foreach (string item in includeList)
                    {
                        dbSet = dbSet.Include(item);
                    }

                }

                return dbSet.SingleOrDefault(filter);
            }
        }






        public TEntity GetByID(
            int Id,
            params string[] includeList) => Get(x => x.Id == Id, includeList);



        public void Add(TEntity entity)
        {
            try
            {
                using (TContext ctx = new TContext())
                {
                    var obj = ctx.Entry(entity);
                    obj.State = EntityState.Added;

                    ctx.SaveChanges();
                }
            }
            catch (Exception ex)

            {

            }
            



        }
       
	
       
        public void delete(TEntity entity)
        {
            
            using (TContext ctx = new TContext())
            {
                var obj = ctx.Entry(entity);
                obj.State = EntityState.Deleted;

                ctx.SaveChanges();

            }

           

        }

        public void Delete(int Id)
            {
            TEntity entity = GetByID(Id);

            if (entity != null)
                Delete(entity);
       }

        private void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            using (TContext ctx = new TContext())
            {

                var obj = ctx.Entry(entity);
                obj.State = EntityState.Modified;

                ctx.SaveChanges();

        }   }
    }
}
