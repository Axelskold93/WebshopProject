﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebShop.Models;
using WebShopProject.Models;

namespace WebShopProject.Data
{
	public class AppDbContext : DbContext
	{
		public DbSet<Account> Accounts { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Cart> Carts { get; set; }
		public DbSet<CartItem> CartItems { get; set; }

		

		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
		}
	}
}
