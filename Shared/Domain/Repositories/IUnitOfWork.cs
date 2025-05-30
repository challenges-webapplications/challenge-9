namespace challenge9.Shared.Domain;

public interface IUnitOfWork
{
    Task CompleteAsync();
}