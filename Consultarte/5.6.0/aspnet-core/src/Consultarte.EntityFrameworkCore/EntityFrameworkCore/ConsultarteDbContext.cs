using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Consultarte.Authorization.Roles;
using Consultarte.Authorization.Users;
using Consultarte.MultiTenancy;
using Consultarte.Features.FinalUsers;
using Consultarte.Features.PaymentTypes;
using Consultarte.Features.TypeServices;
using Consultarte.Features.ServiceProviderUsers;
using Consultarte.Features.Services;

namespace Consultarte.EntityFrameworkCore
{
    public class ConsultarteDbContext : AbpZeroDbContext<Tenant, Role, User, ConsultarteDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<FinalUser> FinalUsers { get; set; }
        public DbSet<TypeService> TypeServices { get; set; }
        public DbSet<ServiceProviderUser> ServiceProviderUsers { get; set; }
        public DbSet<PaymentType> PaymentTypes { get; set; }
        public DbSet<Service> Services { get; set; }

        public ConsultarteDbContext(DbContextOptions<ConsultarteDbContext> options)
            : base(options)
        {
        }
    }
}
