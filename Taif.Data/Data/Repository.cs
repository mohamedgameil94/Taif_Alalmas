using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Taif.Data.Entities;

namespace Taif.Data.Data
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        

        private TaifContext _context;
        private IDbSet<T> entities;



        public Repository(TaifContext applicationContext)
        {
            _context = new TaifContext();
            entities = _context.Set<T>();
        }

        public IQueryable<T> Table
        {
            get
            {
                return this.entities;
            }
        }

        public void Add(T entity)
        {
            if (entity == null)
                throw new NullReferenceException("entity");
            entities.Add(entity);       
        }

        public void Update(T entity)
        {
            if (entity == null)
                throw new NullReferenceException("entity");
            _context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
        }

        public void Delete(T entity)
        {
            if (entity == null)
                throw new NullReferenceException("entity");
            entities.Remove(entity);
   
        }

        public T Get(object id)
        {
            return entities.Find(id);
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }



       

    }
}
