using Immobiles.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Immobiles.Domain.Interface
{
    public interface IRepository<T> : IDisposable where T : Entity   
    {
        
        Task Add(T entity);
        Task<T> GetById(Guid id);
        Task<List<T>> GetAll();
        Task Update(T entity);
        Task Remove(Guid id);
        Task<int> SaveChanges();
    }
}
