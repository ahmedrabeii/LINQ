using static LINQ.DataSources.Source;
namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Q01

			//			var q1 = ProductList
			//				.Where(p => p.Category == "Seafood");

			//			foreach (var p in q1)
			//				Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");
			#endregion

			#region Q02

			//			var q2 = ProductList
			//				.Select(p => p.ProductName);

			//			foreach (var name in q2)
			//				Console.WriteLine(name);

			#endregion

			#region Q03

			//var q3 = ProductList
			//	.OrderBy(p => p.UnitPrice);

			//foreach (var p in q3)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

			#endregion

			#region Q04

			//var q4 = ProductList
			//	.Where(p => p.UnitPrice >= 10m && p.UnitPrice <= 30m);

			//foreach (var p in q4)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

			#endregion

			#region Q05

			//var q5 = ProductList
			//	.Where(p => p.UnitsInStock > 0 &&
			//				p.Category == "Condiments");

			//foreach (var p in q5)
			//	Console.WriteLine(p.ProductName);
			#endregion

			#region Q06

			//var q6 = ProductList.Select(p => new
			//{
			//	Name = p.ProductName,
			//	Price = p.UnitPrice,
			//	StockStatus = p.UnitsInStock > 0
			//		? "Available"
			//		: "Out of Stock"
			//});

			//foreach (var p in q6)
			//	Console.WriteLine($"{p.Name} - {p.Price} - {p.StockStatus}");

			#endregion

			#region Q07

			//var q7 = ProductList
			//	.Select((p, i) => new
			//	{
			//		Position = i + 1,
			//		Name = p.ProductName
			//	});

			//foreach (var p in q7)
			//	Console.WriteLine($"{p.Position}. {p.Name}");

			#endregion

			#region Q08

			//var q8 = ProductList
			//	.OrderBy(p => p.Category)
			//	.ThenByDescending(p => p.UnitPrice);

			//foreach (var p in q8)
			//	Console.WriteLine($"{p.Category} - {p.ProductName} - {p.UnitPrice}");

			#endregion

			#region Q09

			//var q9 = ProductList
			//	.Where(p => p.Category == "Beverages")
			//	.OrderByDescending(p => p.UnitsInStock);

			//foreach (var p in q9)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitsInStock}");

			#endregion

			#region Q10

			//var q10 =
			//	from c in CustomerList
			//	from o in c.Orders
			//	where o.OrderDate.Year >= 1997
			//	select new
			//	{
			//		c.CustomerID,
			//		o.OrderDate
			//	};

			//foreach (var order in q10)
			//	Console.WriteLine($"{order.CustomerID} - {order.OrderDate:d}");

			#endregion

			#region Q11

			//var q11 = ProductList
			//	.Select((p, i) => new
			//	{
			//		Position = i + 1,
			//		ProductName = p.ProductName
			//	});

			//foreach (var p in q11)
			//	Console.WriteLine($"{p.Position} - {p.ProductName}");

			#endregion

			#region Q12

			//string[] Arr =
			//  {"aPPLE", "AbAcUs", "bRaNcH",
			//			   "BlUeBeRrY", "ClOvEr", "cHeRry"};

			//var q12 = Arr
			//	.OrderBy(w => w.Length)
			//	.ThenBy(w => w, new StringCaseInsensitiveComparer());

			//foreach (var word in q12)
			//	Console.WriteLine(word);

			#endregion

			#region Q13

			//var q13 = Arr
			//	.Where(w => w.Length > 1 &&
			//				char.ToLowerInvariant(w[1]) == 'i')
			//	.Reverse();

			//foreach (var word in q13)
			//	Console.WriteLine(word);

			#endregion
		}
	}
}
