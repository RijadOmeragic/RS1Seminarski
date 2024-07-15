using Microsoft.EntityFrameworkCore;
using WebShop.Models;

namespace WebShop.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Membership> Memberships { get; set; }
        public DbSet<OrderHistory> OrderHistories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderStatus> OrderStatuses { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ReturnRequest> ReturnRequests { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<ProductDiscount> ProductDiscounts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<StockItem> StockItems { get; set; }
        public DbSet<Storage> Storages { get; set; }
        public DbSet<WishList> WishLists { get; set; }
        public DbSet<WishListProduct> WishListsProducts { get; set; }


        public ApplicationDbContext(DbContextOptions options) : base(options) 
        {
            
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<WishListProduct>()
           .HasKey(wp => new { wp.WishListId, wp.ProductId });

            modelBuilder.Entity<WishListProduct>()
                .HasOne(wp => wp.WishList)
                .WithMany(w => w.WishListProducts)
                .HasForeignKey(wp => wp.WishListId);

            modelBuilder.Entity<WishListProduct>()
                .HasOne(wp => wp.Product)
                .WithMany(p => p.WishListProducts)
                .HasForeignKey(wp => wp.ProductId);

        }
        
    }
}
