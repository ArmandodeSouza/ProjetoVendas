using System.Data.Common;
using Npgsql;

public static class DbConnectionFactory {
    private static readonly string _connectionString =
        "Host=localhost;Port=5432;Database=Projeto_vendas;Username=postgres;Password=1234";

    public static DbConnection Create() {
        return new NpgsqlConnection(_connectionString);
    }
}