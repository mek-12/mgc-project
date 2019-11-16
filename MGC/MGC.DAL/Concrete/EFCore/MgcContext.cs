using MGC.ENTITY.Identity;
using MGC.ENTITY.MCategory;
using MGC.ENTITY.MPlace;
using MGC.ENTITY.MProducts.MComputer;
using MGC.ENTITY.MProducts.MDataStorage;
using MGC.ENTITY.MProducts.MPhone;
using MGC.ENTITY.MSeller;
using MGC.ENTITY.MTableRecord;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MGC.DAL.Concrete.EFCore
{
    public class MgcContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(@"Server=DESKTOP-UT30727;Database=MGCDB;Trusted_Connection=True;MultipleActiveResultSets=true");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            foreach (var entityType in builder.Model.GetEntityTypes())
            {
                builder.Entity(entityType.ClrType).ToTable(entityType.ClrType.Name);
            }

            //Identity
            builder.Entity<UserRole>()
                .HasKey(o => new { o.UserId, o.RoleId });

            builder.Entity<ApplicationUser>()
                .HasIndex(o => new { o.UserName })
                .IsUnique();
            builder.Entity<ApplicationUser>()
                .HasKey(o => o.Id);

            // Category

            builder.Entity<MainCategory>()
                .HasIndex(o => o.CategoryCode)
                .IsUnique();
            builder.Entity<MiddleCategory>()
                .HasIndex(o => o.CategoryCode)
                .IsUnique();
            builder.Entity<Category>()
                .HasIndex(o => o.CategoryCode)
                .IsUnique();

            // Phone

            builder.Entity<PhoneImage>()
                .HasKey(o => new { o.PhoneId, o.QueueNumber});
            builder.Entity<PhoneColor>()
                .HasKey(o => new { o.PhoneId, o.ColorCode });

            // Computer

            builder.Entity<ComputerImage>()
                .HasKey(o => new { o.ComputerId, o.QueueNumber});
            builder.Entity<ComputerBrand>()
                .HasIndex(o=>o.Name)
                .IsUnique();
            builder.Entity<ComputerImage>()
                .HasKey(o => new { o.ComputerId, o.QueueNumber });

            // Seller

            builder.Entity<Seller>()
                .HasIndex(o => o.SellerCode)
                .IsUnique();
        }

        //Identity
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<ApplicationRole> ApplicationRole { get; set; }
        public DbSet<UserRole> UserRole { get; set; }

        // Place *******************
        public DbSet<Country> Country { get; set; }
        public DbSet<Province> Province { get; set; }
        public DbSet<District> District { get; set; }

        // Category
        public DbSet<MainCategory> MainCategory { get; set; }
        public DbSet<MiddleCategory> MiddleCategory { get; set; }
        public DbSet<Category> Category { get; set; }

        // Seller *************************
        // Seller
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SellerComment> SellerComment { get; set; }

        // Products ****************************
        // Phone

        public DbSet<Phone> Phone { get; set; }
        public DbSet<PhoneBrand> PhoneBrand { get; set; }
        public DbSet<PhoneColor> PhoneColor { get; set; }
        public DbSet<PhoneImage> PhoneImage { get; set; }
        public DbSet<PhoneProperty> phoneProperty { get; set; }
        public DbSet<PhoneBatteryCapacity> PhoneBatteryCapacity { get; set; }
        public DbSet<PhoneCpuCapacity> PhoneCpuCapacity { get; set; }
        public DbSet<PhoneInternalMemory> PhoneInternalMemory { get; set; }
        public DbSet<PhoneOS> PhoneOS { get; set; }
        public DbSet<PhoneOSType> PhoneOSType { get; set; }
        public DbSet<PhoneRamCapacity> PhoneRamCapacity { get; set; }
        public DbSet<PhoneWifi> PhoneWifi { get; set; }
        public DbSet<PhoneScreenDimension> PhoneScreenDimension { get; set; }
        public DbSet<PhoneComment> PhoneComment { get; set; }

        // Computer 

        public DbSet<Computer> Computer { get; set; }
        public DbSet<ComputerBrand> ComputerBrand { get; set; }
        public DbSet<ComputerComment> ComputerComment { get; set; }
        public DbSet<ComputerCPU> ComputerCPU { get; set; }
        public DbSet<ComputerCPUType> ComputerCPUType { get; set; }
        public DbSet<ComputerHDDCapacity> ComputerHDDCapacity { get; set; }
        public DbSet<ComputerImage> ComputerImage { get; set; }
        public DbSet<ComputerProperty> ComputerProperty { get; set; }
        public DbSet<ComputerRamSpeed> ComputerRamSpeed { get; set; }
        public DbSet<ComputerScreenCard> ComputerScreenCard { get; set; }
        public DbSet<ComputerScreenCardRam> ComputerScreenCardRam { get; set; }
        public DbSet<ComputerScreenCardType> ComputerScreenCardType { get; set; }
        public DbSet<ComputerScreenSize> ComputerScreenSize { get; set; }
        public DbSet<ComputerSSDCapacity> ComputerSSDCapacity { get; set; }
        public DbSet<ComputerFilter> ComputerFilter { get; set; }
    
        // DataStorage
        public DbSet<DataStorage> DataStorage { get; set; }

        // Table Records

        public DbSet<ProductRecord> ProductRecord { get; set; }
        public DbSet<FilterRecord> FilterRecord { get; set; }
        public DbSet<TablelessFilterProperty> TablelessFilterProperty { get; set; }
    }
}
