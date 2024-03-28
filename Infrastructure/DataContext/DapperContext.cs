using Npgsql;

namespace Infrastructure.DataContext;

public class DapperContext
{
    private readonly string _connectionString=
        "Host=localhost;Port=5432;Database=dapper_db;User Id=postgres;Password=123456;";

    public NpgsqlConnection Connection()
    {
        return new NpgsqlConnection(_connectionString);
    }
 
}