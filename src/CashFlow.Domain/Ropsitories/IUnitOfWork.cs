namespace CashFlow.Domain.Ropsitories;

public interface IUnitOfWork
{
    Task Commit();
}
