using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LINQ.Exercises
{
	/// <summary>
	///   Your task is to apply LINQ `Count/Sum/Min/Max/Average/Aggregate` methods, so all tests will be passed.
	///   Make sure to preview test data located in TestData.cs file.
	///   Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have
	///   expected value(s).
	/// </summary>
	[TestClass]
	public class Aggregate
	{
		[TestMethod]
		public void Count_all_numbers()
		{
			// First test is solved to show you how to use these exercises.
			var result = TestData.Numbers.Count();

			Assert.AreEqual(10, result);
		}

		[TestMethod]
		public void Count_all_occurences_of_1()
		{
			var result = TestData.Numbers.Count(n => n == 1);

			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void Count_all_animals_having_character_count_equal_to_5()
		{
			// Hint: use nested count
			var result = TestData.Animals.Count(animal => animal.Length == 5);

			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void Sum_all_numbers()
		{
			var result = TestData.Numbers.Sum();

			Assert.AreEqual(-2, result);
		}

		[TestMethod]
		public void Sum_all_characters_in_animal_names()
		{
			var result = TestData.Animals.Sum(animal => animal.Length);

			Assert.AreEqual(38, result);
		}

		[TestMethod]
		public void Sum_all_birth_years()
		{
			var result = TestData.People.Sum(p => p.Born.Year);

			Assert.AreEqual(7915, result);
		}

		[TestMethod]
		public void Find_minimum_number()
		{
			var result = TestData.Numbers.Min();

			Assert.AreEqual(-5, result);
		}

		[TestMethod]
		public void Find_length_of_shortest_animal_name()
		{
			var result = TestData.Animals.Min(a => a.Length);

			Assert.AreEqual(4, result);
		}

		[TestMethod]
		public void Find_earliest_birthday()
		{
			var result = TestData.People.Min(p => p.Born);

			Assert.AreEqual(new DateTime(1950, 12, 1), result);
		}

		[TestMethod]
		public void Find_maximum_number()
		{
			var result = TestData.Numbers.Max();

			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void Find_length_of_longest_animal_name()
		{
			var result = TestData.Animals.Max(a => a.Length);

			Assert.AreEqual(9, result);
		}

		[TestMethod]
		public void Find_latest_birthday()
		{
			var result = TestData.People.Max(p => p.Born);

			Assert.AreEqual(new DateTime(2001, 5, 21), result);
		}

		[TestMethod]
		public void Find_average_of_numbers()
		{
			double result = TestData.Numbers.Average();

			Assert.AreEqual(-0.2, result);
		}

		[TestMethod]
		public void Find_average_of_birth_years()
		{
			double result = TestData.People.Average(p => p.Born.Year);

			Assert.AreEqual(1978.75, result);
		}

		[TestMethod]
		public void Aggregate_Sum_of_all_numbers()
		{
			// Aggregate is a little bit more complicated
			// so first test is solved to show you how to use it.
			var result = TestData.Numbers.Aggregate((sum, nextValue) => sum + nextValue);

			Assert.AreEqual(-2, result);
		}

		[TestMethod]
		public void Aggregate_Product_of_all_numbers()
		{
			// Hint: product is a result of multiplication
			var result = TestData.Numbers.Aggregate((product, nextValue) => product * nextValue);

			Assert.AreEqual(-1800, result);
		}

		[TestMethod]
		public void Aggregate_Secret_formula()
		{
			// secret formula is as follows
			// start with 256
			// for each person take the day of her/his birth date
			// if this day is bigger than 15, then substract 10 from it
			// else add 5 to it
			// and add resulting number to your aggregate
			var result =
				TestData.People.Aggregate(256,
					(acc, p) => acc + (p.Born.Day > 15 ? p.Born.Day - 10 : p.Born.Day + 5));

			Assert.AreEqual(296, result);
		}
	}
}