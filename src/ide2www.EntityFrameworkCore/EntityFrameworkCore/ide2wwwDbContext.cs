using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ide2www.Authorization.Roles;
using ide2www.Authorization.Users;
using ide2www.MultiTenancy;

namespace ide2www.EntityFrameworkCore
{
    public class ide2wwwDbContext : AbpZeroDbContext<Tenant, Role, User, ide2wwwDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ide2wwwDbContext(DbContextOptions<ide2wwwDbContext> options)
            : base(options)
        {
        }
    }
}
