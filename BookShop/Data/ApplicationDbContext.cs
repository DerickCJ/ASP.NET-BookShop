using BookShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BookShop.Data
{
    
        public class ApplicationDbContext : IdentityDbContext

        {

            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)

           : base(options)

            {

            }

            public DbSet<Book> Books { get; set; }

            public DbSet<Category> Categories { get; set; }

            public DbSet<CartItem> CartItems { get; set; }

            public DbSet<Order> Orders { get; set; }

            public DbSet<OrderDetail> OrderDetails { get; set; }

        }
    
}
