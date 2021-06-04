﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Domain.Entities;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories
{
    public interface IRepositoryAsync<T> where T : class, IEntity
    {
        IQueryable<T> Entities { get; }

        Task<T> GetByIdAsync(int id);

        Task<List<T>> GetAllAsync();

        Task<List<T>> GetPagedReponseAsync(int pageNumber, int pageSize);

        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);
    }
}