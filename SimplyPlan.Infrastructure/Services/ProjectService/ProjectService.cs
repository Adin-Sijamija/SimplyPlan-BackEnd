using SimplyPlan.Core;
using SimplyPlan.Infrastructure.EF;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SimplyPlan.Infrastructure.Services.ProjectService
{
    public class ProjectService : IProjectService
    {

        private readonly SimplyPlanContext db;



        public Task<T> AddAsync<T>(T entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync<T>(T entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync<T>(int id) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task<List<T>> ListAsync<T>() where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync<T>(T entity) where T : BaseEntity
        {
            throw new NotImplementedException();
        }
    }
}
