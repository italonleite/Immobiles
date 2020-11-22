using Immobiles.Data.Context;
using Immobiles.Domain.Interface;
using Immobiles.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Immobiles.Data.Repository
{
    
    public abstract class Repository<T> : IRepository<T> where T : Entity, new()
    {
        //acesso ao context
        //protect - tanto o repository ou quem herdar de repository terá acesso ao Db
        protected readonly MyDbContext Db;
        protected readonly DbSet<T> DbSet;

        
        public Repository(MyDbContext db)
        {
            Db = db;
            DbSet = db.Set<T>();
        }
        public virtual async Task<List<T>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        //virtual para sobrescrever o método quando for preciso
        public virtual async Task<T> GetById(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task Remove(Guid id)
        {
            //DbSet.Remove(await DbSet.FindAsync(id));
            //importancia de todas herdar de entity
            DbSet.Remove(new T { Id = id});
            await SaveChanges();
        }
        
        public virtual Task Add(T entity)
        {
            throw new NotImplementedException();
        }
        public virtual async Task Update(T entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }
        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            /*? - se estiver faça, se não, não faça. Evitar null reference exception*/
            Db?.Dispose();
        }
    }
}
