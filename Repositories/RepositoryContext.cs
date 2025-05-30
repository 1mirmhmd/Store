﻿using Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repositories;

public class RepositoryContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public RepositoryContext(DbContextOptions<RepositoryContext> options)
    : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
            new Product() { ProductId = 1, ProductName = "Computer", Price = 40000 },
            new Product() { ProductId = 2, ProductName = "Mouse", Price = 300 },
            new Product() { ProductId = 3, ProductName = "Keyboard", Price = 500 },
            new Product() { ProductId = 4, ProductName = "Headphone", Price = 1000 },
            new Product() { ProductId = 5, ProductName = "Monitor", Price = 15000 }
        );
        modelBuilder.Entity<Category>().HasData(
            new Category() { CategoryId = 1, CategoryName = "Book" },
            new Category() { CategoryId = 2, CategoryName = "Electronic" }
        );
    }
}
