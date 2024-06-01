using System;
using System.Collections.Generic;
using Data.Configurations;
using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BanSach.Models;

public partial class QLBanSachDBContext : DbContext
{
    public QLBanSachDBContext(DbContextOptions<QLBanSachDBContext> options)
        : base(options)
    {
    }

    public DbSet<Author> Authors { get; set; }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<Category> Categorys { get; set; }

    public DbSet<Contact> Contacts { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<OrderDetail> OrderDetails { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<ProductCategory> ProductCategorys { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CartConfiguration());

        modelBuilder.ApplyConfiguration(new OrderConfiguration());

        modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());

        modelBuilder.ApplyConfiguration(new ProductConfiguration());

        modelBuilder.ApplyConfiguration(new ProductCategoryConfiguration());

        modelBuilder.ApplyConfiguration(new UserConfiguration());

        modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
    }
}
