using LittleMiddleHospital.Core.Entities;
using LittleMiddleHospital.Core.RepositoryInterfaces;
using LittleMiddleHospital.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace LittleMiddleHospital.DAL.RepositoryImplements;

public class GenericRepository<T>(SqlServer _context) : IGenericRepository<T> where T : BaseEntity, new()
{
    protected DbSet<T> Table = _context.Set<T>();

    public async Task AddAsync(T entity)
        => await Table.AddAsync(entity);

    public async Task DeleteAsync(T entity)
        => Table.Remove(entity);


    public async Task DeleteByIdAsync(int id)
        => DeleteAsync(await GetByIdAsync(id));

    public IQueryable<T> GetAll()
        => Table.AsQueryable();
    public async Task<T?> GetByIdAsync(int id)
        => await Table.FindAsync(id);

    public IQueryable<T> GetWhere(Func<T, bool> expression)
        => Table.Where(expression).AsQueryable();

    public Task<bool> IsExistAsync(int id)
        => Table.AnyAsync(t => t.Id == id);
    public async Task<int> SaveAsync()
        => await _context.SaveChangesAsync();
}
