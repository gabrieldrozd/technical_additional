using System.Data.Entity;
using ContractorMng.Data.Entities;

namespace ContractorMng.Data
{
    public class ContractorContext : DbContext
    {
        public DbSet<Contractor> Contractors { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<KindOfAddress> KindOfAddresses { get; set; }

        public ContractorContext() : base("name=ContractorDatabase")
        {
            //Database.SetInitializer<ContractorContext>(new DropCreateDatabaseAlways<ContractorContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
