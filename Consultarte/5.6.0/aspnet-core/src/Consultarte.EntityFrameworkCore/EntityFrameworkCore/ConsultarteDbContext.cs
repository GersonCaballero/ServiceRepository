using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Consultarte.Authorization.Roles;
using Consultarte.Authorization.Users;
using Consultarte.MultiTenancy;

namespace Consultarte.EntityFrameworkCore
{
    public class ConsultarteDbContext : AbpZeroDbContext<Tenant, Role, User, ConsultarteDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ConsultarteDbContext(DbContextOptions<ConsultarteDbContext> options)
            : base(options)
        {
        }
    }
}
