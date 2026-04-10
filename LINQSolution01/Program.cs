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


        }
    }
}
