using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using MvC5.Authorization.Roles;
using MvC5.Authorization.Users;
using MvC5.MultiTenancy;

namespace MvC5.EntityFramework
{
    public class MvC5DbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public MvC5DbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in MvC5DataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of MvC5DbContext since ABP automatically handles it.
         */
        public MvC5DbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public MvC5DbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public MvC5DbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
