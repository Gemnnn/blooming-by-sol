using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using backend.Models;

namespace backend.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet properties for each model
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Customize ASP.NET Identity table names
            modelBuilder.Entity<IdentityUser>(entity =>
            {
                entity.ToTable("User");
            });
            modelBuilder.Entity<IdentityRole>(entity =>
            {
                entity.ToTable("Role");
            });
            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.ToTable("UserRoles");
            });
            modelBuilder.Entity<IdentityUserClaim<string>>(entity =>
            {
                entity.ToTable("UserClaims");
            });
            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.ToTable("UserLogins");
            });
            modelBuilder.Entity<IdentityRoleClaim<string>>(entity =>
            {
                entity.ToTable("RoleClaims");
            });
            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.ToTable("UserTokens");
            });

            // Define relationships and constraints

            // Cart to User
            modelBuilder.Entity<Cart>()
                .HasOne(c => c.User)
                .WithMany(u => u.Carts)
                .HasForeignKey(c => c.UserId);

            // CartItem to Cart
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Cart)
                .WithMany(c => c.CartItems)
                .HasForeignKey(ci => ci.CartId);

            // CartItem to Product
            modelBuilder.Entity<CartItem>()
                .HasOne(ci => ci.Product)
                .WithMany(p => p.CartItems)
                .HasForeignKey(ci => ci.ProductId);

            // Order to User
            modelBuilder.Entity<Order>()
                .HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);

            // Order to Address
            modelBuilder.Entity<Order>()
                .HasOne(o => o.ShippingAddress)
                .WithMany()
                .HasForeignKey(o => o.ShippingAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            // OrderItem to Order
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId);

            // OrderItem to Product
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(oi => oi.ProductId);

            // Product to Category
            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId);

            // Review to Product
            modelBuilder.Entity<Review>()
                .HasOne(r => r.Product)
                .WithMany(p => p.Reviews)
                .HasForeignKey(r => r.ProductId);

            // Review to User
            modelBuilder.Entity<Review>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reviews)
                .HasForeignKey(r => r.UserId);

            // Province to Country
            modelBuilder.Entity<Province>()
                .HasOne(p => p.Country)
                .WithMany(c => c.Provinces)
                .HasForeignKey(p => p.CountryId);

            // User to Address (Mailing Address)
            modelBuilder.Entity<User>()
                .HasOne(u => u.MailingAddress)
                .WithMany()
                .HasForeignKey(u => u.MailingAddressId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed roles
            var adminRole = new IdentityRole
            {
                Id = "1",
                Name = "Admin",
                NormalizedName = "ADMIN"
            };

            var memberRole = new IdentityRole
            {
                Id = "2",
                Name = "Member",
                NormalizedName = "MEMBER"
            };

            modelBuilder.Entity<IdentityRole>().HasData(
                adminRole,
                memberRole
            );

            // Seed Country
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    CountryId = 1,
                    Name = "Canada"
                },
                new Country
                {
                    CountryId = 2,
                    Name = "US"
                }
            );

            // Seed Province
            modelBuilder.Entity<Province>().HasData(
                new Province
                {
                    ProvinceId = 1,
                    Name = "AB",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 2,
                    Name = "BC",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 3,
                    Name = "MB",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 4,
                    Name = "NB",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 5,
                    Name = "NL",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 6,
                    Name = "NT",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 7,
                    Name = "NS",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 8,
                    Name = "NU",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 9,
                    Name = "ON",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 10,
                    Name = "PE",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 11,
                    Name = "QC",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 12,
                    Name = "SK",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 13,
                    Name = "YT",
                    CountryId = 1
                },
                new Province
                {
                    ProvinceId = 14,
                    Name = "AL",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 15,
                    Name = "AK",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 16,
                    Name = "AZ",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 17,
                    Name = "AR",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 18,
                    Name = "CA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 19,
                    Name = "CO",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 20,
                    Name = "CT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 21,
                    Name = "DE",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 22,
                    Name = "DC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 23,
                    Name = "FL",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 24,
                    Name = "GA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 25,
                    Name = "HI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 26,
                    Name = "ID",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 27,
                    Name = "IL",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 28,
                    Name = "IN",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 29,
                    Name = "IA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 30,
                    Name = "KS",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 31,
                    Name = "KY",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 32,
                    Name = "LA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 33,
                    Name = "ME",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 34,
                    Name = "MD",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 35,
                    Name = "MA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 36,
                    Name = "MI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 37,
                    Name = "MN",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 38,
                    Name = "MS",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 39,
                    Name = "MO",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 40,
                    Name = "MT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 41,
                    Name = "NE",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 42,
                    Name = "NV",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 43,
                    Name = "NH",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 44,
                    Name = "NJ",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 45,
                    Name = "NM",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 46,
                    Name = "NY",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 47,
                    Name = "NC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 48,
                    Name = "ND",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 49,
                    Name = "OH",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 50,
                    Name = "OK",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 51,
                    Name = "OR",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 52,
                    Name = "PA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 53,
                    Name = "RI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 54,
                    Name = "SC",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 55,
                    Name = "SD",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 56,
                    Name = "TN",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 57,
                    Name = "TX",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 58,
                    Name = "UT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 59,
                    Name = "VT",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 60,
                    Name = "VA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 61,
                    Name = "WA",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 62,
                    Name = "WV",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 63,
                    Name = "WI",
                    CountryId = 2
                },
                new Province
                {
                    ProvinceId = 64,
                    Name = "WY",
                    CountryId = 2
                }
            );
        }
    }
}