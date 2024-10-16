using CashFlow.Domain.Entities;
using CashFlow.Domain.Ropsitories.Expenses;

namespace CashFlow.Infrastructure.DataAccess.Repositories;

internal class ExpensesRepository : IExpensesRepository
{
    public void Add(Expense expense)
    {
        var dbCotext = new CashFlowDbContext();

        dbCotext.Expenses.Add(expense);

        dbCotext.SaveChanges();
    }
}
