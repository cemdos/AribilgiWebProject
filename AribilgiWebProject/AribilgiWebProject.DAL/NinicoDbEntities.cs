using AribilgiWebProject.Model;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace AribilgiWebProject.DAL
{
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
        }
    }
}
