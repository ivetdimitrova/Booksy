﻿using Booksy.Data.Configurations;
using  Booksy.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booksy.Data
{
    public class BooksyDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public BooksyDbContext(DbContextOptions<BooksyDbContext> options)
         : base(options)
        {
        }

        public virtual DbSet<Author> Authors { get; set; } = null!;
        public virtual DbSet<AuthorBook> AuthorsBooks { get; set; } = null!;

        public virtual DbSet<Book> Books { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<OrderBook> OrdersBooks { get; set; } = null!;
        public virtual DbSet<Ganre> Ganres { get; set; } = null!;

        public virtual DbSet<BookGanre> BooksGanres { get; set; } = null!;




        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new AuthorBookConfiguration());
            builder.ApplyConfiguration(new AuthorConfiguration());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new OrderBookConfiguration());
            builder.ApplyConfiguration(new OrderConfiguration());
            builder.ApplyConfiguration(new GanreConfiguration());
            builder.ApplyConfiguration(new BookGanreConfiguration());

        }
    }
}
