using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Book.Repository.RepoDbContext
{
    public class BookDbContext : DbContext
    {
        public BookDbContext(DbContextOptions<DbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public virtual DbSet<Book> Books { get; set; }
    }
}
