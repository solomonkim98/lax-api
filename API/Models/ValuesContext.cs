using System;
using API.Models;
using Microsoft.EntityFrameworkCore;
using Type = API.Models.Type;

namespace API
{
	public class ValuesContext : DbContext
	{
		public ValuesContext(DbContextOptions<ValuesContext> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
			modelBuilder.Entity<Type>()
				.HasMany(c => c.Values)
				.WithOne(a => a.Type)
				.HasForeignKey(a => a.TypeId);


			modelBuilder.Seed();
        }

		public DbSet<Value> Values { get; set; }
		public DbSet<Type> Types { get; set; }
	}
}

