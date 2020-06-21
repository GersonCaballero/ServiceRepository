using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Consultarte.EntityFrameworkCore
{
    public static class ConsultarteDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ConsultarteDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ConsultarteDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
