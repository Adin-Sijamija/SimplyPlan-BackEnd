using SimplyPlan.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplyPlan.Infrastructure.Services
{
    public interface ICrud
    {

        Task<T> GetByIdAsync<T>(int id) where T : BaseEntity;
        Task<List<T>> ListAsync<T>() where T : BaseEntity;
        Task<T> AddAsync<T>(T entity) where T : BaseEntity;
        Task UpdateAsync<T>(T entity) where T : BaseEntity;
        Task DeleteAsync<T>(T entity) where T : BaseEntity;
    }

}

