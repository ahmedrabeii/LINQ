using static LINQ.DataSources.Source;
using LINQ.DataSources;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Q01

			//var q1 = Source.ProductList
			//	.OrderByDescending(p => p.UnitPrice)
			//	.Take(3);

			//foreach (var p in q1)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

			#endregion

			#region Q02

			//var q2 = Source.ProductList
			//	.Skip(5)
			//	.Take(5);

			//foreach (var p in q2)
			//	Console.WriteLine(p);

			#endregion

			#region Q03

			//var q3 = Source.ProductList
			//	.OrderBy(p => p.UnitPrice)
			//	.TakeWhile(p => p.UnitPrice < 25);

			//foreach (var p in q3)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

			#endregion

			#region Q04

			//bool q4 = Source.ProductList
			//	.Where(p => p.Category == "Seafood")
			//	.All(p => p.UnitsInStock > 0);

			//Console.WriteLine(q4);

			#endregion

			#region Q05

			//int[] ids = { 3, 9, 13, 18 };

			//bool q5 = ids.Contains(9);

			//Console.WriteLine(q5);

			#endregion

			#region Q06

			//var q6 = Source.ProductList
			//	.GroupBy(p => p.Category);

			//foreach (var group in q6)
			//{
			//	Console.WriteLine($"{group.Key} - {group.Count()} Products");
			//}

			#endregion

			#region Q07

			//var q7 = Source.ProductList
			//	.GroupBy(p => p.Category)
			//	.Select(g => new
			//	{
			//		Category = g.Key,
			//		ProductNames = g.Select(p => p.ProductName)
			//	});

			//foreach (var group in q7)
			//{
			//	Console.WriteLine(group.Category);

			//	foreach (var name in group.ProductNames)
			//		Console.WriteLine(name);
			//}

			#endregion

			#region Q08

			//var q8 = Source.ProductList
			//	.GroupBy(p => p.Category)
			//	.Where(g => g.Count() > 3)
			//	.Select(g => new
			//	{
			//		Category = g.Key,
			//		Count = g.Count()
			//	});

			//foreach (var category in q8)
			//{
			//	Console.WriteLine($"{category.Category} - {category.Count}");
			//}

			#endregion

			#region Q09

			//var q9 =
			//	from c in Source.CustomerList
			//	group c by c.Country into countryGroup
			//	select new
			//	{
			//		Country = countryGroup.Key,
			//		Count = countryGroup.Count(),
			//		TotalOrderValue = countryGroup.Sum(c =>
			//			c.Orders.Sum(o => o.Total))
			//	};

			//foreach (var country in q9)
			//{
			//	Console.WriteLine(
			//		$"{country.Country} - Count: {country.Count} - Total: {country.TotalOrderValue}");
			//}

			#endregion

			#region Q10

			//var q10 = Source.ProductList
			//	.Sum(p => p.UnitsInStock);

			//Console.WriteLine(q10);

			#endregion

			#region Q11

			//var cheapest = Source.ProductList.Min(p => p.UnitPrice);
			//var mostExpensive = Source.ProductList.Max(p => p.UnitPrice);

			//Console.WriteLine($"Cheapest Price: {cheapest}");
			//Console.WriteLine($"Most Expensive Price: {mostExpensive}");

			#endregion

			#region Q12

			//var q12 = Source.ProductList
			//	.Select(p => p.Category)
			//	.Distinct();

			//foreach (var category in q12)
			//	Console.WriteLine(category);

			#endregion

			#region Q13

			//int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
			//int[] setB = { 3, 6, 9, 12, 15, 13 };

			//var q13 = setA.Except(setB);

			//foreach (var id in q13)
			//	Console.WriteLine(id);

			#endregion

			#region Q14

			//string[] list1 = { "Germany", "France", "UK", "Spain" };
			//string[] list2 = { "france", "SPAIN", "Italy" };

			//var q14 = list1.Except(
			//	list2,
			//	StringComparer.OrdinalIgnoreCase
			//);

			//foreach (var country in q14)
			//	Console.WriteLine(country);

			#endregion

			#region Q15

			//var q15 = Source.ProductList
			//	.ToDictionary(p => p.ProductID);

			//var product = q15[18];

			//Console.WriteLine(product);

			#endregion

			#region Q16

			//var q16 = Source.ProductList
			//	.First(p => p.UnitPrice > 50);

			//Console.WriteLine(q16);

			#endregion

			#region Q17

			//var q17 = Source.ProductList
			//	.FirstOrDefault(p => p.UnitPrice > 500);

			//Console.WriteLine(q17);

			#endregion

			#region Q18

			//var q18 = Enumerable.Range(1, 10)
			//	.Select(n => $"7 x {n} = {7 * n}");

			//foreach (var item in q18)
			//	Console.WriteLine(item);

			#endregion

			#region Q19

			//var q19 = Enumerable.Range(1, 30)
			//	.Where(n => n % 2 == 0);

			//foreach (var number in q19)
			//	Console.WriteLine(number);

			#endregion

			#region Q20

			//var q20 = Source.ProductList
			//	.Take(3)
			//	.Select(p => p.ProductName)
			//	.Concat(
			//		Source.CustomerList
			//			.Take(3)
			//			.Select(c => c.CompanyName)
			//	);

			//foreach (var name in q20)
			//	Console.WriteLine(name);

			#endregion

			#region Q21

			//var q21 = Source.ProductList
			//	.Zip(Source.CustomerList,
			//		(p, c) => $"{p.ProductName} sold to {c.CompanyName}");

			//foreach (var item in q21)
			//	Console.WriteLine(item);

			#endregion


		}
	}
}
