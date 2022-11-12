using System.Collections.ObjectModel;

namespace CSharp.Examples
{
	internal class LinqRestriction
	{
		//This sample uses where to find all elements of an array less than 5.
		//It demonstrates the components of a query, including a where clause that filters for small numbers.
		public void NumbersLessThan5()
		{
			int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

			// User query expression to find all numbers less than 5
			var result =    from num in numbers
							where num < 5
							select num;

			result.ToList().ForEach(item => Console.Write($"{item} "));

			// User method expression to find all numbers less than 5
			result = numbers.Where(item => item < 5);

			Console.WriteLine();

			result.ToList().ForEach(num => Console.Write($"{num} "));
		}

		// This sample uses where to find all products that are out of stock.
		// Its where clause examines a property of the items in the input sequence.
		public void GetAllOutOfStockProducts()
		{
			var products = GetProducts();

			// Use query expression to get all out of stock products
			var outOfStock =    from product in products
								where product.QuantityInStock == 0
								select product;

			outOfStock.ToList().ForEach(item => Console.Write($"{item.Name} "));

			Console.WriteLine();

			// Use method expression to get all out of stock products
			outOfStock = products.Where(item => item.QuantityInStock == 0);

			outOfStock.ToList().ForEach(item => Console.Write($"{item.Name} "));
		}

		// This sample uses where to find all products that are in stock and cost more than 5.00 per unit.
		public void GetProductsLessThan5Dollars()
		{
			var products = GetProducts();

			// Use query expression to get all products less than 5 dollars
			var lessThan5 =     from product in products
								where product.Price < 5.00
								select product;

			lessThan5.ToList().ForEach(item => Console.Write($"{item.Name} "));

			Console.WriteLine();

			// Use method syntac to get all products less than 5 dollars
			lessThan5 = products.Where(item => item.Price < 5);

			lessThan5.ToList().ForEach(item => Console.Write($"{item.Name} "));
		}

		private ICollection<Product> GetProducts()
		{
			return new Collection<Product>()
			{
				{ new Product() { Name = "Soap", Price = 2.99, QuantityInStock = 10 } },
				{ new Product() { Name = "Kleenex", Price = 9.99, QuantityInStock = 0 } },
				{ new Product() { Name = "Dish Detergent", Price = 10.99, QuantityInStock = 10 } },
				{ new Product() { Name = "Candy Bar", Price = 1.00, QuantityInStock = 10 } },
				{ new Product() { Name = "Water", Price = 3.59, QuantityInStock = 10 } },
				{ new Product() { Name = "Flowers", Price = 12.99, QuantityInStock = 0 } }
			};
		}

		internal class Product
		{
			internal string Name { get; set; }	
			internal double Price { get; set; }
			internal int QuantityInStock { get; set; }
		}
	}
}
