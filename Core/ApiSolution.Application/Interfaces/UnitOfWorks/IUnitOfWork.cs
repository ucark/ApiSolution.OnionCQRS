﻿

using ApiSolution.Application.Interfaces.Repositories;
using ApiSolution.Domain.Common;

namespace ApiSolution.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork :IAsyncDisposable
    {
        IReadRepository<T> GetReadRepository<T>() where T : class, IEntityBase, new();
        IWriteRepository<T> GetWriteRepository<T>() where T : class, IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
