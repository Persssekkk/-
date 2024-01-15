using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace комиксы.Models
{
    public partial class storeDBContext : DbContext
    {
        public storeDBContext()
        {
        }

        public storeDBContext(DbContextOptions<storeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Clients> Clients { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=storeDB;Username=Admin;Password=123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clients>(entity =>
            {
                entity.ToTable("clients");

                entity.Property(e => e.ClientsId)
                    .HasColumnName("clients_id")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Login)
                    .HasColumnName("login")
                    .HasMaxLength(30);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(40);

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(40);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("bit(1)");

                entity.HasOne(d => d.OrdersNavigation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.Orders)
                    .HasConstraintName("clients_orders_fkey");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.IdOrder)
                    .HasName("order_pkey");

                entity.ToTable("order");

                entity.Property(e => e.IdOrder)
                    .HasColumnName("id_order")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Apartment).HasColumnName("apartment");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(40);

                entity.Property(e => e.Cost).HasColumnName("cost");

                entity.Property(e => e.Floor).HasColumnName("floor");

                entity.Property(e => e.House)
                    .HasColumnName("house")
                    .HasMaxLength(6);

                entity.Property(e => e.ProductsId).HasColumnName("products_id");

                entity.Property(e => e.Street)
                    .HasColumnName("street")
                    .HasMaxLength(40);

                entity.Property(e => e.TelNumber)
                    .HasColumnName("tel_number")
                    .HasMaxLength(11);

                entity.HasOne(d => d.Products)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.ProductsId)
                    .HasConstraintName("order_products_id_fkey");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.IdProducts)
                    .HasName("products_pkey");

                entity.ToTable("products");

                entity.Property(e => e.IdProducts)
                    .HasColumnName("id_products")
                    .UseIdentityAlwaysColumn();

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasMaxLength(299);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50);

                entity.Property(e => e.Photo)
                    .HasColumnName("photo")
                    .HasColumnType("bit(1)");

                entity.Property(e => e.Price).HasColumnName("price");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
