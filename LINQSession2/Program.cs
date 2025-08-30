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

            var list1 = Enumerable.Range(0, 100);
            var list2 = Enumerable.Range(50, 100);

            var Result= list1.Union(list2);
            //Result= list1.Concat(list2);
            //Result= list1.Intersect(list2);
            //Result= list1.Except(list2);

            Result = list1.Concat(list2);
            Result = Result.Distinct();
            foreach (var item in Result)
            {
                Console.Write(item+" ");
            }

            #endregion

        }


    }
}
