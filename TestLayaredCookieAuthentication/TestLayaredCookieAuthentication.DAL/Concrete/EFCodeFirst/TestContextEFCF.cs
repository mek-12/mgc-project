using Microsoft.EntityFrameworkCore;
using TestLayaredCookieAuthentication.ENTITIES.CategoryM;
using TestLayaredCookieAuthentication.ENTITIES.CustomerM;
using TestLayaredCookieAuthentication.ENTITIES.Identity;
using TestLayaredCookieAuthentication.ENTITIES.InvoiceWaybillM;
using TestLayaredCookieAuthentication.ENTITIES.OrderM;
using TestLayaredCookieAuthentication.ENTITIES.Place;
using TestLayaredCookieAuthentication.ENTITIES.ProductM;
using TestLayaredCookieAuthentication.ENTITIES.Tax;
using TestLayaredCookieAuthentication.ENTITIES.TradeM;
using TestLayaredCookieAuthentication.ENTITIES.WareHouseM;

namespace TestLayaredCookieAuthentication.DAL.Concrete.EFCodeFirst
{
    public class TestContextEFCF : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=DESKTOP-UT30727;Database=TestLayeredAuthDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Identity
            builder.Entity<UserRole>()
                .HasKey(o => new { o.UserId, o.RoleId });

            builder.Entity<ApplicationUser>()
                .HasIndex(o => new { o.UserName})
                .IsUnique();
            builder.Entity<ApplicationUser>()
                .HasKey(o => o.Id)
                .ForSqlServerIsClustered();

            //OrderDetail
            builder.Entity<OrderDetail>()
                .HasKey(o => new { o.OrderId, o.ProductId });

            //TCompanyPartner
            builder.Entity<TCompanyPartners>()
                .HasKey(o => new { o.TradeCompanyId, o.ApplicationUserId });

            //Product

            builder.Entity<Product>()
                .HasKey(o => o.Id)
                .ForSqlServerIsClustered();
            builder.Entity<Product>()
                .HasIndex(o => o.StCode)
                .IsUnique();

            //Invoices

            builder.Entity<Invoice>()
                .HasKey(o => o.Id)
                .ForSqlServerIsClustered(false);
            builder.Entity<Invoice>()
                .HasIndex(o => o.TradeCompanyId)
                .ForSqlServerIsClustered();

            ////Waybill
            //builder.Entity<Waybill>()
            //    .HasIndex(o => o.TradeCompanyId)
            //    .ForSqlServerIsClustered();

            ////StockIput & StockOut

            //builder.Entity<StockInput>()
            //    .HasIndex(o => o.TradeCompanyId)
            //    .ForSqlServerIsClustered();

            //builder.Entity<StockOut>()
            //    .HasIndex(o => o.TradeCompanyId)
            //    .ForSqlServerIsClustered();

            ////Warehouse
            //builder.Entity<Warehouse>()
            //    .HasIndex(o => o.TradeCompanyId)
            //    .ForSqlServerIsClustered();
        }

        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        //Place

        public DbSet<Country> Countries { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<District> Districts { get; set; }

        //Customer

        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerInvoiceAddress> CustomerInvoiceAddresses { get; set; }
        public DbSet<CustomerDeliveryAddress> CustomerDeliveryAddresses { get; set; }

        //Tax
        public DbSet<TaxDepartment> TaxDepartments { get; set; }

        //TradeCompany
        public DbSet<TradeCompany> TradeCompanies { get; set; }
        public DbSet<TCompanyPartners> TCompanyPartners { get; set; }

        //Product
        public DbSet<Product> Products { get; set; }
        public DbSet<StockInput> StockInputs { get; set; }
        public DbSet<StockOut> StockOuts { get; set; }

        //Product Category

        public DbSet<Category> Categories { get; set; }
        public DbSet<MainCategory> MainCategories { get; set; }
        public DbSet<MiddleCategory> MiddleCategories { get; set; }

        //Order

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //Invoice & Waybill

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Waybill> Waybills { get; set; }

        //Warehouse
        public DbSet<Warehouse> Warehouses { get; set; }
    }
}
