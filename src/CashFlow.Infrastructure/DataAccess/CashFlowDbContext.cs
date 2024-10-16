using CashFlow.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CashFlow.Infrastructure.DataAccess;

public class CashFlowDbContext : DbContext
{
    public DbSet<Expense> Expenses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //string de conexão com os dados do banco
        //Url do servidor
        //Nome do banco de dados
        //Usuário
        //Senha
        var connectionString = "Server=localhost;Database=cashflowdb;Uid=root;Pwd=root";

        //versão do mySql
        var version = new Version(8, 0, 29);

        //instanciando uma nova versão
        var serverVersion = new MySqlServerVersion(version);

        //usando o mysql passando a string de conexão e a versão do banco
        optionsBuilder.UseMySql(connectionString, serverVersion);
    }
}
