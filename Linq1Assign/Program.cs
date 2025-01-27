namespace Linq1Assign;
using static Linq1Assign.ListGenerator;
internal class Program
  {
    static void Main(string[] args)
        {

        #region Linq Restriction_Operators

        #region 1

        //var OutOf = ProductList.Where(p => p.UnitsInStock == 0);

        //foreach (var item in OutOf)
        //    Console.WriteLine(item);
        #endregion

        #region 2

        //var InStock = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3m);

        //foreach (var item in InStock)
        //    Console.WriteLine(item);
        #endregion

        #region 3

        //string[] ArrOfDigits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var result = ArrOfDigits.Where((n, i) => n.Length < i);

        //foreach (var didgit in result)
        //    Console.WriteLine(didgit);

        #endregion

        #endregion
        #region Linq Ordering_Operators

        #region 1

        //var SortName = ProductList.OrderBy(p => p.ProductName);

        //foreach (var item in SortName)
        //    Console.WriteLine(item);
        #endregion

        #region 2

        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //don't understand
        #endregion

        #region 3

        //var result = ProductList.OrderByDescending(p => p.UnitsInStock);

        //foreach (var item in result)
        //    Console.WriteLine(item);
        #endregion

        #region 4

        //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        //var result = digits.OrderBy(d => d.Length).ThenBy(d => d);

        //foreach (var digit in result)
        //    Console.WriteLine(digit);

        #endregion

        #region 5

        //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //var result = words.OrderBy(w => w.Length).ThenBy(b => b, StringComparer.OrdinalIgnoreCase);

        //foreach (var word in result)
        //    Console.WriteLine(word);

        #endregion

        #region 6
        //var descOrder = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

        //foreach (var item in descOrder)
        //    Console.WriteLine(item);
        #endregion

        #region 7
        //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

        //var SortWord = words.OrderBy(w => w.Length).ThenByDescending(b => b, StringComparer.OrdinalIgnoreCase);

        //foreach (var word in SortWord)
        //    Console.WriteLine(word);

        #endregion

        #region 8 

        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //var numOfI = Arr.Where(w => w[1] == 'i').Reverse();

        //foreach (var item in numOfI)
        //    Console.WriteLine(item);

        #endregion

        #endregion
        #region Linq Transformation_Operators

        #region 1

        //var SeqByName = ProductList.Select(p => p.ProductName);

        //foreach (var item in SeqByName)
        //    Console.WriteLine(item);

        #endregion

        #region 2

        //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        ////Anonymous Types
        //var UPLOW = words.Select(UL => new
        //{
        //    UpperCase = UL.ToUpper(),
        //    LowerCase = UL.ToLower(),
        //});

        //foreach (var word in UPLOW)
        //    Console.WriteLine(word);

        #endregion

        #region 3 

        //var UnitToPrice = ProductList.Select(p => new
        //{
        //    p.ProductName,
        //    p.Category,
        //    Price = p.UnitPrice,
        //});

        //foreach (var item in UnitToPrice)
        //    Console.WriteLine(item);

        #endregion

        #region 4
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

        //var Position = Arr.Select((n, i) =>
        //{
        //    string IsInPosition;
        //    if (i == n)
        //    {
        //        IsInPosition = "True";
        //    }
        //    else
        //    {
        //        IsInPosition = "False";
        //    }
        //    return new
        //    {
        //        Number = n,
        //        inHisPosition = IsInPosition
        //    };
        //});

        //foreach (var item in Position)
        //    Console.WriteLine(item);

        #endregion

        #region 5

        //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        //int[] numbersB = { 1, 3, 5, 7, 8 };

        //var result = numbersA.SelectMany(n => numbersB, (A, B) => new
        //{
        //    NumberA = A,
        //    NumberB = B,
        //}).Where(p => p.NumberA < p.NumberB);

        //foreach (var item in result)
        //    Console.WriteLine($"{item.NumberA } is less than {item.NumberB}");

        #endregion

        #region 6

        //var result = CustomerList.SelectMany(o => o.Orders).Where(o => o.Total < 500);

        //foreach (var order in result)
        //    Console.WriteLine(order);

        #endregion

        #region 7

        //var result = CustomerList.SelectMany(o => o.Orders).Where(o => o.OrderDate.Year >= 1998);

        //foreach (var order in result)
        //    Console.WriteLine(order);

        #endregion

        #endregion
    }
}

