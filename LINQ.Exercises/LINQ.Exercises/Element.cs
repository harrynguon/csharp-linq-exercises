﻿using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LINQ.Exercises
{
    /// <summary>
    ///   Your task is to apply LINQ `First/FirstOrDefault/Last/LastOrDefault` methods, so all tests will be passed.
    ///   Make sure to preview test data located in TestData.cs file.
    ///   Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have
    ///   expected value(s).
    /// </summary>
    [TestClass]
	public class Element
	{
		[TestMethod]
		public void First_n()
		{
			// First test is solved to show you how to use these exercises.
			var result = TestData.Numbers.First();

			Assert.AreEqual(1, result);
		}

		[TestMethod]
		public void First_n_less_than_0()
		{
			var result = TestData.Numbers.First(n => n < 0);

			Assert.AreEqual(-3, result);
		}

		[TestMethod]
		public void Last_n_greater_than_0()
		{
			var result = TestData.Numbers.Last(n => n > 0);

			Assert.AreEqual(5, result);
		}

		[TestMethod]
		public void First_even_n()
		{
			var result = TestData.Numbers.First(n => n % 2 == 0);

			Assert.AreEqual(2, result);
		}

		[TestMethod]
		public void Last_even_n()
		{
			var result = TestData.Numbers.Last(n => n % 2 == 0);

			Assert.AreEqual(-4, result);
		}

		[TestMethod]
		public void First_n_greater_than_10_if_not_found_return_0()
		{
			var result = TestData.Numbers.FirstOrDefault(n => n > 10);

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void Last_n_less_than_minus_1234_if_not_found_return_0()
		{
			var result = TestData.Numbers.LastOrDefault(n => n < (-1234));

			Assert.AreEqual(0, result);
		}

		[TestMethod]
		public void Last_elephant()
		{
			var result = TestData.Animals.Last(a => a == "elephant");

			Assert.AreEqual("elephant", result);
		}

		[TestMethod]
		public void First_string_having_4_letters()
		{
			var result = TestData.Animals.First(a => a.Length == 4);

			Assert.AreEqual("lion", result);
		}

		[TestMethod]
		public void Last_string_containg_g()
		{
			var result = TestData.Animals.Last(a => a.Contains("g"));

			Assert.AreEqual("penguin", result);
		}

		[TestMethod]
		public void First_string_having_s_as_first_letter()
		{
			var result = TestData.Animals.First(a => a[0] == 's');

			Assert.AreEqual("swordfish", result);
		}

		[TestMethod]
		public void Last_three_letter_long_word_or_null()
		{
			var result = TestData.Animals.LastOrDefault(s => s.Length == 3);

			Assert.AreEqual(null, result);
		}

		[TestMethod]
		public void First_person_born_after_2000()
		{
			var result = TestData.People.First(p => p.Born.Year > 2000);

			Assert.AreEqual(TestData.People[2], result);
		}

		[TestMethod]
		public void Last_person_with_lastname_ending_with_l()
		{
			var result = TestData.People.LastOrDefault(p => p.LastName[p.LastName.Length-1] == 'l');

			Assert.AreEqual(TestData.People[2], result);
		}

		[TestMethod]
		public void First_person_born_141th_day_of_year()
		{
			var result = TestData.People.First(p => p.Born.DayOfYear == 141);

			Assert.AreEqual(TestData.People[2], result);
		}

		[TestMethod]
		public void Last_person_whose_firstname_does_not_start_with_J_or_null()
		{
			var result = TestData.People.LastOrDefault(p => !p.FirstName.StartsWith("J"));

			Assert.AreEqual(null, result);
		}
	}
}