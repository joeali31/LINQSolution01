using LINQSolution01.DataSources;
using LINQSolution01.Models;

namespace LINQSolution01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question01
            //var products = Source.ProductList
            //               .Where(p => p.Category == "Seafood")
            //               .Select(p => new { p.ProductName, p.UnitPrice });

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question02
            // Get a list of only the product names from ProductList. Print each name.

            //var productNames = Source.ProductList.Select(p => new { p.ProductName });

            //foreach (var item in productNames)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question03
            // Sort all products by UnitPrice (ascending). Print each product's name and price.

            //var products = Source.ProductList.OrderBy(p => p.UnitPrice).Select(p => new { p.ProductName , p.UnitPrice });
            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question04
            // Get all products where UnitPrice is between 10 and 30

            //var products = Source.ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30).Select(p => p);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion


            #region Question05
            // Get all products that are in stock (UnitsInStock > 0) and belong to the "Condiments" category.

            //var products = Source.ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments").Select(p => p);

            //foreach (var item in products)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
