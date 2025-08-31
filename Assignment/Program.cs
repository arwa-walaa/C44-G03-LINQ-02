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

            var averagePriceByCategory = from p in ListGenerator.ProductsList
                                         group p by p.Category into g
                                         select new
                                         {
                                             Category = g.Key,
                                             AveragePrice = g.Average(p => p.UnitPrice)
                                         };
            foreach (var item in averagePriceByCategory)
            {
                Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice:C}");
            }


            #endregion

            #endregion
        }
    }
}
