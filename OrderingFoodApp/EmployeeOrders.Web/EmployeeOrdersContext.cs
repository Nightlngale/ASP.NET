using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeOrders.Web.Models
{
    public partial class EmployeeOrdersContext : DbContext
    {
        public EmployeeOrdersContext()
        {
        }

        public EmployeeOrdersContext(DbContextOptions<EmployeeOrdersContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Drink> Drink { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserOrders> UserOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Your connection string");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity<Drink>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Price).HasColumnType("money");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.Property(e => e.DrinkId).HasColumnName("Drink_Id");

                entity.Property(e => e.FoodId).HasColumnName("Food_Id");

                entity.Property(e => e.Total).HasColumnType("money");

                entity.HasOne(d => d.Drink)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.DrinkId)
                    .HasConstraintName("Fk_Orders_Drink");

                entity.HasOne(d => d.Food)
                    .WithMany(p => p.Order)
                    .HasForeignKey(d => d.FoodId)
                    .HasConstraintName("Fk_Orders_Food");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.PasswordHash)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<UserOrders>(entity =>
            {
                entity.Property(e => e.OrderId).HasColumnName("Order_Id");

                entity.Property(e => e.UserId).HasColumnName("User_Id");

                entity.HasOne(d => d.Order)
                    .WithMany(p => p.UserOrders)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Users_Orders");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserOrders)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_Users_Orders_u");
            });
        }
    }
}
