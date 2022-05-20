using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }
        public DbSet<Book> Books { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    const string cs = @"Server=DESKTOP-L91OLLD;Database=Books;Trusted_Connection=true";
        //    optionsBuilder.UseSqlServer(cs);


        //    using (var db = new BookContext())
        //    {
        //        db.Database.EnsureCreated();
        //    }
        //}

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
