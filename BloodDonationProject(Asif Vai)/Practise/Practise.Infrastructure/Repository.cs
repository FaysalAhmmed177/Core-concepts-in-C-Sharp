using Practise.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.Infrastructure
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDbContext context;

        public Repository(AppDbContext context)
        {
            this.context = context;
        }
        public List<TEntity> GetAll()
        {
            var entitylist = context.Set<TEntity>().ToList();
            return entitylist;

        }

        public void Insert(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            context.SaveChanges();
        }
    }
}
