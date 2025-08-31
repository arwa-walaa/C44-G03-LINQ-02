namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators

            #region Get the total units in stock for each product category.


            //var totalUnitsInStockByCategory = from p in ListGenerator.ProductsList
            //                                  group p by p.Category into g
            //                                  select new
            //                                  {
            //                                      Category = g.Key,
            //                                      TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //                                  };
            //foreach (var item in totalUnitsInStockByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units In Stock: {item.TotalUnitsInStock}");
            //}


            #endregion

            #region Get the cheapest price among each category's products

            //var cheapestPriceByCategory = from p in ListGenerator.ProductsList
            //                              group p by p.Category into g
            //                              select new
            //                              {
            //                                  Category = g.Key,
            //                                  CheapestPrice = g.Min(p => p.UnitPrice)
            //                              };
            //foreach (var item in cheapestPriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice:C}");
            //}

            #endregion


            #region Get the products with the cheapest price in each category (Use Let)

            //var productsWithCheapestPriceByCategory = from p in ListGenerator.ProductsList
            //                                         group p by p.Category into g
            //                                         let cheapestPrice = g.Min(p => p.UnitPrice)
            //                                         select new
            //                                         {
            //                                             Category = g.Key,
            //                                             Products = g.Where(p => p.UnitPrice == cheapestPrice)
            //                                         };
            //foreach (var item in productsWithCheapestPriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"\tProduct: {product.ProductName}, Price: {product.UnitPrice:C}");
            //    }
            //}

            #endregion


            #region Get the most expensive price among each category's products.

            //var mostExpensivePriceByCategory = from p in ListGenerator.ProductsList
            //                                   group p by p.Category into g
            //                                   select new
            //                                   {
            //                                       Category = g.Key,
            //                                       MostExpensivePrice = g.Max(p => p.UnitPrice)
            //                                   };
            //foreach (var item in mostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Most Expensive Price: {item.MostExpensivePrice:C}");
            //}




            #endregion

            #region  Get the products with the most expensive price in each category

            //var productsWithMostExpensivePriceByCategory = from p in ListGenerator.ProductsList
            //                                               group p by p.Category into g
            //                                               let mostExpensivePrice = g.Max(p => p.UnitPrice)
            //                                               select new
            //                                               {
            //                                                   Category = g.Key,
            //                                                   Products = g.Where(p => p.UnitPrice == mostExpensivePrice)
            //                                               };
            //foreach (var item in productsWithMostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}");
            //    foreach (var product in item.Products)
            //    {
            //        Console.WriteLine($"\tProduct: {product.ProductName}, Price: {product.UnitPrice:C}");
            //    }
            //}


            #endregion

            #region Get the average price of each category's products.

            //var averagePriceByCategory = from p in ListGenerator.ProductsList
            //                             group p by p.Category into g
            //                             select new
            //                             {
            //                                 Category = g.Key,
            //                                 AveragePrice = g.Average(p => p.UnitPrice)
            //                             };
            //foreach (var item in averagePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            //}


            #endregion

            #endregion

            #region LINQ - Set Operators

            #region Find the unique Category names from Product List

            //var uniqueCategories = (from p in ListGenerator.ProductsList
            //                        select p.Category).Distinct();
            //foreach (var category in uniqueCategories)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion

            #region Produce a Sequence containing the unique first letter from both product and customer names.

            //var productFirstLetters = from p in ListGenerator.ProductsList
            //                          select p.ProductName[0];
            //var customerFirstLetters = from c in ListGenerator.CustomersList
            //                           select c.CustomerName[0];
            //var uniqueFirstLetters = productFirstLetters.Union(customerFirstLetters);
            //foreach (var letter in uniqueFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region Create one sequence that contains the common first letter from both product and customer names.

            //var productFirstLetters = from p in ListGenerator.ProductsList
            //                          select p.ProductName[0];
            //var customerFirstLetters = from c in ListGenerator.CustomersList
            //                           select c.CustomerName[0];
            //var commonFirstLetters = productFirstLetters.Intersect(customerFirstLetters);
            //foreach (var letter in commonFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}

            #endregion

            #region  Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            //var productFirstLetters = from p in ListGenerator.ProductsList
            //                          select p.ProductName[0];
            //var customerFirstLetters = from c in ListGenerator.CustomersList
            //                           select c.CustomerName[0];
            //var productOnlyFirstLetters = productFirstLetters.Except(customerFirstLetters);
            //foreach (var letter in productOnlyFirstLetters)
            //{
            //    Console.WriteLine(letter);
            //}


            #endregion

            #region Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //var productLastThreeChars = from p in ListGenerator.ProductsList
            //                           select p.ProductName.Length >= 3 ? p.ProductName[^3..] : p.ProductName;
            //var customerLastThreeChars = from c in ListGenerator.CustomersList
            //                             select c.CustomerName.Length >= 3 ? c.CustomerName[^3..] : c.CustomerName;
            //var allLastThreeChars = productLastThreeChars.Concat(customerLastThreeChars);
            //foreach (var str in allLastThreeChars)
            //{
            //    Console.WriteLine(str);
            //}


            #endregion

            #endregion

            #region LINQ - Partitioning Operators

            #region Get the first 3 orders from customers in Washington

            //var first3OrdersFromWashington = ListGenerator.CustomersList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);
            //foreach (var order in first3OrdersFromWashington)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate:d}, Total: {order.Total:C}");
            //}


            #endregion

            #region Get all but the first 2 orders from customers in Washington

            //var allButFirst2OrdersFromWashington = ListGenerator.CustomersList
            //    .Where(c => c.Region == "WA")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);
            //foreach (var order in allButFirst2OrdersFromWashington)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate:d}, Total: {order.Total:C}");
            //}

            #endregion

            #region Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.TakeWhile((n, index) => n >= index);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Get the elements of the array starting from the first element divisible by 3.

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}


            #endregion


            #region Get the elements of the array starting from the first element less than its position

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers.SkipWhile((n, index) => n > index);
            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}




            #endregion


            #endregion

            #region LINQ - Quantifiers

            #region Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //bool containsEi = ListGenerator.DictionaryWords.Any(word => word.Contains("ei", StringComparison.OrdinalIgnoreCase));
            //Console.WriteLine(containsEi);



            #endregion

            #region Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //var categoriesWithOutOfStockProducts = ListGenerator.ProductsList
            //    .Where(p => p.UnitsInStock == 0)
            //    .GroupBy(p => p.Category);
            //foreach (var categoryGroup in categoriesWithOutOfStockProducts)
            //    {
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"\tProduct: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}



            #endregion


            #region Return a grouped a list of products only for categories that have all of their products in stock.

            //var categoriesWithAllProductsInStock = ListGenerator.ProductsList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));
            //foreach (var categoryGroup in categoriesWithAllProductsInStock)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"\tProduct: {product.ProductName}, Units In Stock: {product.UnitsInStock}");
            //    }
            //}


            #endregion


            #endregion
        }
    }
}
