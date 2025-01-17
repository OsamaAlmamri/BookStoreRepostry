﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaticData.Models
{
    public class BookStoreDBContext:IdentityDbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options):base(options)
        {

        }

        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id=10,name="osama"

            });
        }
        public DbSet<Book> Books { get; set; }
    }
}
