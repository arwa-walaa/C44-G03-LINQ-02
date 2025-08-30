using Day_01_G03;
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace LINQSession2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Casting Operators

            #region Get product out os stok

            //List<Product> products=ListGenerator.ProductsList.Where(P=>P.UnitsInStock==0).ToList();

            //Product[] Result =  ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToArray();

            //Dictionary<long, Product> Res = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P=>P.ProductID) ;
            //Dictionary<long, string> Res = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToDictionary(P => P.ProductID,P=>P.ProductName);


            //HashSet<Product> Products = ListGenerator.ProductsList.Where(P => P.UnitsInStock == 0).ToHashSet(); ;


            //OfType()

            //ArrayList arrayList = new ArrayList()
            //{
            //    "Ahmed",
            //    "Omar",
            //    "Mai",
            //    1,
            //    2,
            //    3
            //};
            //var names = arrayList.OfType<string>();

            //foreach (var product in names)
            //{
            //    //Console.WriteLine(product.Key + " : " + product.Value);
            //    Console.WriteLine(product);
            //}

            #endregion

            #endregion

            #region Generation Operators 

            //deferred execution
            ////fluent syntax
            //var Res=Enumerable.Range(0, 100);
            //Res=Enumerable.Repeat(3, 100);
            //var list = Enumerable.Empty<Product>();
            ////               ==
            //List<Product> list2 = new List<Product>();

            //foreach (var item in Res)
            //{
            //    Console.Write(item);
            //}


            #endregion

            #region Set Operators[Union Family]

            //var list1 = Enumerable.Range(0, 100);
            //var list2 = Enumerable.Range(50, 100);

            //var Result= list1.Union(list2);
            ////Result= list1.Concat(list2);
            ////Result= list1.Intersect(list2);
            ////Result= list1.Except(list2);

            //Result = list1.Concat(list2);
            //Result = Result.Distinct();
            //foreach (var item in Result)
            //{
            //    Console.Write(item+" ");
            //}

            #endregion

            #region Quantifire Operators

            //var products = ListGenerator.ProductsList.Any(P=>P.UnitsInStock>1000);
            ////var products = ListGenerator.ProductsList.All(P => P.UnitsInStock >= 0);
            //Console.Write(products );

            //var list1 = Enumerable.Range(0, 100);
            //var list2 = Enumerable.Range(0, 100);

            //var res = list1.SequenceEqual(list2);
            //Console.Write(res);



            #endregion


            #region Zipping Operators

            // //zip()
            // string[] names = { "Ahmed", "Omar", "Mai" ,"Hossam" };
            // int[] ages = Enumerable.Range(1,10).ToArray();
            // char[] firstCharOfNames = { 'A', 'O', 'M','H','E' };

            // //var res = names.Zip(firstCharOfNames);
            //var res= names.Zip(ages, firstCharOfNames);
            // foreach (var item in res)
            // {
            //     Console.WriteLine(item);
            // }

            #endregion

            #region Grouping Operator 

            #region Get product Grouped by Category 
            //fluent syntax
            //var products = ListGenerator.ProductsList.GroupBy(P => P.Category);
            //query syntax
            //var products = from product in ListGenerator.ProductsList
            //                group product by product.Category;

            //foreach (var group in products)
            //{
            //    Console.WriteLine($"Category : {group.Key} ");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"\t Product Name : {product.ProductName} ");
            //    }
            //}

            #endregion

            #region Get product out stock Grouped by Category


            //fluent syntax
            //var products = ListGenerator.ProductsList
            //    .Where(P => P.UnitsInStock == 0)
            //    .GroupBy(P => P.Category);

            //query syntax
            //var products = from product in ListGenerator.ProductsList
            //               where product.UnitsInStock == 0
            //               group product by product.Category;


            //foreach (var group in products)
            //{
            //    Console.WriteLine($"Category : {group.Key} ");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"\t Product Name : {product.ProductName} ");
            //    }
            //}

            #endregion

            #region Get prouct in stock grouped by category that contain more than 10 products

            //fluent syntax
            //var products = ListGenerator.ProductsList
            //    .Where(P => P.UnitsInStock > 0)
            //    .GroupBy(P => P.Category)
            //    .Where(P => P.Count() > 10);

            //query syntax
            //var products = from product in ListGenerator.ProductsList
            //               where product.UnitsInStock > 0
            //               group product by product.Category
            //               into prodGroup
            //               where prodGroup.Count() > 10
            //               select prodGroup;



            //foreach (var category in products)
            //{
            //    Console.WriteLine($"Category : {category.Key} ");
            //    foreach (var product in category)
            //    {
            //        Console.WriteLine($"\t Product Name : {product.ProductName} ");
            //    }
            //}

            #endregion

            #region Get Category name of products in stock that contain more than 10 products and number of product in each category
            //fluent syntax
            //var products = ListGenerator.ProductsList
            //    .Where(P => P.UnitsInStock > 0)
            //    .GroupBy(P => P.Category)
            //    .Where(C => C.Count() > 10)
            //    .Select(X => new
            //    {
            //        CategoryName = X.Key,
            //        NumberOfProducts = X.Count()
            //    });
            //query syntax
            //var products = from product in ListGenerator.ProductsList
            //               where product.UnitsInStock > 0
            //               group product by product.Category
            //               into prodGroup
            //               where prodGroup.Count() > 10
            //               select new
            //               {
            //                   CategoryName = prodGroup.Key,
            //                   NumberOfProducts = prodGroup.Count()
            //               };


            //foreach (var category in products)
            //{
            //    Console.WriteLine( category);
               
            //}

            #endregion

            #endregion
        }


    }
}
