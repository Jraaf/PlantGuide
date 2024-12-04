﻿namespace DataAccess.Repository.Base;

public interface IRepo<TEntity, in TKEy>
        where TEntity : class
        where TKEy : IEquatable<TKEy>
{
    Task<List<TEntity>> GetAllAsync();
    Task<TEntity?> GetAsync(int id);
    Task<TEntity> AddAsync(TEntity entity);
    Task<bool> AddManyAsync(IEnumerable<TEntity> entities);
    Task<TEntity> UpdateAsync(TEntity entity);
    Task<bool> UpdateManyAsync(IEnumerable<TEntity> entities);
    Task<bool> DeleteAsync(TEntity entity);
    Task<bool> DeleteManyAsync(IEnumerable<TEntity> entities);
    Task<int> SaveChangesAsync();

}