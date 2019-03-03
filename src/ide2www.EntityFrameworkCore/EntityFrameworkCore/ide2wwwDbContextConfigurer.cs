using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ide2www.EntityFrameworkCore
{
    public static class ide2wwwDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ide2wwwDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ide2wwwDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
