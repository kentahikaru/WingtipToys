﻿using System.Data.Entity;
namespace WingtipToys.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("WingtipToys")  // selecting DB by name (from web.config) or by connection string
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}