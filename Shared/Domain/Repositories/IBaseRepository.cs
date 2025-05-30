namespace challenge9.Shared.Domain;

public interface IBaseRepository<T>{
    Task AddAsync(T entity);
    Task<T?> FindByIdAsync(int id);

    void Update(T entity);

    void Remove(T entity);

    Task<IEnumerable<T>> GetAllAsync();
}