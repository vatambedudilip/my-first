namespace EntityFrameWorkExamples.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }
        public virtual DbSet<Profit> Profits { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<T_ELITE_CATEGORY> T_ELITE_CATEGORY { get; set; }
        public virtual DbSet<T_ELITE_CATEGORY_CUSTOMERS> T_ELITE_CATEGORY_CUSTOMERS { get; set; }
        public virtual DbSet<T_ELITE_CATEGORY_ITEMS> T_ELITE_CATEGORY_ITEMS { get; set; }
        public virtual DbSet<T_ELITE_DINING_CABIN> T_ELITE_DINING_CABIN { get; set; }
        public virtual DbSet<T_ELITE_ORDER> T_ELITE_ORDER { get; set; }
        public virtual DbSet<EliteProductSale> EliteProductSales { get; set; }
        public virtual DbSet<T_ELITE_CATEGORY_CUSTOMER_ORDERS> T_ELITE_CATEGORY_CUSTOMER_ORDERS { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<T_ELITE_CATEGORY>()
                .Property(e => e.CATEGORY)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_CATEGORY_CUSTOMERS>()
                .Property(e => e.FNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_CATEGORY_CUSTOMERS>()
                .Property(e => e.LNAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_CATEGORY_ITEMS>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_CATEGORY_ITEMS>()
                .Property(e => e.PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<T_ELITE_DINING_CABIN>()
                .Property(e => e.NAME)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_DINING_CABIN>()
                .Property(e => e.ASSIGNED_WAITER)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_ORDER>()
                .Property(e => e.ITEMS)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_ORDER>()
                .Property(e => e.STATUS)
                .IsUnicode(false);

            modelBuilder.Entity<T_ELITE_ORDER>()
                .Property(e => e.TOTAL_PRICE)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.Manufacturing_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.Sale_Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.Gross_Sales)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.Discounts)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.Sales)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.COGS)
                .HasPrecision(19, 4);

            modelBuilder.Entity<EliteProductSale>()
                .Property(e => e.Profit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<T_ELITE_CATEGORY_CUSTOMER_ORDERS>()
                .Property(e => e.ORDER_NAME)
                .IsUnicode(false);
        }
    }
}
