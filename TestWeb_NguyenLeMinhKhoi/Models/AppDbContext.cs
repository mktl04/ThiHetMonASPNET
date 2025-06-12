using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestWeb_NguyenLeMinhKhoi.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "Học CSS", Price = 300, Author = "Nguyễn Tấn Thành", Quantity = 2 },
                new Book { Id = 2, Title = "Học Java", Price = 200, Author = "Phạm Đức Trọng", Quantity = 3 },
                new Book { Id = 3, Title = "Học Java Nâng Cao", Price = 500, Author = "Phạm Tú", Quantity = 5 },
                new Book { Id = 4, Title = "Kiến thức Word cơ bản", Price = 200, Author = "Nguyễn Duy", Quantity = 1 },
                new Book { Id = 5, Title = "Lịch sử", Price = 200, Author = "Phạm Đức Trọng", Quantity = 1 },
                new Book { Id = 6, Title = "Lịch sử VN", Price = 200, Author = "Phạm Đức Trọng", Quantity = 1 }
                );
        }
    }
}
