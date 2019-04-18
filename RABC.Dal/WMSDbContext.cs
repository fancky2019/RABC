using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace RABC.Dal
{
    //在nuget 在线中安装EntityFramework
    //.net core 在nuget 在线中安装 EntityFrameworkCore
    public class RABCDbContext : DbContext
    {
        static RABCDbContext()
        {

        }
        public RABCDbContext() : base("name=RABCConnectionString")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();//移除复数表名的契约

            ////数据库与实体映射--可以不设置
            //modelBuilder.Entity<Stock>().ToTable("Stock", "dbo");
            //modelBuilder.Entity<Sku>().ToTable("Sku", "dbo");
            //modelBuilder.Entity<BarCode>().ToTable("BarCode", "dbo");
            //modelBuilder.Entity<Product>().ToTable("Product", "dbo");
            ////联合主键
            //modelBuilder.Entity<PersonJob>().HasKey(t => new { t.PersonID, t.JobID }).ToTable("PersonJob", "dbo");
            //modelBuilder.Entity<Spouse>().ToTable("Spouse", "dbo");
        }

        //public virtual DbSet<Sku> Sku { get; set; }
        //public virtual DbSet<Stock> Stock { get; set; }
        //public virtual DbSet<Product> Product { get; set; }
        //public virtual DbSet<BarCode> BarCode { get; set; }
        //public virtual DbSet<InOutStockDetail> InOutStockDetail { get; set; }
        //public virtual DbSet<InOutStock> InOutStock { get; set; }
        //public virtual DbSet<Sku> Sku { get; set; }
    }
}
