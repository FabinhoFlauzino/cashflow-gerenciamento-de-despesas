using CashFlow.Domain.Entities;

namespace CashFlow.Domain.Ropsitories.Expenses;

public interface IExpensesRepository
{
    Task Add(Expense expense);
}
