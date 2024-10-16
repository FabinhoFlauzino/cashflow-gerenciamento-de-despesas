using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Ropsitories.Expenses;

public interface IExpensesRepository
{
    public void Add(Expense expense);
}
