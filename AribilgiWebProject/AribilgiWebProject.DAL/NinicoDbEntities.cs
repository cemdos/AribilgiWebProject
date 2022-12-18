using AribilgiWebProject.Model;
using System.Data.Entity;

namespace AribilgiWebProject.DAL
{
    //CEmdos TEst
    public partial class NinicoDbEntities : DbContext
    {
        public NinicoDbEntities()
            : base("name=NinicoDbEntities")
        {
        }

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Image> Image { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Coupon> Coupon { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<OrderDetail> OrderDetail { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Category>()
                .Property(e => e.Icon)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.TableName)
                .IsUnicode(false);

            modelBuilder.Entity<Image>()
                .Property(e => e.PicUrl)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Product>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Tag>()
                .Property(e => e.TagName)
                .IsUnicode(false);

            modelBuilder.Entity<Coupon>()
                .Property(e => e.CouponCode)
                .IsUnicode(false);

            modelBuilder.Entity<City>()
                .Property(e => e.CityName)
                .IsUnicode(false);

            modelBuilder.Entity<District>()
                .Property(e => e.DistrictName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerName)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.CustomerSurname)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.ShippedAddress)
                .IsUnicode(false);

            modelBuilder.Entity<UserInfo>()
                .Property(e => e.InvoiceAddress)
                .IsUnicode(false);
        }
    }
}
