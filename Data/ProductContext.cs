//Programmer name: C. Mathole

using Microsoft.EntityFrameworkCore;
using DatabaseApplication.Models;

namespace DatabaseApplication.Data
{
	public class ProductContext:DbContext
	{
		public DbSet<Product> Products { get; set; }
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlite("Data Source=products.db");
		} // end OnConfiguring(DbContextOptionsBuilder optionsBuilder) Method
	} // end class
} // end namespace