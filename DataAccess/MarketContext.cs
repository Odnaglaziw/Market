using Microsoft.EntityFrameworkCore;
using Models.Models;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace DataAccess
{
    public class MarketContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public MarketContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=DsPs4N8gt3;Host=odnaglaziw.online;Port=5432;Database=MarketDB;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<Product>().HasKey(x => x.Id);
            modelBuilder.Entity<Review>().HasKey(x => x.Id);
            modelBuilder.Entity<User>()
                .HasMany(u => u.Products)
                .WithOne(p => p.Seller)
                .HasForeignKey(p => p.SellerId);

            modelBuilder.Entity<Product>()
                .Property(p => p.Name)
                .IsRequired() 
                .HasMaxLength(100); 

            modelBuilder.Entity<Product>()
                .Property(p => p.Description)
                .HasMaxLength(500); 

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)"); 

            modelBuilder.Entity<Product>()
                .Property(p => p.ImageUrl)
                .HasMaxLength(500);

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Seller)
                .WithMany(u => u.Products)
                .HasForeignKey(p => p.SellerId);

            modelBuilder.Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserId);
        }
        public bool Connection
        {
            get
            {
                try
                {
                    return Database.CanConnect();
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}
