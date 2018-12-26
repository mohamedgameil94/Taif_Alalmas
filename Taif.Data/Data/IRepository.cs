using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taif.Data.Entities;

namespace Taif.Data.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
       
        T Get(object id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        IQueryable<T> Table { get; }
        IEnumerable<T> GetAll();
        void Save();

    }
}
