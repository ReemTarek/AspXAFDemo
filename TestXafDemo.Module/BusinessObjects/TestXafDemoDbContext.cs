using System;
using System.Data;
using System.Linq;
using System.Data.Entity;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.ComponentModel;
using DevExpress.ExpressApp.EF.Updating;
using DevExpress.Persistent.BaseImpl.EF;
using DevExpress.ExpressApp.Design;
using DevExpress.ExpressApp.EF.DesignTime;
using DevExpress.Persistent.BaseImpl.EF.PermissionPolicy;
using TestXafDemo.Module.BusinessObjects.Marketing;

namespace TestXafDemo.Module.BusinessObjects {
	public class TestXafDemoContextInitializer : DbContextTypesInfoInitializerBase {
		protected override DbContext CreateDbContext() {
			DbContextInfo contextInfo = new DbContextInfo(typeof(TestXafDemoDbContext), new DbProviderInfo(providerInvariantName: "System.Data.SqlClient", providerManifestToken: "2008"));
            return contextInfo.CreateInstance();
		}
	}
	[TypesInfoInitializer(typeof(TestXafDemoContextInitializer))]
	public class TestXafDemoDbContext : DbContext {
		public TestXafDemoDbContext(String connectionString)
			: base(connectionString) {
		}
		public TestXafDemoDbContext(DbConnection connection)
			: base(connection, false) {
		}
		public TestXafDemoDbContext() {
		}
		public DbSet<ModuleInfo> ModulesInfo { get; set; }
		public DbSet<ModelDifference> ModelDifferences { get; set; }
		public DbSet<ModelDifferenceAspect> ModelDifferenceAspects { get; set; }
		
	}
}