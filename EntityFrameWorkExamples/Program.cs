using EntityFrameWorkExamples.EF;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkExamples
{

    public class Program
    {
        static void Main(string[] args)
        {
            string MySqlQuery = "SELECT ID,PRODUCT,YEAR,[MONTH NAME] AS MonthInString,PROFIT AS ProfitAmount FROM T_ELITE_PRODUCT_SALE WHERE ID=1";
                 

            Model1 RestaurantdbContext = new Model1();
            RestaurantdbContext.Database.Log =
                (string s) =>
                {
                    Console.WriteLine(s);
                };
            /*   List<Profit> profits = RestaurantdbContext.Profits.SqlQuery(MySqlQuery).ToList();
                foreach (var item in profits)
                {
                    Console.WriteLine(item.Id);
                    Console.WriteLine(item.Product);
                    Console.WriteLine(item.Year);
                    Console.WriteLine(item.MonthInString);
                    Console.WriteLine(item.ProfitAmount);
                }
                var pro = RestaurantdbContext.Database.SqlQuery<string>("SELECT TOP 1 PRODUCT FROM T_ELITE_PRODUCT_SALE").FirstOrDefault();
                Console.WriteLine(pro);*/
            List<Profit> profits = RestaurantdbContext.Database.ExecuteSqlCommand("SELECT TOP 1 PRODUCT FROM T_ELITE_PRODUCT_SALE");


            ////Create
            /* T_ELITE_CATEGORY sale = new T_ELITE_CATEGORY();
             sale.CATEGORY= "category2";

            RestaurantdbContext.T_ELITE_CATEGORY.Add(sale);
             RestaurantdbContext.SaveChanges();

              foreach (T_ELITE_CATEGORY category in RestaurantdbContext.T_ELITE_CATEGORY.ToList())

              {
                  Console.WriteLine(category.ID);
                  Console.WriteLine(category.CATEGORY);*/

            /*  var res1 = RestaurantdbContext.EliteProductSales
                                            .GroupBy(k => new { k.Year, k.Product }, (Keys, result)
                                    => new { year = Keys.Year, prod = Keys.Product, TotalGrosssale = result.ToList()
                                    .Sum(s => s.Gross_Sales) })
                                    .OrderBy(k => k.TotalGrosssale
                                    );

              foreach (var item in res1)
              {
                  Console.WriteLine($"Product : {item.prod}");
                  Console.WriteLine($"Year : {item.year}");
                  Console.WriteLine($"TotalGrossSale : {item.TotalGrosssale}");
              }
              var res2 = RestaurantdbContext.EliteProductSales
                  .GroupBy(k => new { k.Year, k.Product }, (keys, result)
                       => new
                       {
                           year = keys.Year,
                           keys.Product,
                           TotalProfit = result.ToList()
                       .Sum(s => s.Profit)
                       })
                      .OrderBy(k => k.TotalProfit);
              foreach (var item in res2)
              {
                  Console.WriteLine(item.year);
                  Console.WriteLine(item.Product);
                  Console.WriteLine(item.TotalProfit);

              }*/
            /* var output = RestaurantdbContext.EliteProductSales
                 .GroupBy(k => new { k.Month_Name, k.Year, k.Product }, (keys, result)
                      => new
                      {
                          keys.Month_Name,
                          keys.Product,
                          keys.Year,
                          MaxProductsSoldByMonth = result.Max(x => x.Units_Sold),
                      })
                 .GroupBy(g => new { g.Product, g.Year }, (gk, rs)
                    => new
                    {
                        gk.Year,
                        gk.Product,
                        Row = rs.Where(y => y.MaxProductsSoldByMonth == rs.Max(l => l.MaxProductsSoldByMonth)).FirstOrDefault()
                    })

                    .OrderBy(k => k.Product)
                    ;
             foreach (var item in output)
             {
                 Console.Write($"{item.Product}-");
                 Console.Write($"{item.Year}-");
                 Console.Write($"{item.Row}-");
                 Console.WriteLine(item.Row.Month_Name);


             }*/
            Console.ReadKey();
        }
    }
    }

