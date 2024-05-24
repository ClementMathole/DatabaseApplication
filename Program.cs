//Programmer name: C. Mathole

using System;
using System.Linq;
using static System.Console;
using DatabaseApplication.Data;
using DatabaseApplication.Models;

namespace DatabaseApplication
{
	public class Program
	{
		static void Create()
		{
			//
			//Method Name		: void Create()
			//Purpose			: Adds a new product to the database
			//Re-Use			: none
			//Input Parameter	: none
			//Output Type		: none
			//
			using (var db = new ProductContext())
			{
				Write("Enter Product Name: ");
				var name = ReadLine();
				
				Write("Enter Product Price: ");
				if(double.TryParse(ReadLine(), out double price))
				{
					db.Products.Add(new Product{Name = name, Price = price});
					db.SaveChanges();
					WriteLine("Product Created Successfully");
				}
				else{
					WriteLine("Invalid Price. Please try again");
				} // end if
			}
		} // end Create() method
		
		static void Read()
		{
			//
			//Method Name		: void Read()
			//Purpose			: Displays the Product records in the Database
			//Re-Use			: none
			//Input Parameter	: none
			//Output Type		: none
			//
			using (var db = new ProductContext())
			{
				var products = db.Products.ToList();
				WriteLine("\nProducts in the Database: ");
				foreach (var product in products){
					WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
				} // end foreach
			}
		} // end Read() method
		
		static void Update()
		{
			//
			//Method Name		: void Update()
			//Purpose			: Update existing Product if
			//Re-Use			: none
			//Input Parameter	: none
			//Output Type		: none
			//
			using (var db = new ProductContext())
			{
				Write("Enter Product ID to update: ");
				if (int.TryParse(ReadLine(), out int id))
				{
					var product = db.Products.Find(id);
					if (product != null)
					{
						Write("Enter new Product Name: ");
						product.Name =ReadLine();
						Write("Enter new Product Price: ");
						
						if (double.TryParse(ReadLine(), out double price))
						{
							product.Price = price;
							db.SaveChanges();
							WriteLine("Product updated successfully");
						}
						else
						{
							WriteLine("Invalid Price. Please try again");
						} // end if
					}
					else
					{
						WriteLine("Product not found");
					} // end if
				}
				else
				{
					WriteLine("Invalid ID. Please try again");
				} // end if
			}
		} // end Update() method
		
		static void Delete()
		{
			//
			//Method Name		: void Delete()
			//Purpose			: Try to delete a Product from the database
			//Re-Use			: none
			//Input Parameter	: none
			//Output Type		: none
			//
			using (var db = new ProductContext())
			{
				Write("Enter Product ID to delete: ");
				if (int.TryParse(ReadLine(), out int id))
				{
					var product = db.Products.Find(id);
					if(product != null)
					{
						db.Products.Remove(product);
						db.SaveChanges();
						WriteLine("Product Deleted successfully");
					}
					else
					{
						WriteLine("Product not found");
					} // end if
				}
				else
				{
					WriteLine("Invalid ID. Please try again");
				} // end if
			}
		} // end Delete() method
		
		static void Main(string[] args)
		{
			//
			//Method Name		: void Main(string[] args)
			//Purpose			: Main entry into the program
			//Re-Use			: Create(), Read(), Update(), Delete()
			//Input Parameter	: string[] args
			//Output Type		: none
			//
			while(true)
			{
				WriteLine("\nChoose an Option");
				WriteLine("1. Create a Product");
				WriteLine("2. View Products");
				WriteLine("3. Update Product");
				WriteLine("4. Delete a Product");
				WriteLine("0. Exit");
				
				Write("Option: ");
				var option = ReadLine();
				
				switch(option)
				{
					case "1":
						Create();
						break;
					case "2":
						Read();
						break;
					case "3":
						Update();
						break;
					case "4":
						Delete();
						break;
					case "0":
						return;
					default:
						WriteLine("Invalid option. Please try again");
						break;
				} // end switch
			} // end while loop
		} // end Main(string[] args) method
	} // end class
} // end namespace