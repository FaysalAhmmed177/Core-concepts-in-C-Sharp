using Practise.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise.Infrastructure
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        List<TEntity> GetAll();
        void Insert(TEntity entity);
    }
}
