using System.Linq;
using MvC5.EntityFramework;
using MvC5.MultiTenancy;

namespace MvC5.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly MvC5DbContext _context;

        public DefaultTenantCreator(MvC5DbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
