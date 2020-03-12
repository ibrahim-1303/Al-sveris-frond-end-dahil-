using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using MvC5.EntityFramework;

namespace MvC5.Migrator
{
    [DependsOn(typeof(MvC5DataModule))]
    public class MvC5MigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<MvC5DbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}